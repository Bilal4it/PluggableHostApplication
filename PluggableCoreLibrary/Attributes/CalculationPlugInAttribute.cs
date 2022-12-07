using System;
using System.Collections.Generic;
using System.Text;

namespace Pluggable.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CalculationPlugInAttribute : Attribute
    {
        public CalculationPlugInAttribute(string description)
        {
            Description = description;
        }

        public string Description
        {
            get; set;
        }
         
    }
}
