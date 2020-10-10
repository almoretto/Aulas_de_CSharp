using System;
using System.Collections.Generic;
using System.Text;

namespace Aula15ExercicioResolvidoSet.Entities
{
    class LogRecords
    {
        public string UserName { get; set; }
        public DateTime Instant { get; set; }

        public LogRecords(string userName, DateTime instant)
        {
            UserName = userName;
            Instant = instant;
        }

        public override int GetHashCode() 
        {
            return UserName.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is LogRecords))
            {
                return false;
            }
            LogRecords toBeTested = obj as LogRecords;
            return UserName.Equals(toBeTested.UserName);
        }
    }
}
