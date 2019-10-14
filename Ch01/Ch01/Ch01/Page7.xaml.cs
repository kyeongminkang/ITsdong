using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch01
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page7 : ContentPage
	{
		public Page7 ()
		{
			InitializeComponent ();
		}

        private void Btn01_Clicked(object sender, EventArgs e)
        {
            this.DisplayAlert("알림", "주문 완료", "확인");
        }

        private void Chk01_CheckedChanged(object sender, bool e)
        {
            if (chk01.IsChecked)
            {
                txtEMail.IsVisible = true;
                txtEMail.Focus();
            }else
            {
                txtEMail.IsVisible = false;
            }
        }
    }
}