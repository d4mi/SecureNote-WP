using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SecureNote.Desktop.Utils
{
    public class ViewEntry
    {
        public string Name { get; set; }
        public ViewModelBase ViewModelBase { get; set; }
        public ImageSource Icon { get; set; }

        public ViewEntry(string name, string path, ViewModelBase viewModelBase)
        {
            Name = name;
            Icon = GetImage(path);
            ViewModelBase = viewModelBase;
        }
        private ImageSource GetImage(string path)
        {
            return new BitmapImage(
                    new Uri(path, UriKind.Relative)
                );
        }
    }
}
