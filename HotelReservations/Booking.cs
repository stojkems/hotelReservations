using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservations
{
    public class Booking
    {
        public int Start { get; set; }
        public int End { get; set; }

        public bool Result { get; set; }
        public string Message { get; set; }
    }
}
