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
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
			InitializeComponent ();
		}

        private void SldFade_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            // sldFade.value = 0~1
            lbl01.Opacity = 1 - sldFade.Value;
            lbl02.Opacity = sldFade.Value;

            AbsoluteLayout.SetLayoutBounds(lbl01,
                new Rectangle(sldFade.Value, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            AbsoluteLayout.SetLayoutBounds(lbl02,
                new Rectangle(1-sldFade.Value, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        }
    }
}