using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ch05_03
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page4 : ContentPage
	{

        DateTime desTime;

		public Page4 ()
		{
			InitializeComponent ();

            Device.StartTimer(TimeSpan.FromSeconds(1), tmr_Timer);
		}

        private bool tmr_Timer()
        {
            if(swTime.IsToggled &&  DateTime.Now >= desTime)
            {
                swTime.IsToggled = false;
                this.DisplayAlert("알림", "약속시간입니다.", "확인");
            }
            Debug.WriteLine("33-current time:" + DateTime.Now.ToLongTimeString());
            Debug.WriteLine("34-current time:" + desTime.ToLongTimeString());
            return true;
        }

        private void TmPicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            SetDesTime();
        }

        private void SwTime_Toggled(object sender, ToggledEventArgs e)
        {
            SetDesTime();
        }

        private void SetDesTime()
        {
            if (swTime.IsToggled)
            {
                // 현재 날짜만 가져옴 타임 빼고
                desTime = DateTime.Today + tmPicker.Time;
                // 오늘 날짜일 경우!
                if (desTime <= DateTime.Now)
                {
                    desTime += TimeSpan.FromDays(1);
                }
            }
            
        }
    }
}