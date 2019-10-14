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
	public partial class Page6 : ContentPage
	{
		public Page6 ()
		{
			InitializeComponent ();
		}

        private void SwItalic_Toggled(object sender, ToggledEventArgs e)
        {
            if(swItalic.IsToggled == true)
            {
                lbl01.FontAttributes |= FontAttributes.Italic; //0010
            }
            else
            {
                // ???? & 1101 - ??0?
                // ???? & ~(0010)
                lbl01.FontAttributes &= ~FontAttributes.Italic;
            }
        }

        // x x x 1 bold
        // x x 1 x itaric
        // ???? | 0010 = ??1?


        private void SwIBold_Toggled(object sender, ToggledEventArgs e)
        {
            if(swIBold.IsToggled == true)
            {
                lbl01.FontAttributes |= FontAttributes.Bold;
            }
            else
            {
                lbl01.FontAttributes &= ~FontAttributes.Bold;
            }

        }
    }
}