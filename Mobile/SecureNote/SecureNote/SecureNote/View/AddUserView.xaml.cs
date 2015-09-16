using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SecureNote.View
{
    public partial class AddUserView : ContentPage
    {
        public AddUserView()
        {
            InitializeComponent();
            this.BindingContext = Microsoft.Practices.ServiceLocation.ServiceLocator.Current
                .GetInstance<SecureNote.ViewModel.AddUserViewModel>();
        }
    }
}
