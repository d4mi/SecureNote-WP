using SecureNote.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SecureNote.Service.Implementation
{
    public class WebsiteScreenshot : IWebsiteScreenshot
    {
        #region IWebsiteScreenshot
        public Image GetPage(string url)
        {
            Image image = new Image();

            WebBrowser webBrowser = new WebBrowser();
            webBrowser.Navigate(new Uri("http://www.wp.pl"));

            RenderTargetBitmap bmp = new RenderTargetBitmap
                (1024, 768, 300, 300, PixelFormats.Pbgra32);

            bmp.Render(webBrowser);
            image.Source = bmp;

            return image;
        }

        #endregion
    }
}
