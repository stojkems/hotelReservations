using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservations
{
    public class Room
    {
        public List<int> Days { get; set; }

        public Room(int maxDays)
        {
            Days = new List<int>(maxDays);
        }
    }
}
