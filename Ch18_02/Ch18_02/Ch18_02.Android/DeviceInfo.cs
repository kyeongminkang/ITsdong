using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Android.OS;

namespace Ch18_02
    // 네임스페이스 변경! 편하게 하기 위함!
{
    public class DeviceInfo
    {

        public string GetModel()
        {
            return Build.Manufacturer + "-" + Build.Model;
        }

        public string GetVersion()
        {
            return Build.VERSION.Release.ToString();
        }
    }
}