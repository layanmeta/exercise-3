using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients
{
        public class Guest
        {
            private int m_id;
            private string m_name;

        public Guest(int m_id, string m_name)
        {
            this.m_id = m_id;
            this.m_name = m_name;
        }

        public int Getid()
        {
            return m_id;

        }

        public string GetName()
        {
            return m_name;
        }

        public override string ToString()
        {
            return $"the id is : {m_id}, and the name is {m_name}";
        }
        }
    
}
