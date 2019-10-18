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
	public partial class Page10 : ContentPage
	{
		public Page10 ()
		{
			InitializeComponent ();
		}

        private void Lst01_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Debug.WriteLine(((CustModel)lst01.SelectedItem).Num);
            Debug.WriteLine(((CustModel)lst01.SelectedItem).Name);
            Debug.WriteLine(((CustModel)lst01.SelectedItem).Tel);
            Debug.WriteLine(((CustModel)lst01.SelectedItem).Addr);
            Debug.WriteLine(((CustModel)lst01.SelectedItem));

        }
    }
}