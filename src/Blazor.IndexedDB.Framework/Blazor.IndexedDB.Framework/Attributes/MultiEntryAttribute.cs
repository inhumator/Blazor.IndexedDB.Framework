using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.IndexedDB.Framework.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class MultiEntryAttribute : Attribute { }
}
