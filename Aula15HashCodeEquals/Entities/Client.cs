using System;
using System.Collections.Generic;
using System.Text;

namespace Aula15HashCodeEquals.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj) //Overrride Method to Equals() check
        {
            if (!(obj is Client))
            {
                return false;
            }
            Client test = obj as Client; // DownCasting necessary to convert generic object in Client Class or any other
            return Email.Equals(test.Email);
        }
        public override int GetHashCode() //Overrride Method to GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
