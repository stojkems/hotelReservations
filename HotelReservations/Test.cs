using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservations
{
    public class Test
    {
        public void Run(Hotel h, int size, List<Booking> bookings)
        {
            // test case 1a
            size = 1;
            h = new Hotel(size);
            bookings = new List<Booking>();

            Booking b1a = new Booking { Start = -4, End = 2 };
            bookings.Add(b1a);

            Console.WriteLine("\n- Test case 1a");
            Console.WriteLine("Size=" + size);
            Program.CheckAvailability(h, size, bookings);


            // test case 1b
            size = 1;
            h = new Hotel(size);
            bookings = new List<Booking>();

            Booking b1b = new Booking { Start = 200, End = 400 };
            bookings.Add(b1b);

            Console.WriteLine("\n- Test case 1b");
            Console.WriteLine("Size=" + size);
            Program.CheckAvailability(h, size, bookings);


            // test case 2
            size = 3;
            h = new Hotel(size);
            bookings = new List<Booking>();

            Booking b1 = new Booking { Start = 0, End = 5 };
            Booking b2 = new Booking { Start = 7, End = 13 };
            Booking b3 = new Booking { Start = 3, End = 9 };
            Booking b4 = new Booking { Start = 5, End = 7 };
            Booking b5 = new Booking { Start = 6, End = 6 };
            Booking b6 = new Booking { Start = 0, End = 4 };

            bookings.Add(b1);
            bookings.Add(b2);
            bookings.Add(b3);
            bookings.Add(b4);
            bookings.Add(b5);
            bookings.Add(b6);

            Console.WriteLine("\n- Test case 2");
            Console.WriteLine("Size=" + size);
            Program.CheckAvailability(h, size, bookings);

            // test case 3
            size = 3;
            h = new Hotel(size);
            bookings = new List<Booking>();

            b1 = new Booking { Start = 1, End = 3 };
            b2 = new Booking { Start = 2, End = 5 };
            b3 = new Booking { Start = 1, End = 9 };
            b4 = new Booking { Start = 0, End = 15 };

            bookings.Add(b1);
            bookings.Add(b2);
            bookings.Add(b3);
            bookings.Add(b4);

            Console.WriteLine("\n- Test case 3");
            Console.WriteLine("Size=" + size);
            Program.CheckAvailability(h, size, bookings);

            // test case 4
            size = 3;
            h = new Hotel(size);
            bookings = new List<Booking>();

            b1 = new Booking { Start = 1, End = 3 };
            b2 = new Booking { Start = 0, End = 15 };
            b3 = new Booking { Start = 1, End = 9 };
            b4 = new Booking { Start = 2, End = 5 };
            b5 = new Booking { Start = 4, End = 9 };

            bookings.Add(b1);
            bookings.Add(b2);
            bookings.Add(b3);
            bookings.Add(b4);
            bookings.Add(b5);

            Console.WriteLine("\n- Test case 4");
            Console.WriteLine("Size=" + size);
            Program.CheckAvailability(h, size, bookings);

            // test case 5
            size = 2;
            h = new Hotel(size);
            bookings = new List<Booking>();

            b1 = new Booking { Start = 1, End = 3 };
            b2 = new Booking { Start = 0, End = 4 };
            b3 = new Booking { Start = 2, End = 3 };
            b4 = new Booking { Start = 5, End = 5 };
            b5 = new Booking { Start = 4, End = 10 };
            b6 = new Booking { Start = 10, End = 10 };
            Booking b7 = new Booking { Start = 6, End = 7 };
            Booking b8 = new Booking { Start = 8, End = 10 };
            Booking b9 = new Booking { Start = 8, End = 9 };

            bookings.Add(b1);
            bookings.Add(b2);
            bookings.Add(b3);
            bookings.Add(b4);
            bookings.Add(b5);
            bookings.Add(b6);
            bookings.Add(b7);
            bookings.Add(b8);
            bookings.Add(b9);

            Console.WriteLine("\n- Test case 5");
            Console.WriteLine("Size=" + size);
            Program.CheckAvailability(h, size, bookings);
        }
    }
}
