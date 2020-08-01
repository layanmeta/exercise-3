using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clients;

namespace Hotel
{
  public static class Reception
    {
        private const int m_numberOfRooms = 20;

        private static int m_numberOfGuests;
        private static Room[] m_rooms = new Room[m_numberOfRooms];
        private static RoomService m_roomService = new RoomService();

        public static void CheckIn(Guest G)
        {
            
            for (int i = 0; i < m_numberOfRooms; i++)
            {
                if (m_rooms[i].GetGuest() == null)
                {
                    m_rooms[i].SetGuest(G);
                    m_numberOfGuests++;
                    break;
                }
                
            }
            Console.WriteLine("Sorry we have no more rooms");

        }

        public static void CheckOut(Room R)
        {
            R.SetGuest(null);
            m_numberOfGuests--;

        }

        public static bool isRoomFree(Room f)
        {
            if (f.GetGuest() == null)
            {
                return true;

            }
            return false;
        }

       



    }
}
