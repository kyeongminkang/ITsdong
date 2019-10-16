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
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
            Label lbl01 = new Label()
            {
                Text = "안녕하세요 자마린입니다.",
                FontSize = 22,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };

            Slider sld01 = new Slider()
            {
                VerticalOptions = LayoutOptions.Center
            };

            Binding binding = new Binding()
            {
                Source = sld01,
                Path = "Value"
            };

            lbl01.SetBinding(Label.OpacityProperty, binding);

            this.Content = new StackLayout()
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