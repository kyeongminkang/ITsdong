using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch21
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();

            btnInc.Clicked += BtnInc_Clicked;
            btnDec.Clicked += BtnDec_Clicked;
		}

        private void BtnDec_Clicked(object sender, EventArgs e)
        {
            this.Resources["fontSize"] = ((double)this.Resources["fontSize"]) - 1;
        }

        private void BtnInc_Clicked(object sender, EventArgs e)
        {
            this.Resources["fontSize"] = ((double)this.Resources["fontSize"]) + 1;
        }
    }
}