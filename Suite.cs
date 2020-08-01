using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Suite : Room
    {
        public Suite(int m_Room_Number, float m_Price) : base(m_Room_Number, m_Price)
        {
        }

        protected override void SetFeatures()
        {
            m_Features = "jacuzzi";
        }
        protected override void SetPrice()
        {
            m_Price = 150;
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
