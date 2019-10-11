using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ch18_03
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
            //IDeviceInfo info = new DeviceInfo();
            // 컴파일 참조를 보류시켜야함 why? 언제 쓸 지 모르니까!
            // 여기서는 컴파일을 스킵함. 인터페이스 디바이스 인포를 구현한 객체 반환 
            IDeviceInfo info = DependencyService.Get<IDeviceInfo>();

            lblDeviceName.Text = info.GetModel();
            lblOSVersion.Text = info.GetVersion();

        }
    }
    //class DeviceInfo : IDeviceInfo
    //{
    //    public string GetModel()
    //    {
    //        return "";
    //    }
    //    public string GetVersion()
    //    {
    //        return "";
    //    }
    //}
    // 각각 OS에서 하는부분
}
