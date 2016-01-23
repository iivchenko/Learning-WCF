using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.Windows.Input;

namespace Client
{
    public class ChatViewModel : INotifyPropertyChanged, Chat.Registration.IRegistryServiceCallback
    {
        private Chat.Registration.RegistryServiceClient _registryService;
        private Chat.Messaging.MessageServiceClient _messageService;

        private ConnectionStatus _status;

        private string _host;
        private string _port;
        private string _name;

        private string _message;

        public ChatViewModel()
        {
            _status = ConnectionStatus.Disconnected;
            History = new ObservableCollection<string>();
        }

        public ConnectionStatus Status
        {
            get
            {
                return _status;
            }

            set
            {
                _status = value;

                OnPropertyChanged();
            }
        }

        public string Host
        {
            get
            {
                return _host;

            }

            set
            {
                _host = value;

                OnPropertyChanged();
            }
        }

        public string Port
        {
            get
            {
                return _port;
            }

            set
            {
                _port = value;

                OnPropertyChanged();
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;

                OnPropertyChanged();
            }

        }

        public string Message
        {
            get
            {
                return _message;
            }

            set
            {
                _message = value;

                OnPropertyChanged();
            }
        }

        public ObservableCollection<string> History { get; set; }

        public ICommand Connect
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (_registryService != null && _registryService.State != CommunicationState.Closed)
                    {
                        _registryService.Close();
                    }

                    _registryService = new Chat.Registration.RegistryServiceClient(new InstanceContext(this), new NetTcpBinding(), new EndpointAddress(string.Format("net.tcp://{0}:{1}/Chat/Registration", Host, Port)));
                   
                    var request = new Chat.Registration.RegisterRequest
                    {
                        Name = Name
                    };

                    var responce = _registryService.Register(request);

                    if (responce.Result == Chat.Registration.RegistrationResult.Success)
                    {
                        Status = ConnectionStatus.Connected;
                        _messageService = new Chat.Messaging.MessageServiceClient(new NetTcpBinding(), new EndpointAddress(string.Format("net.tcp://{0}:{1}/Chat/Messaging", Host, Port)));
                    }
                    else
                    {
                        Name = "Use another name!";
                    }
                });
            }
        }

        public ICommand SendCmd
        {
            get
            {
                return new RelayCommand(() =>
                {
                    var msg = new Chat.Messaging.Message
                    {
                        Sender = Name,
                        MessageMember = Message
                    };

                    _messageService.Send(msg);

                    History.Add(string.Format("{0}: {1}", msg.Sender, msg.MessageMember));
                    Message = string.Empty;
                },
                () => Status == ConnectionStatus.Connected);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Send(Chat.Registration.Message message)
        {
            History.Add(string.Format("{0}: {1}", message.Sender, message.MessageMember));
        }
    }
}
