using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ch09
{

    [ContentProperty("Source")]
    class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if(Source == null)
            {
                return null;
            }

            return ImageSource.FromResource(Source);
        }
    }
}
