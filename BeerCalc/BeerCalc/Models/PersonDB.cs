using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerCalc.Models
{
    public class PersonDB
    {
        public int Age { get; set; }
        public float DrinkAge { get; set; } // tells what age was person when started drinking
        public string Name { get; set; }
        public int Expierience { get; set; }

        public Dictionary<int, string> CountryDictionary { get; set; }
    }
}