using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ch05
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry txt = (Entry)sender;
            Debug.WriteLine("======> 24 : " + txt.Text);

        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            Debug.WriteLine("======> 30 : " + "Completed!");
        }
    }
}