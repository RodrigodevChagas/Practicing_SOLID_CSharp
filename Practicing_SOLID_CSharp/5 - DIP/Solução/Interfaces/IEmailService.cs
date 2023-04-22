using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing_SOLID_CSharp._5___DIP.Solução.Interfaces
{
    public interface IEmailService
    {
        void SendEmail(string Email);
        bool IsEmailValid(string Email);
    }
}
