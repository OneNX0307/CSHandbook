using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationDemo
{
    public class MembershipCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new MembershipElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((MembershipElement)element).Username;
        }

        protected override string ElementName
        {
            get
            {
                return "member";
            }
        }

        protected override bool IsElementName(string elementName)
        {
            return !String.IsNullOrEmpty(elementName) && elementName == "member";
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.BasicMap;
            }
        }

        public MembershipElement this[int index]
        {
            get
            {
                return base.BaseGet(index) as MembershipElement;
            }
        }

        public MembershipElement this[string key]
        {
            get
            {
                return base.BaseGet(key) as MembershipElement;
            }
        }
    }
}
