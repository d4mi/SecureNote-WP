using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SecureNote.Model.Model
{
    public class Page
    {

        public string Name { get; set; }
        public string Password { get; set; }
        public string Url { get; set; }
        public Image Thumb { get; set; }
    }
}
