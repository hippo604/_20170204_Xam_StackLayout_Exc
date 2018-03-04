using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Images2
{
    class EmbeddedImage2 : IMarkupExtension
    {
        public string FileSource { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (String.IsNullOrWhiteSpace(FileSource))
                return null;
            return ImageSource.FromFile(FileSource);

        }
    }
}
