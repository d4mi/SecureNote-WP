using SecureNote.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.Service.Implementation
{
    public class FileBrowserDialog : IFileBrowserDialog
    {
        public string Open()
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            Nullable<bool> result = dialog.ShowDialog();

            return (result != false) ? dialog.FileName : String.Empty;
        }
    }
}
