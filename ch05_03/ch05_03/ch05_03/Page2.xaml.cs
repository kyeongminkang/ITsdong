using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ch05_03
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();
            CalcDate();
		}

        private void DtStart_DateSelected(object sender, DateChangedEventArgs e)
        {
            CalcDate();
        }

        private void DtEnd_DateSelected(object sender, DateChangedEventArgs e)
        {
            CalcDate();
        }

        private void CalcDate()
        {
            DateTime start = dtStart.Date;
            DateTime end = dtEnd.Date;

            lbl01.Text = string.Format("개발기간 : {0}일", (end - start).Days);
        }
    }
}