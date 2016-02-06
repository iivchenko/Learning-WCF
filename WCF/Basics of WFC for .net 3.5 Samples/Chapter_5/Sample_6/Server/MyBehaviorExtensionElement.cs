using System;
using System.Configuration;
using System.ServiceModel.Configuration;

namespace Server
{
    internal class MyBehaviorExtensionElement : BehaviorExtensionElement 
    {
        [ConfigurationProperty("SupperValue", DefaultValue = ";)", IsRequired = true)]
        public string SupperValue
        {
            get { return (string) base["SupperValue"]; }
            set { base["SupperValue"] = value; }
        }

        protected override object CreateBehavior()
        {
            return new MyServiceBehavior(SupperValue);
        }

        public override Type BehaviorType
        {
            get { return typeof (MyServiceBehavior); }
        }
    }
}
