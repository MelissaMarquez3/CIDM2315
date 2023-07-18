using System;
using System.Collections.Generic;

namespace FinalProject
{
    class Program
    {
        static List<Room> rooms = new List<Room>();

        static void Main(string[] args)
        {
            Console.WriteLine("-—CIDM2315 Final Project: Melissa Marquez- -Welcome to Buff Hotel—");
            Console.Write("—> Please input username: ");
            string username = Console.ReadLine();
            Console.Write("—> Please input password: ");
            string password = Console.ReadLine();

            int loginAttempts = 1;
            while (loginAttempts < 5)
            {
                if (username != "alice" || password != "alice123")
                {
                    Console.WriteLine("- " + (5 - loginAttempts) + " Wrong Username/Password -");
                    Console.Write("—> Please input username: ");
                    username = Console.ReadLine();
                    Console.Write("—> Please input password: ");
                    password = Console.ReadLine();
                    loginAttempts++;
                }
                else
                {
                    Console.WriteLine("- " + loginAttempts + " Login Successfully.");
                    break;
                }
            }

            if (loginAttempts == 5)
            {
                Console.WriteLine("Maximum login attempts reached. Please try again later.");
            }

            string menuOption;

            rooms.Add(new Room(101, 2));
            rooms.Add(new Room(102, 2));
            rooms.Add(new Room(103, 2));
            rooms.Add(new Room(104, 2));
            rooms.Add(new Room(105, 2));
            rooms.Add(new Room(106, 3));
            rooms.Add(new Room(107, 3));
            rooms.Add(new Room(108, 3));
            rooms.Add(new Room(109, 3));
            rooms.Add(new Room(110, 4));

            do
            {
                Console.WriteLine("** Hello User: " + username + " * * ****************");
                Console.WriteLine("—› Please select:");
                Console.WriteLine("1. Show Available Room");
                Console.WriteLine("2. Check-In");
                Console.WriteLine("3. Show Reserved Room");
                Console.WriteLine("4. Check-Out");
                Console.WriteLine("5. Log Out");
                Console.WriteLine("***********");

                menuOption = Console.ReadLine();

                Console.Clear();

                switch (menuOption)
                {
                    case "1":
                        ShowAvailableRooms();
                        break;
                    case "2":
                        CheckIn();
                        break;
                    case "3":
                        ShowReservedRooms();
                        break;
                    case "4":
                        CheckOut();
                        break;
                    case "5":
                        Console.WriteLine("Logging out...");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            } while (menuOption != "5");
        }

        static void ShowAvailableRooms()
        {
            Console.WriteLine("Available Rooms:");
            foreach (var room in rooms)
            {
                if (!room.IsReserved)
                {
                    Console.WriteLine($"Room number: {room.RoomNumber}; Capacity: {room.Capacity}");
                }
            }
            Console.WriteLine($"Number of Available Rooms: {GetNumberOfAvailableRooms()}");
        }

        static void ShowReservedRooms()
        {
            Console.WriteLine("Reserved Rooms:");
            foreach (var room in rooms)
            {
                if (room.IsReserved)
                {
                    Console.WriteLine($"Room number: {room.RoomNumber}; Capacity: {room.Capacity}");
                }
            }
        }

        static void CheckIn()
        {
            Console.WriteLine("Enter the room number to check-in:");
            int roomNumber = Convert.ToInt32(Console.ReadLine());

            var room = rooms.Find(r => r.RoomNumber == roomNumber);
            if (room != null)
            {
                if (!room.IsReserved)
                {
                    room.IsReserved = true;
                    Console.WriteLine("Check-in successful.");
                }
                else
                {
                    Console.WriteLine("Room is already reserved.");
                }
            }
            else
            {
                Console.WriteLine("Invalid room number.");
            }
        }

        static void CheckOut()
        {
            Console.WriteLine("Enter the room number to check-out:");
            int roomNumber = Convert.ToInt32(Console.ReadLine());

            var room = rooms.Find(r => r.RoomNumber == roomNumber);
            if (room != null)
            {
                if (room.IsReserved)
                {
                    room.IsReserved = false;
                    Console.WriteLine("Check-out successful.");
                }
                else
                {
                    Console.WriteLine("Room is not reserved.");
                }
            }
            else
            {
                Console.WriteLine("Invalid room number.");
            }
        }

        static int GetNumberOfAvailableRooms()
        {
            int count = 0;
            foreach (var room in rooms)
            {
                if (!room.IsReserved)
                {
                    count++;
                }
            }
            return count;
        }
    }

    public class Room
    {
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        public bool IsReserved { get; set; }

        public Room(int roomNumber, int capacity)
        {
            RoomNumber = roomNumber;
            Capacity = capacity;
            IsReserved = false;
        }
    }
}
