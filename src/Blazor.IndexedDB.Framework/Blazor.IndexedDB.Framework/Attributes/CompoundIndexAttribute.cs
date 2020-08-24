using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.IndexedDB.Framework.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class CompoundIndexAttribute : Attribute
    {
        private string name;

        public CompoundIndexAttribute(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }
}
