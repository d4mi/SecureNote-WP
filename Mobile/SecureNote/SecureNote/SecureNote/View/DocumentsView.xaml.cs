using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SecureNote.View
{
    public partial class DocumentsView : ContentPage
    {
        public DocumentsView()
        {
            InitializeComponent();
            this.BindingContext = SecureNote.Common.ViewModelLocator.DocumentsViewModel;
        }
    }
}
