using System;
using System.Collections.Generic;
using System.Text;

namespace UMLClasses
{
    // Construct a PatioStove Class
    public class PatioStove : OutdoorCooking
    {
        public int burnerAmount { get; private set; }
        public string hoseGuardPresent { get; private set; }

        /// <summary>
        /// Create a PatioStove constructor 
        /// </summary>
        /// <param name="colorVal"></param>
        /// <param name="materialVal"></param>
        /// <param name="brandVal"></param>
        /// <param name="maxTempVal"></param>
        /// <param name="fuleTypeVal"></param>
        /// <param name="invUpdateVal"></param>
        /// <param name="burnerAmountVal"></param>
        /// <param name="hoseGuardPresentVal"></param>
        public PatioStove(string colorVal, string materialVal, string brandVal, int maxTempVal, string fuleTypeVal, int invUpdateVal, int burnerAmountVal,
            string hoseGuardPresentVal) : base(colorVal, materialVal, brandVal, maxTempVal, fuleTypeVal, invUpdateVal)
        {
            burnerAmount = burnerAmountVal;
            hoseGuardPresent = hoseGuardPresentVal;
        }
    }
}
