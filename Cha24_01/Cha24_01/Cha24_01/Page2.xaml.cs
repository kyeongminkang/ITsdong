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
    public partial class Page2 : ContentPage
    {
        public Page2()
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
            // 사용자 확인 창 보여주기
            Task<bool> task = DisplayAlert("삭제확인", "홍길동 고객을 정말로 삭제 하시겠습니까?", "삭제", "취소");
            // 얘는 yes or no라서

            // 콜백함수
            task.ContinueWith((Task<bool> t) =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    if (t.Result == true)
                    {
                        lblDisp.Text = "삭제 되었습니다.";
                    }
                    else
                    {
                        lblDisp.Text = "삭제가 취소되었습니다.";
                    }
                });
                
            });

            lblDisp.Text = "삭제 확인중..";
        }

        //bool bResult;

        //private void alertCallback(Task<bool> t)
        //{
        //    //Debug.WriteLine("===>40:" + t.Result);

        //    //bResult = t.Result;
        //    // Main thread 호출
        //    Device.BeginInvokeOnMainThread(() =>
        //    {
        //        if (t.Result == true)
        //        {
        //            lblDisp.Text = "삭제 되었습니다.";
        //        }
        //        else
        //        {
        //            lblDisp.Text = "삭제가 취소되었습니다.";
        //        }
        //    });
        //}

        //Main thread
        //private void displayCallback()
        //{
        //    if (bResult == true)
        //    {
        //        lblDisp.Text = "삭제 되었습니다.";
        //    }
        //    else
        //    {
        //        lblDisp.Text = "삭제가 취소되었습니다.";
        //    }
        //}
    }
}