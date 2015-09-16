using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.Service.Interfaces
{
    public interface IAuthenticationService
    {
        bool Authenticate(string login, string password);
    }
}
