using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ch16
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //lbl01.TextColor = new Color(1, 0, 0);
            //// 생성자에 의한 프로퍼티 세팅
            //lbl01.TextColor = Color.FromRgb(1.0, 0, 0);
            //// 함수에 의한 프로퍼티 세팅
            //lbl01.TextColor = Color.FromRgb(255, 0, 0);
        }
    }
}
