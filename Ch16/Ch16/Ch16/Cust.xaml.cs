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
	public partial class Cust : ContentView
	{
		public Cust ()
		{
			InitializeComponent ();

            ResetLabel();
		}

        // 생성자 생성
        public Cust(string name, string corp, string tel, string hp) : this()
        {
            Name = name;
            Corp = corp;
            Tel = tel;
            Hphone = hp;
        }

        private void ResetLabel()
        {
            lblName.Text = "";
            lblCorp.Text = "";
            lbltel.Text = "";
            lblhphone.Text = "";
        }




        // 프로퍼티로 세팅

        public string Name
        {
            get
            {
                return lblName.Text;
            }
            set
            {
                lblName.Text = value;
            }
        }

        public string Corp
        {
            get
            {
                return lblCorp.Text;
            }
            set
            {
                lblCorp.Text = value;
            }
        }

        public string Tel
        {
            get
            {
                return lbltel.Text;
            }
            set
            {
                lbltel.Text = value;
            }
        }

        public string Hphone
        {
            get
            {
                return lblhphone.Text;
            }
            set
            {
                lblhphone.Text = value;
            }
        }

    }
}