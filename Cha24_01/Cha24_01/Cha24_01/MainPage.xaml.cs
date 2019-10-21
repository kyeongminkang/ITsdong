using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cha24_01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                lblTime.Text = DateTime.Now.ToString("T");
                return true;
            });
        }

        private void BtnDelete_Clicked(object sender, EventArgs e)
        {



            // 삭제 처리..

            // 얘는 서브 스레드야
            DisplayAlert("알림", "홍길동 고객이 삭제 되었습니다.", "확인");

            // alert를 닫던 말던 바로 나옴!
            lblDisp.Text = "삭제 완료!";
        }
    }
}
