using System;
using System.Collections.Generic;
using System.Text;

namespace Aula06Exercicio01
{
    class HostStudent
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public override string ToString()
        {
            //Quartos ocupados:
            //1: Marco Antonio, marco@gmail.com
            //5: Maria Green, maria@gmail.com
            //8: Alex Brown, alex@gmail.com

            return "Quartos ocupados:\n"
                + Room 
                +": "
                + Name
                +", " 
                +Email;
        }
    }
}
