using SecureNote.Service.Interface;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            webBrowser.Width = 180;
            webBrowser.Height = 180;
            webBrowser.Navigate(new Uri("http://www.wp.pl"));

            RenderTargetBitmap bmp = new RenderTargetBitmap
                (180, 180, 120, 96, PixelFormats.Pbgra32);        

            bmp.Render(webBrowser);
            image.Source = bmp;

            return image;
        }

        #endregion
    }
}
