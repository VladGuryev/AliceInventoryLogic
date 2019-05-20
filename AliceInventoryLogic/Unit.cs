using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestLogic
{
    public class Unit
    {
        public string UnitName { get; set; }

        public Unit(string unitName)
        {
            UnitName = unitName;
        }
        public List<string> GetSynonyms()
        {
            return new List<string>();
        }

        public override string ToString()
        {
            return UnitName;
        }
       
    }
}
