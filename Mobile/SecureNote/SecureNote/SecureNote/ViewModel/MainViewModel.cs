using GalaSoft.MvvmLight;
using SecureNote.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<TabItem> All { get; set; }

        #region Ctor   

        public MainViewModel()
        {
            All = new ObservableCollection<TabItem>()
            {
                new TabItem()
                {
                    Name = "Add note",
                    Text = "Page1 content"
                },

                new TabItem()
                {
                    Name = "Notes",
                    Text = "Page2 content"
                },

                new TabItem()
                {
                    Name = "Add document",
                    Text = "Page3 content"
                },

                new TabItem()
                {
                    Name = "Documents",
                    Text = "Page4 content"
                }
            };
        }

        #endregion
    }
}
