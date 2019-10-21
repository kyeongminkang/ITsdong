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
    public partial class Page3 : ContentPage
    {
        public Page3()
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
            lblDisp.Text = "질문중...";

            // 사용자 확인 창 보여주기
            //Task<bool> task = DisplayAlert("삭제확인", "홍길동 고객을 정말로 삭제 하시겠습니까?", "삭제", "취소");
            //// 대기시킴
            //bool result = await task;

            bool result = await DisplayAlert("삭제확인", "홍길동 고객을 정말로 삭제 하시겠습니까?", "삭제", "취소");
            
            if (result == true)
            {
                lblDisp.Text = "삭제 되었습니다.";
            }else
            {
                lblDisp.Text = "취소 되었습니다.";
            }

        }
    }
}