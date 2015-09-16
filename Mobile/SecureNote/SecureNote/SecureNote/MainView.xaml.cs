using SecureNote.View;
using SecureNote.ViewModel;
using System;
using Xamarin.Forms;

namespace SecureNote
{
    public partial class MainView 
    {
        public MainView()
        {
            InitializeComponent();
            this.BindingContext = new MainViewModel();
            this.Children.Add(new LoginView());
            this.Children.Add(new AddUserView());
            this.Children.Add(new NotePreviewView());
            this.Children.Add(new NotesView());
            this.Children.Add(new NotepadView());
            this.Children.Add(new DocumentsView());
            this.Children.Add(new DocumentPreviewView());

        }
    }
}
