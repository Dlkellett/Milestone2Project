using System;
using System.Collections.Generic;
using System.Text;

namespace UMLClasses
{
    // Construct GasGrill Class
    public class GasGrill : OutdoorCooking
    {
        public int startupTime { get; private set; }
        public string tempComtrolKnobs { get; private set; }

        /// <summary>
        /// Create a GasGrill constructor
        /// </summary>
        /// <param name="colorVal"></param>
        /// <param name="materialVal"></param>
        /// <param name="brandVal"></param>
        /// <param name="maxTempVal"></param>
        /// <param name="fuleTypeVal"></param>
        /// <param name="invUpdateVal"></param>
        /// <param name="startupTimeVal"></param>
        /// <param name="tempControlKnobsVal"></param>
        public GasGrill(string colorVal, string materialVal, string brandVal, int maxTempVal, string fuleTypeVal, int invUpdateVal, int startupTimeVal,
            string tempControlKnobsVal) : base(colorVal, materialVal, brandVal, maxTempVal, fuleTypeVal, invUpdateVal)
        {
            startupTime = startupTimeVal;
            tempComtrolKnobs = tempControlKnobsVal;
        }
    }
}
