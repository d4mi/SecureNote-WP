using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SecureNote.View
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
            this.BindingContext = SecureNote.Common.ViewModelLocator.LoginViewModel;
        }
    }
}
