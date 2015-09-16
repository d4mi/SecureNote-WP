using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.Service.Interfaces
{
    public interface INavigationService
    {
        Task NavigateTo(string pageName);

        Task NavigateTo(string pageName, object bindingContext);

        Task GoBack();

        void RegisterPage(string pageName, Type type);
    }
}
