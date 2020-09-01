using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservations
{
    public class Hotel
    {
        const int _size = 1000;
        const int _maximumDays = 365;

        public List<Room> Rooms { get; set; }

        public Hotel(int size)
        {
            Rooms = new List<Room>(size);
        }

        public void Availability(int size, Booking booking)
        {
            // start day or end day shouldn't be negative
            if (booking.Start < 0 || booking.End < 0)
            {
                booking.Result = false;
                booking.Message = "start day or end day shouldn't be negative";

                return;
            }

            // start day shouldn't be bigger than end day
            if (booking.Start > booking.End)
            {
                booking.Result = false;
                booking.Message = "start day shouldn't be bigger than end day";

                return;
            }

            // start day or end day shouldn't be greater than maximum days of 365
            if (booking.Start > _maximumDays || booking.End > _maximumDays)
            {
                booking.Result = false;
                booking.Message = "start day or end day shouldn't be greater than maximum days of 365";

                return;
            }

            if (size < 1 || size > _size)
            {
                booking.Result = false;
                booking.Message = $"size must be a number between 1 and {_size}";

                return;
            }

            foreach (var room in Rooms)
            {
                if (room.Days.Count > 0)
                {
                    if (room.Days.Contains(booking.Start) || room.Days.Contains(booking.End))
                    {
                        continue;
                    }
                    else
                    {
                        var days = room.Days.FindAll(day =>
                            (booking.Start < day && booking.End < day) ||
                            (booking.Start > day && booking.End > day));

                        if (days.Count > 0)
                        {
                            room.Days.Add(booking.Start);

                            var numberOfDays = booking.Start + 1;
                            while (numberOfDays <= booking.End)
                            {
                                room.Days.Add(numberOfDays);

                                numberOfDays++;
                            }

                            booking.Result = true;
                            break;
                        }
                    }
                }
                else
                {
                    room.Days.Add(booking.Start);

                    var numberOfDays = booking.Start + 1;
                    while (numberOfDays <= booking.End)
                    {
                        room.Days.Add(numberOfDays);

                        numberOfDays++;
                    }

                    booking.Result = true;
                    break;
                }
            }
        }
    }
}
