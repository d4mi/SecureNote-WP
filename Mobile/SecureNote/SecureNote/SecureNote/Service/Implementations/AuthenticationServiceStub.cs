using SecureNote.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.Service.Implementations
{
    public class AuthenticationServiceStub : IAuthenticationService
    {
        public bool Authenticate(string login, string password)
        {
            return true;
        }
    }
}
