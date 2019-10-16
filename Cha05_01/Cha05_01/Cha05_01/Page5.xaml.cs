using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cha05_01
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page5 : ContentPage
	{
		public Page5 ()
		{
            
			InitializeComponent ();
		}

        private void TxtUrl_Completed(object sender, EventArgs e)
        {
            if (txtUrl.Text.Substring(0, "http://".Length) == "http://" ||
                txtUrl.Text.Substring(0, "https://".Length) == "https://")
            {
                wv.Source = txtUrl.Text;
            }
            else
            {
                wv.Source = "http://" + txtUrl.Text;
            }
        }

        private void BtnBack_Clicked(object sender, EventArgs e)
        {
            wv.GoBack();
        }

        private void BtnForward_Clicked(object sender, EventArgs e)
        {
            wv.GoForward();
        }
    }
}