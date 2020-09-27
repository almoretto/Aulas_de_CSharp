using System;
using System.Collections.Generic;
using System.Text;

namespace Aula15HashCodeEquals.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Client))
            {
                return false;
            }
            Client test = obj as Client; // DownCasting
            return Email.Equals(test.Email);
        }
        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
