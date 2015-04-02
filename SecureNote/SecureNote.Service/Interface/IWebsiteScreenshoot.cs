using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SecureNote.Service.Interface
{
    public interface IWebsiteScreenshot
    {
        Image GetPage(string url);
    }
}
