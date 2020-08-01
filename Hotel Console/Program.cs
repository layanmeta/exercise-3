using Clients;
using Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Guest guest = new Guest(12341234, "ron");
            Reception.CheckIn(guest);
        }
    }
}
