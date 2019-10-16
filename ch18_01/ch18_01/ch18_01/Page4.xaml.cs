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
	public partial class Page4 : ContentPage
	{
        int count = 10;
        Random rnd = new Random();

		public Page4 ()
		{
			InitializeComponent ();

            List<View> views = new List<View>();

            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;

            for (int i=0; i< count; i++)
            {
                BoxView bv = new BoxView()
                {
                    Color = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)),
                    HeightRequest = 300 * rnd.NextDouble(),
                    VerticalOptions = LayoutOptions.End,
                    StyleId = "bv" + i.ToString()
                    
                };

                bv.GestureRecognizers.Add(tap);
                
                views.Add(bv);
            }

           
            grid.Children.AddHorizontal(views);

		}

        private void Tap_Tapped(object sender, EventArgs e)
        {
            BoxView bv = (BoxView)sender;

            this.DisplayAlert("제품코드 : "+ bv.StyleId, "판매량 : "+ ((int)bv.Height).ToString(), "확인");
        }
    }
}