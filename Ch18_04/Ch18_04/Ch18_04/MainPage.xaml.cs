using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ch18_04
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            SetHandler();
        }

        private void SetHandler()
        {
            btnC4.Clicked += BtnSound_Clicked;
            btnD4.Clicked += BtnSound_Clicked;
            btnE4.Clicked += BtnSound_Clicked;
            btnF4.Clicked += BtnSound_Clicked;
            btnG4.Clicked += BtnSound_Clicked;
            btnA5.Clicked += BtnSound_Clicked;
            btnB5.Clicked += BtnSound_Clicked;
            btnC5.Clicked += BtnSound_Clicked;
        }

        private void BtnSound_Clicked(object sender, EventArgs e)
        {
            switch (((Button)sender).StyleId)
            {
                case "C4":
                    Debug.WriteLine("=== 도 ===");
                    // Piano.Play(주파수, 길이);
                    break;
                case "D4":
                    Debug.WriteLine("=== 레 ===");
                    break;
                case "E4":
                    Debug.WriteLine("=== 미 ===");
                    break;
                case "F4":
                    Debug.WriteLine("=== 파 ===");
                    break;
                case "G4":
                    Debug.WriteLine("=== 솔 ===");
                    break;
                case "A5":
                    Debug.WriteLine("=== 라 ===");
                    break;
                case "B5":
                    Debug.WriteLine("=== 시 ===");
                    break;
                case "C5":
                    Debug.WriteLine("=== 도 ===");
                    break;

            }
        }
    }
}
