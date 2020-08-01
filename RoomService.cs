using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
   internal class RoomService
    {
        internal void CleanRoomForTwo(RoomForTwo two)
        {
            Console.WriteLine($"Cleaning the room, also cleaning the {two.GetFeatures()}");
        }
        internal void CleanFamilyRoom(FamilyRoom F)
        {
            Console.WriteLine($"Cleaning the room, also cleaning the {F.GetFeatures()}");
        }
        internal void CleanSuite(Suite S)
        {
            Console.WriteLine($"Cleaning the room, also cleaning the {S.GetFeatures()}");
        }
    }
}
