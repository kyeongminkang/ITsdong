using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly:Dependency(typeof(Ch18_03.iOS.DeviceInfo))]
namespace Ch18_03.iOS
{
    public class DeviceInfo : IDeviceInfo
    {
        UIDevice d = new UIDevice();

        public string GetModel()
        {
            return d.Model.ToLower();
        }

        public string GetVersion()
        {
            return d.SystemName + " - " + d.SystemVersion;
        }
    }
}