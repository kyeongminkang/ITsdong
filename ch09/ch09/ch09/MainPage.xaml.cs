using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ch09
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Image_SizeChanged(object sender, EventArgs e)
        {
            lbl01.Text = string.Format("이미지 크기 : {0} x {1}", img01.Width, img01.Height);
        }
    }
}
