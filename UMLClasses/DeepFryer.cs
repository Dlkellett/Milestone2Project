using System;
using System.Collections.Generic;
using System.Text;

namespace UMLClasses
{
    // Construct Deep Fryer class
    public class DeepFryer : OutdoorCooking
    {
        public int tankAmount { get; private set; }
        public int gallonAmount { get; private set; }

        /// <summary>
        /// Create a DeepFryer Constructor 
        /// </summary>
        /// <param name="colorVal"></param>
        /// <param name="materialVal"></param>
        /// <param name="brandVal"></param>
        /// <param name="maxTempVal"></param>
        /// <param name="fuleTypeVal"></param>
        /// <param name="invUpdateVal"></param>
        /// <param name="tankAmountVal"></param>
        /// <param name="gallonAmountVal"></param>
        public DeepFryer(string colorVal, string materialVal, string brandVal, int maxTempVal, string fuleTypeVal, int invUpdateVal, int tankAmountVal, 
            int gallonAmountVal) : base(colorVal, materialVal, brandVal, maxTempVal, fuleTypeVal, invUpdateVal)
        {
            tankAmount = tankAmountVal;
            gallonAmount = gallonAmountVal;
        }
    }
}
