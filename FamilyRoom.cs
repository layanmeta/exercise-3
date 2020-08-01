using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clients;

namespace Hotel
{
    internal class FamilyRoom : Room
    {
        public FamilyRoom(int m_Room_Number, float m_Price) : base(m_Room_Number, m_Price)
        {
        }

        protected override void SetFeatures()
        {
            m_Features = "tv, PlayStation";
        }
        protected override void  SetPrice()
        {
            m_Price = 100;
            if (DateTime.Now.Month == 7 && DateTime.Now.Month == 9)
            {
                m_Price += 25;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
