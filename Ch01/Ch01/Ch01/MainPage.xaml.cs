using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ch01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Sld01_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            // name 이용한 접근
            //lbl01.Text = String.Format("슬라이더 값 : {0:F2}", sld01.Value);

            // sender 이용한 접근
            //Slider sld = (Slider)sender;
            //lbl01.Text = String.Format("슬라이더 값 : {0:F2}", sld.Value);

            // eventargs로 접근 : e.newvalue = 새로운 현재값
            lbl01.Text = String.Format("슬라이더 값 : {0:F2}", e.NewValue);
        }
    }
}
