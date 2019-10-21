using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cha24_01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                lblTime.Text = DateTime.Now.ToString("T");
                return true;
            });
        }

        // main에서만 사용가능!
        private async void BtnDelete_Clicked(object sender, EventArgs e)
        {
            // 삭제처리 ...

            await DisplayAlert("알림", "삭제되었습니다.", "확인");

            // awiat 하지 않으면 알람과 텍스트가 동시에 뜬다!
            lblDisp.Text = "삭제가 완료 되었습니다.";

        }
    }
}