using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clients;

namespace Hotel
{
   internal class RoomForTwo : Room
    {
        public RoomForTwo(int m_Room_Number, float m_Price) : base(m_Room_Number, m_Price)
        {
        }

        protected override void SetFeatures()
        {
            this.m_Features = "tv , mini bar";

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
