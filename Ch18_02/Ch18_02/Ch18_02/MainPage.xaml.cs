using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
//#if __ANDROID__
//using Android.OS;
//#elif __IOS__
//    using UIKit;
//#endif
namespace Ch18_02
{

    // SAP 방식은 forms에서는 호추를 하고 각 프로젝트에서 구현을 함
    // 단 구현시, 모든 프로젝트에서 namespace 클래스명 함수명이 일치해야함 물론 변수도!
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            DisInfo();
        }

        private void DisInfo()
        {

            DeviceInfo info = new DeviceInfo();
            lblDeviceName.Text = info.GetModel();
            lblOSVersion.Text = info.GetVersion();

//#if __ANDROID__
//            lblDeviceName.Text = Build.Manufacturer + "-" + Build.Model;
//            lblOSVersion.Text = Build.VERSION.Release.ToString();
//#elif __IOS__

//            UIDevice d = new UIDevice();

//            lblDeviceName.Text = d.Model;
//            lblOSVersion.Text = d.SystemName + "-" + d.SystemVersion;
//#endif
        }
    }
}
