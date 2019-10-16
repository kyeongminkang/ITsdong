using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ch09
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();
            // 저장한 이미지 포함 리소스로 바꾸어줘야함

            img.Source = ImageSource.FromResource("ch09.Images.img01.jpg");
		}
	}
}