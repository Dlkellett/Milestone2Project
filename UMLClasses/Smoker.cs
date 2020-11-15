using System;
using System.Collections.Generic;
using System.Text;

namespace UMLClasses
{
    // Construct a Smoker class
    public class Smoker : OutdoorCooking
    {
        public string hangersPresent { get; private set; }

        /// <summary>
        /// Create a Smoker constructor 
        /// </summary>
        /// <param name="colorVal"></param>
        /// <param name="materialVal"></param>
        /// <param name="brandVal"></param>
        /// <param name="maxTempVal"></param>
        /// <param name="fuleTypeVal"></param>
        /// <param name="invUpdateVal"></param>
        /// <param name="hangersPresentVal"></param>
        public Smoker(string colorVal, string materialVal, string brandVal, int maxTempVal, string fuleTypeVal, int invUpdateVal, string hangersPresentVal) 
            : base(colorVal, materialVal, brandVal, maxTempVal, fuleTypeVal, invUpdateVal)
        {
            hangersPresent = hangersPresentVal;
        }
    }
}
