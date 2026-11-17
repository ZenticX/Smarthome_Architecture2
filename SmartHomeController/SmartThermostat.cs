using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SmartHomeController
{
    internal class SmartThermostat : SmartDevice
    {
        //private fields
        private double currentTemperature;
        private double targetTemperature;

        //public properties

        public double CurrentTemperature
        {
            get { return currentTemperature; }
            set { currentTemperature = value; }
        }

        public double TargetTemperature
        {
            get { return targetTemperature; }
            set { targetTemperature = value; }
        }

        // Parameterised constructor
        public SmartThermostat(double smartThermostatCurrentTemperature, double smartThermostatTargetTemperature, int smartDeviceID, string smartDeviceName, bool smartDeviceStatus) : base(
                    smartDeviceID,
                    smartDeviceName,
                    smartDeviceStatus
                    )
        {
            CurrentTemperature = smartThermostatCurrentTemperature;
            TargetTemperature = smartThermostatTargetTemperature;


        }
        // methods
        public void SetTemperature()
        {
        }

        public void GetCurrentTemperature()
        {
        }
        
        public void SetCurrentTemperature()
        {
        }
        public override void GetStatus() 
        {

        }

    }
}
