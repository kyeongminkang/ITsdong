using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch16
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();

            Device.StartTimer(TimeSpan.FromMilliseconds(1000), OnTimer);
		}

        bool OnTimer()
        {
            DateTime dt = DateTime.Now;
            lblDate.Text = dt.ToString("D");
            lblTime.Text = dt.ToString("T");
            return true;
        }
	}
}