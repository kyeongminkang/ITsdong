using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ch15_01
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page5 : ContentPage
	{
		public Page5 ()
		{
			InitializeComponent ();
		}

        private void Btn01_Clicked(object sender, EventArgs e)
        {
            Resources["buttonStyle"] = Resources["buttonStyle1"];
        }

        private void Btn02_Clicked(object sender, EventArgs e)
        {
            Resources["buttonStyle"] = Resources["buttonStyle2"];
        }

        private void Btn03_Clicked(object sender, EventArgs e)
        {
            Resources["buttonStyle"] = Resources["buttonStyle3"];
        }

        private void BtnReset_Clicked(object sender, EventArgs e)
        {
            Resources["buttonStyle"] = null;
        }
    }
}