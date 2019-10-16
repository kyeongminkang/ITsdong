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
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
            Label lbl01 = new Label()
            {
                Text = "안녕하세요. 자마린입니다.",
                FontSize = 22,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            Slider sld01 = new Slider()
            {
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            //대상.BindingContext = 소스 뷰
            lbl01.BindingContext = sld01;

            //대상.SetBinding(대상 프로퍼티, 소스 프로퍼티);
            lbl01.SetBinding(Label.OpacityProperty, "Value");

            Content = new StackLayout
            {
                Children =
                {
                    lbl01,
                    sld01
                }
            };
		}
	}
}