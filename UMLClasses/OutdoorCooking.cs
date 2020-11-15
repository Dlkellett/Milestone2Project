using System;

namespace UMLClasses
{
    public class OutdoorCooking
    {
        private int invCurrent;

        // Declare all getters and setters
        public string color { get; private set; }
        public string material { get; private set; }
        public string brand { get; private set; }
        public int maxTemp { get; private set; }
        public string fuleType { get; private set; }
        public int invUpdate { get; private set; }

        // Create the constructor 
        public OutdoorCooking(string colorVal, string materialVal, string brandVal, int maxTempVal, string fuleTypeVal, int invUpdateVal)
        {
            // Set the private attributes 
            color = colorVal;
            material = materialVal;
            brand = brandVal;
            maxTemp = maxTempVal;
            fuleType = fuleTypeVal;
            invUpdate = invUpdateVal;
            invCurrent = 37;
        }

        // Calculates the total inventory 
        public int CalInvenotry()
        {
            return invCurrent + invUpdate;
        }
    }
}
