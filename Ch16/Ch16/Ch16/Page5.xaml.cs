using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch16
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page5 : ContentPage
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            switch (((BoxView)sender).StyleId)
            {
                case "red":
                    this.DisplayAlert("알림", "빨간색을 클릭", "확인");
                    break;
                case "green":
                    this.DisplayAlert("알림", "초록색을 클릭", "확인");
                    break;
                case "blue":
                    this.DisplayAlert("알림", "파란색을 클릭", "확인");
                    break;
            }
        }
    }
}