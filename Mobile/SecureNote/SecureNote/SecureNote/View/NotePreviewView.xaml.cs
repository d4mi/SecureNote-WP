using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SecureNote.View
{
    public partial class NotePreviewView : ContentPage
    {
        public NotePreviewView()
        {
            InitializeComponent();
            this.BindingContext = new SecureNote.ViewModel.NotePreviewViewModel(
                new SecureNote.Model.Note
                {
                    Title = "Sample note!",
                    Text = "Xamarin.Android for Visual Studio requires Android NDK, which is used to embed .NET assemblies into native libraries. While the NDK is generally not used for developing an Android application, we suggest you to install it. Please set Android NDK path on Tools->Options->Xamarin->Android Settings menu"

                });
        }
    }
}
