using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cha17_01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();

            lst01.ItemsSource = new List<Color>
            {
               Color.AliceBlue,
               Color.AntiqueWhite,
               Color.Aqua,
               Color.Aquamarine,
               Color.Azure,
               Color.Beige,
               Color.Bisque,
               Color.Black,
               Color.BlanchedAlmond,
               Color.Blue,
               Color.BlueViolet,
               Color.Brown,
               Color.BurlyWood,
               Color.CadetBlue,
               Color.Chartreuse,
               Color.DarkBlue,
               Color.Firebrick,
               Color.Gainsboro,
               Color.Honeydew,
               Color.IndianRed,
               Color.WhiteSmoke

            };

        }

        private void Lst01_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Debug.WriteLine("====>49: list01_ItemSelected ");
            bv.Color = ((Color)lst01.SelectedItem);
        }

        private void Lst01_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Debug.WriteLine("====>55: list01_ItemTapped ");
            bv.Color = ((Color)lst01.SelectedItem);
        }
    }
}