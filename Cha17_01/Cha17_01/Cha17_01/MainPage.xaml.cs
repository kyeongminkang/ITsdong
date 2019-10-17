using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cha17_01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Pic01_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("====> SelectedIndex : " + pic01.SelectedIndex);
            Debug.WriteLine("====> SelectedItem : " + pic01.SelectedItem);
        }
    }
}
