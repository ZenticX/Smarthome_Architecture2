using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeController
{
    internal class SmartSecurityCamera : SmartDevice
    {
        // private fields
        private string resolution;
        private bool recordingStatus;

        // public properties
        public string Resolution
        {
            get { return resolution; }
            set { resolution = value; }
        }
        public bool RecordingStatus
        {
            get { return recordingStatus; }
            set { recordingStatus = value; }
        }
        // Parameterised constructor

        public SmartSecurityCamera(string smartSecurityCameraResolution, bool smartSecurityCameraRecordingStatus, int smartDeviceID, string smartDeviceName, bool smartDeviceStatus) : base(
                    smartDeviceID,
                    smartDeviceName,
                    smartDeviceStatus
                    )
        {
            Resolution = smartSecurityCameraResolution;
            RecordingStatus = smartSecurityCameraRecordingStatus;
        }
        // Methods

        public void StartRecording()
        {
        }

        public void StopRecording()
        {
        }

        public override void GetStatus()
        {
        }
        
        public override void TurnOff()
        {
        }

    }
}
