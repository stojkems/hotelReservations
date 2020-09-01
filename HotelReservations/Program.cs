using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;

namespace HotelReservations
{
    public class Program
    {
        public static void CheckAvailability(Hotel h, int size, List<Booking> bookings)
        {
            int maxEndDate = bookings.Max(x => x.End);
            int roomNumber = 0;
            while (roomNumber < size)
            {
                roomNumber++;
                h.Rooms.Add(new Room(maxEndDate));
            }

            int number = 0;
            foreach (var booking in bookings)
            {
                number++;

                h.Availability(size, booking);

                Console.WriteLine($"Booking {number} -> StartDate={booking.Start}, EndDate={booking.End} - Result: {booking.Result}");
                Console.WriteLine(booking.Message);
            }
        }

        public static void SetBooking(int bookingNumber, List<Booking> bookings)
        {
            Console.WriteLine($"Booking {bookingNumber}");
            Console.WriteLine("Set booking start date (must be a number 1-365): ");
            int startDate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Set booking end date (must be a number 1-365): ");
            int endDate = Convert.ToInt32(Console.ReadLine());

            Booking b = new Booking { Start = startDate, End = endDate };
            bookings.Add(b);
        }

        static void Main(string[] args)
        {
            int size = 1;
            Hotel h = new Hotel(size);
            List<Booking> bookings = new List<Booking>();

            Console.WriteLine("RUNNING TESTS...");
            
            Test t = new Test();
            t.Run(h, size, bookings);

            Console.WriteLine("\nTESTS FINISHED.");

            Console.WriteLine("\nSet your size of hotel (must be a number):");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Size=" + size);
            
            h = new Hotel(size);
            bookings = new List<Booking>();

            int bookingNumber = 0;
            bool isBooking = true;
            while (isBooking)
            {
                Console.WriteLine("\nDo you want to add a booking?");
                Console.WriteLine("y - YES, n - NO");
                string answer = Console.ReadLine();

                if (answer == "y")
                {
                    isBooking = true;
                    bookingNumber++;
                    SetBooking(bookingNumber, bookings);
                }
                else
                {
                    isBooking = false;
                }
            }

            if (bookings.Count > 0)
            {
                Console.WriteLine("\nBOOKINGS AVAILABILITY STARTED...");
                CheckAvailability(h, size, bookings);
            }

            Console.WriteLine("\nBOOKINGS FINISHED.");
        }

    }
}
