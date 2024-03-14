// Listing 9-3 - 9-6

namespace CleanCodeChapter9
{
    public class EnvironmentController
    {
        private string temperature = "";

        private bool heater = true;
        private bool blower = true;
        private bool cooler = true;
        private bool hiTempAlarm = true;
        private bool loTempAlarm = true;

        public string GetState()
        {
            string state = "";
            state += heater ? "H" : "h";
            state += blower ? "B" : "b";
            state += cooler ? "C" : "c";
            state += hiTempAlarm ? "H" : "h";
            state += loTempAlarm ? "L" : "l";
            return state;
        }

        public void SetTemp(string temp)
        {
            if (temp == "WAY_TOO_COLD")
            {
                temperature = temp;
                heater = true;
                blower = true;
                cooler = false;
                hiTempAlarm = false;
                loTempAlarm = true;
            }
        }

        public void wayTooCold()
        {
            temperature = "WAY_TOO_COLD";
            heater = true;
            blower = true;
            cooler = false;
            hiTempAlarm = false;
            loTempAlarm = true;
        }

        public void TooHot()
        {
            temperature = "TOO_HOT";
            heater = false;
            blower = true;
            cooler = true;
            hiTempAlarm = false;
            loTempAlarm = false;
        }

        public void TooCold()
        {
            temperature = "TOO_COLD";
            heater = true;
            blower = true;
            cooler = false;
            hiTempAlarm = false;
            loTempAlarm = false;
        }

        public void WayTooHot()
        {
            temperature = "TOO_HOT";
            heater = false;
            blower = true;
            cooler = true;
            hiTempAlarm = true;
            loTempAlarm = false;
        }

        public bool HeaterState()
        {
            return heater;
        }

        public bool BlowerState()
        {
            return blower;
        }

        public bool CoolerState()
        {
            return cooler;
        }

        public bool HiTempAlarm()
        {
            return hiTempAlarm;
        }

        public bool LoTempAlarm()
        {
            return loTempAlarm;
        }
    }
}
