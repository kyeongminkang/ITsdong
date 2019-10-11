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
	public partial class Page4 : ContentPage
	{
		public Page4 ()
		{
			InitializeComponent ();
		}

        private void Btn01_Clicked(object sender, EventArgs e)
        {
            lbl01.Text = "안녕하세요. 자마린 입니다.";
        }
    }
}