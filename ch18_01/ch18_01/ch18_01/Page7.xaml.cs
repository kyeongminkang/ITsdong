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
	public partial class Page7 : ContentPage
	{
		public Page7 ()
		{
			InitializeComponent ();
            DrawColor();
		}

        private void DrawColor()
        {
            bv.BackgroundColor = new Color(slRed.Value, slGreen.Value, slBlue.Value);
        }

        private void SlRed_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            DrawColor();
        }

        private void SlGreen_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            DrawColor();
        }

        private void SlBlue_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            DrawColor();
        }

        private void ContentPage_SizeChanged(object sender, EventArgs e)
        {
            // 가로모드
            if(Width > Height)
            {
                grd.RowDefinitions[1].Height = new GridLength(0, GridUnitType.Absolute);
                grd.ColumnDefinitions[1].Width = new GridLength(1, GridUnitType.Star);

                Grid.SetRow(stack, 0);
                Grid.SetColumn(stack, 1);
            }else
            {
                grd.RowDefinitions[1].Height = GridLength.Auto;
                grd.ColumnDefinitions[1].Width = new GridLength(0, GridUnitType.Absolute);

                Grid.SetRow(stack, 1);
                Grid.SetColumn(stack, 0);
            }
        }
    }
}