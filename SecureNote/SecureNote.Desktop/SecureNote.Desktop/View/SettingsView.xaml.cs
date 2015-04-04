using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SecureNote.Desktop.View
{
    /// <summary>
    /// Interaction logic for SettingsView.xaml
    /// </summary>
    public partial class SettingsView : UserControl
    {
        public SettingsView()
        {
            InitializeComponent();
            wb.Navigate(new Uri("http://www.google.pl"));

            System.Threading.Thread.Sleep(1000);

            RenderTargetBitmap bmp = new RenderTargetBitmap(1024, 1024, 100, 100, PixelFormats.Default);

            bmp.Render(wb);

            Image image = new Image();
            image.Source = bmp;

            im = image;
        }
    }
}
