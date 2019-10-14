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
	public partial class Page4 : ContentPage
	{
		public Page4 ()
		{
			InitializeComponent ();
            Stepper_ValueChanged(stp01, null);
		}

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Stepper stp = (Stepper)sender;
            lbl01.Text = stp.Value.ToString();

            btn01.BorderWidth = stp.Value;
        }
    }
}