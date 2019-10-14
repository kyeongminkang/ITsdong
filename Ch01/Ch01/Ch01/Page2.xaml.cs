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
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();

            InitColor();
            //DrawBox();
		}

        private void InitColor()
        {
            sldRed.Value = 128;
            sldGreen.Value = 128;
            sldBlue.Value = 128;
        }

        private void SldRed_ValueChanged(object sender, ValueChangedEventArgs e)
        {

            lblRed.Text = string.Format("Red = {0:F0} - 0x{1:X2}", sldRed.Value, (int)sldRed.Value);
            DrawBox();
            
        }

        private void DrawBox()
        {
            int intRed = (int)sldRed.Value;
            int intGreen = (int)sldGreen.Value;
            int intBlue = (int)sldBlue.Value;

            bv01.BackgroundColor = Color.FromRgb(intRed, intGreen, intBlue);
        }

        private void SldGreen_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblGreen.Text = string.Format("Green = {0:F0} - 0x{1:X2}", sldGreen.Value, (int)sldGreen.Value);
            DrawBox();
        }

        private void SldBlue_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblBlue.Text = string.Format("Blue = {0:F0} - 0x{1:X2}", sldBlue.Value, (int)sldBlue.Value);
            DrawBox();
        }
    }
}