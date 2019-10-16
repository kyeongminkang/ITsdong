using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cha05_01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Sld01_ValueChanged(null, null);
        }

        private void Sld01_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lbl01.Opacity = sld01.Value;
        }
    }
}
