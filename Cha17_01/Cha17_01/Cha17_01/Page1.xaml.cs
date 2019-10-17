using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cha17_01
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();

            // 처음 화면 나올 때 디폴트 지정해주기
            //pic01.SelectedIndex = 6;
		}

        private void Pic01_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strKeyboard = (string)pic01.SelectedItem;
            Debug.WriteLine("====>선택 키보드" + strKeyboard);

            PropertyInfo pi = typeof(Keyboard).GetRuntimeProperty(strKeyboard);
            txt01.Keyboard = (Keyboard)pi.GetValue(null);
        }
    }
}