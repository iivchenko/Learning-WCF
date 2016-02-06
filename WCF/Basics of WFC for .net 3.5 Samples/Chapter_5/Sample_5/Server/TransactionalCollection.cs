using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Transactions;

namespace Server
{
    public class TransactionalCollection<T> : IEnlistmentNotification, ICollection<T>
    {
        private Collection<T> _collection;
        private readonly IList<Action<ICollection<T>>> _commands;

        public TransactionalCollection()
        {
            _collection = new Collection<T>();
            _commands = new List<Action<ICollection<T>>>();
        }

        #region Transaction

        public void Prepare(PreparingEnlistment preparingEnlistment)
        {
            preparingEnlistment.Prepared();
        }

        public void Commit(Enlistment enlistment)
        {
            _collection = Apply();

            _commands.Clear();

            enlistment.Done();
        }

        public void Rollback(Enlistment enlistment)
        {
            _commands.Clear();

            enlistment.Done();
        }

        public void InDoubt(Enlistment enlistment)
        {
        }

        #endregion

        #region Collection<T>

        public IEnumerator<T> GetEnumerator()
        {
            return IsInTransation() 
                ? Apply().GetEnumerator() 
                : _collection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            if (IsInTransation())
            {
                _commands.Add(collection => collection.Add(item));
            }
            else
            {
                _collection.Add(item);
            }
        }

        public void Clear()
        {
            if (IsInTransation())
            {
                _commands.Add(collection => collection.Clear());
            }
            else
            {
                _collection.Clear();
            }
        }

        public bool Contains(T item)
        {
            return IsInTransation()
                ? Apply().Contains(item)
                : _collection.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (IsInTransation())
            {
                Apply().CopyTo(array, arrayIndex);
            }
            else
            {
                _collection.CopyTo(array, arrayIndex);
            }
        }

        public bool Remove(T item)
        {
            if (Apply().Remove(item))
            {
                _commands.Add(collection => collection.Remove(item));

                return true;
            }
            
            return false;
        }

        public int Count
        {
            get
            {
                return IsInTransation() 
                    ? Apply().Count 
                    : _collection.Count;
            }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        #endregion

        private bool IsInTransation()
        {
            var currentTx = Transaction.Current;
            if (currentTx != null)
            {
                currentTx.EnlistVolatile(this, EnlistmentOptions.None);

                return true; 
            }

            return false;
        }

        private Collection<T> Apply()
        {
            var tmp = new Collection<T>(_collection.Select(x => x).ToList()); // make a clone

            foreach (var command in _commands)
            {
                command(tmp);
            }

            return tmp;
        }
    }
}
