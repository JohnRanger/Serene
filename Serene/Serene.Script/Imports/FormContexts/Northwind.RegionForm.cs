
namespace Serene.Northwind
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using Serene.Northwind;

    public partial class RegionForm : PrefixedContext
    {
        public RegionForm(string idPrefix) : base(idPrefix) {}
    
        public IntegerEditor RegionID { get { return ById<IntegerEditor>("RegionID"); } }
        public DateTimeEditor RegionDescription { get { return ById<DateTimeEditor>("RegionDescription"); } }
    }
}

