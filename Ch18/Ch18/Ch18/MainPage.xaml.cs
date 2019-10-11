using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
#if __ANDROID__
using Android.OS;
#elif __IOS__
    using UIKit;
#endif
namespace Ch18
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            DisInfo();
        }

        private void DisInfo()
        {
#if __ANDROID__
            lblDeviceName.Text = Build.Manufacturer + "-" + Build.Model;
            lblOSVersion.Text = Build.VERSION.Release.ToString();
#elif __IOS__

            UIDevice d = new UIDvice();

            lblDeviceName.Text = d.Model;
            lblOSVerson.Text = d.SystemName + "-" + d.SystemVersion;
#endif
        }
    }
}
