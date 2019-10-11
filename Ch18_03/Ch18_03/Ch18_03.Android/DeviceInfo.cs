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
using Xamarin.Forms;

// 네임스페이스는 변경하지 않아도 되지만 어노테이션이 필요!
// dependency 서비스에서 콜해서 들어오는 패키지라는 뜻
[assembly: Dependency(typeof(Ch18_03.Droid.DeviceInfo))]
namespace Ch18_03.Droid
{
    public class DeviceInfo : IDeviceInfo
    {
        // 역참조!
        public string GetModel()
        {
            return Build.Manufacturer + " - " + Build.Model;
        }

        public string GetVersion()
        {
            return Build.VERSION.Release.ToString();
        }
    }
}