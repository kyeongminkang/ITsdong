using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace Ch18_02
{
    public class DeviceInfo
    {
        public string GetModel()
        {
            UIDevice d = new UIDevice();
            return d.Model;

        }

        public string GetVersion()
        {
            UIDevice d = new UIDevice();
            return d.SystemName + "-" + d.SystemVersion;
        }
    }
}