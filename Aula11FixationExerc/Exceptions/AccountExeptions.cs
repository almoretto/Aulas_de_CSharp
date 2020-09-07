using System;
using System.Collections.Generic;
using System.Text;

namespace Aula11FixationExerc.Exceptions
{
    class AccountExeptions : ApplicationException
    {
        public AccountExeptions(string message) : base(message) { }
    }
}
