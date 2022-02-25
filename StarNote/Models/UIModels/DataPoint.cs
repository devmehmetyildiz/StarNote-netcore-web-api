using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Models.UIModels
{
    public class DataPoint
    {
        public string Argument { get; private set; }
        public double Value { get; private set; }
        public DataPoint(string argument, double value)
        {
            Argument = argument;
            Value = value;
        }
    }
}
