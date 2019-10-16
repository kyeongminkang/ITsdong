using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ch15_01
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
        public Page2()
        {
            //InitializeComponent ();
            this.Resources = new ResourceDictionary()
            {
                {
                    "buttonStyle", new Style(typeof(Button))
                    {
                        Setters =
                        {
                            new Setter
                            {
                                Property = View.HorizontalOptionsProperty,
                                Value = LayoutOptions.Center
                            },
                            new Setter
                            {
                                Property = View.VerticalOptionsProperty,
                                Value = LayoutOptions.CenterAndExpand
                            },
                            new Setter
                            {
                                Property = Button.FontSizeProperty,
                                Value = 16
                            },
                            new Setter
                            {
                                Property = Button.TextColorProperty,
                                Value = Color.FromRgb(0.0, 0.0, 1.0)
                            },
                            new Setter
                            {
                                Property = Button.BorderWidthProperty,
                                Value = 3
                            }
         
                //            <Setter Property="HorizontalOptions" Value="Center" />
                //<Setter Property="VerticalOptions" Value="CenterAndExpand" />
                //<Setter Property="FontSize" Value="Large" />
                //<Setter Property="TextColor" Value="{StaticResource buttonColor}" />
                //<Setter Property="BorderWidth" Value="3" />
                        }
                    }
                }
            };

            Button btn01 = new Button()
            {
                Text = "하나",
                Style = (Style)Resources["buttonStyle"]
            };

            Button btn02 = new Button()
            {
                Text = "둘",
                Style = (Style)Resources["buttonStyle"]
            };

            Button btn03 = new Button()
            {
                Text = "셋",
                Style = (Style)Resources["buttonStyle"]
            };

            this.Content = new StackLayout()
            {
                Children =
                {
                    btn01,
                    btn02,
                    btn03
                }
            };
		}
	}
}