using SecureNote.Service.Interface;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SecureNote.Service.Implementation
{
    public class WebsiteScreenshot 
    {
        WebBrowser webBrowser = new WebBrowser();
        BitmapImage image = new BitmapImage();

        #region IWebsiteScreenshot
        public BitmapImage GetPage(string url)
        {
                     
            
            webBrowser.Width = 1800;
            webBrowser.Height = 1800;
            webBrowser.Navigate(new Uri("http://www.wp.pl"));

            webBrowser.Navigated += new System.Windows.Navigation.NavigatedEventHandler(OnNavigated);



            return image;
        }

        private void OnNavigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            
            RenderTargetBitmap bmp = new RenderTargetBitmap
                (1800, 1800, 120, 96, PixelFormats.Pbgra32);

            bmp.Render(webBrowser);



            var encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(bmp));
            using (var stream = File.Create("./image.png"))
                encoder.Save(stream);
        }

        #endregion
    }
}
