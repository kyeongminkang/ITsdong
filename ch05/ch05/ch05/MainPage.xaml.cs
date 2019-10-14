using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ch05
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            txtID.Focus();
        }

        private void TxtID_Completed(object sender, EventArgs e)
        {
            txtPWD.Focus();  
        }

        private void TxtPWD_Completed(object sender, EventArgs e)
        {
            btnLogin.Focus();
        }

        private void BtnLogin_Clicked(object sender, EventArgs e)
        {
            this.DisplayAlert("로그인", string.Format("아이디:{0}, 암호:{1}", txtID, txtPWD.Text), "확인");
        }
    }
}
