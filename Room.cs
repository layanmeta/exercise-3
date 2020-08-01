using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clients;


namespace Hotel
{
   abstract class Room
    {
        protected int m_Room_Number;
        protected float m_Price;
        protected Guest m_Guest;
        protected bool m_Is_Clean;
        protected string m_Features;

        public Room(int m_Room_Number, float m_Price)
        {
            this.m_Room_Number = m_Room_Number;
            this.m_Price = m_Price;
            SetPrice();
            SetFeatures();
        }

        internal void SetGuest(Guest g)
        {
            this.m_Guest = g;
        }


        protected  virtual  bool SetIsClean()
        {
            if (m_Is_Clean == true)
            {
                return true;

            }
            return false;
        } 

        protected virtual void SetPrice()
        {
            m_Price = 50;
            if(DateTime.Now.Month == 7 && DateTime.Now.Month == 9)
            {
                m_Price += 25;
            }

        }

        protected abstract void SetFeatures();
        


        public int GetRoomNumber()
        {
            return m_Room_Number;
        }

        public float GetPrice()
        {
            return m_Price;
        }

        public int GetGuest()
        {
            return m_Guest;
        }

        public bool IsClean()
        {
            return m_Is_Clean;
        }

        public string GetFeatures()
        {
            return m_Features;
        }

        public override string ToString()
        {
            return $"room number is : {m_Room_Number}, price is : {m_Price}, guest is : {m_Guest}. is the room clean? {m_Is_Clean}, its features are: {m_Features}";
        }
    }
}
