using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ch05_03
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Sb_SearchButtonPressed(object sender, EventArgs e)
        {
            Debug.WriteLine("====> 20: button pressed : " + sb.Text);
        }

        private void Sb_TextChanged(object sender, TextChangedEventArgs e)
        {
            Debug.WriteLine("====> 25:" + sb.Text);
        }
    }
}
