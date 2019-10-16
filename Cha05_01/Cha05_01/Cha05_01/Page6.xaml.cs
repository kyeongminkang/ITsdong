using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cha05_01
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page6 : ContentPage
	{
		public Page6 ()
		{
			InitializeComponent ();
            // lbl01.FontSize = 20;  바인딩 취소됨
            // default는 oneway라는것
            lbl03.FontSize = 20;
            lbl04.FontSize = 20;
		}
	}
}