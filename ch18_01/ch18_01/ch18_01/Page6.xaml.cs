using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ch18_01
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page6 : ContentPage
	{
		public Page6 ()
		{
			InitializeComponent ();
		}

        private void BtnBack_Clicked(object sender, EventArgs e)
        {
            lblDisp.Text = lblDisp.Text.Substring(0, lblDisp.Text.Length - 1);

            if(lblDisp.Text == "")
            {
                btnBack.IsEnabled = false;
            }else
            {
                btnBack.IsEnabled = true;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            lblDisp.Text += ((Button)sender).StyleId;
            btnBack.IsEnabled = true;
        }
    }
}