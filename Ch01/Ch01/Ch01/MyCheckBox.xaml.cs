using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch01
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyCheckBox : ContentView
	{
        private string text;
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                if (text == value) return;
                text = value;
                lblText.Text = text;
            }
        }
        private bool isChecked;
        public bool IsChecked {


            get
            {
                return isChecked;
            }


            set
            {
                if (isChecked == value) return;
                isChecked = value;
                lblMark.Text = isChecked ? "\u2611" : "\u2610";

                CheckedChanged.Invoke(this, isChecked);
            }
        }

        public event EventHandler<bool> CheckedChanged;

		public MyCheckBox ()
		{
			InitializeComponent ();
            IsChecked = false;
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            IsChecked ^= true;
            // !ischecked해도 되지만 위에가 더 빠름 얜 메모리에 두번 접근해야하니까
            //if (IsChecked)
            //{
            //    lblMark.Text = "\u2611";
            //}else
            //{
            //    lblMark.Text = "\u2610";
            //}

            
        }
    }
}