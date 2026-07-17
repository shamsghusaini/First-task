using System;
using System.Collections.Generic;
using System.Linq;

class Room
{
    public int RoomNumber { get; set; }
    public string RoomType { get; set; }
    public double PricePerNight { get; set; }
    public bool IsAvailable { get; set; }

    public Room(int roomNumber, string roomType, double pricePerNight, bool isAvailable)
    {
        RoomNumber = roomNumber;
        RoomType = roomType;
        PricePerNight = pricePerNight;
        IsAvailable = isAvailable;
    }
}

class Guest
{
    public string GuestId { get; set; }
    public string GuestName { get; set; }
    public string RoomNumber { get; set; }
    public string CheckInDate { get; set; }
    public int TotalNights { get; set; }

    public Guest(string guestId, string guestName, string roomNumber, string checkInDate, int totalNights)
    {
        GuestId = guestId;
        GuestName = guestName;
        RoomNumber = roomNumber;
        CheckInDate = checkInDate;
        TotalNights = totalNights;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Room> rooms = new List<Room>();
        List<Guest> guests = new List<Guest>();

        while (true)
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine(" HOTEL MANAGEMENT SYSTEM");
            Console.WriteLine("==============================");
            Console.WriteLine("1. Add New Room");
            Console.WriteLine("2. Register New Guest");
            Console.WriteLine("3. Book a Room");
            Console.WriteLine("4. View All Rooms");
            Console.WriteLine("5. View All Guests");
            Console.WriteLine("0. Exit");

            Console.Write("\nEnter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddNewRoom(rooms);
                    break;

                case 2:
                    RegisterNewGuest(guests);
                    break;

                case 0:
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
        static void AddNewRoom(List<Room> rooms)
        {
            Console.Write("\nEnter Room Number: ");
            int roomNumber = int.Parse(Console.ReadLine());

            if (rooms.Any(r => r.RoomNumber == roomNumber))
            {
                Console.WriteLine("Room already exists.");
                return;
            }

            Console.Write("Enter Room Type: ");
            string roomType = Console.ReadLine();

            Console.Write("Enter Price Per Night: ");
            double price = double.Parse(Console.ReadLine());

            Room room = new Room(roomNumber, roomType, price, true);

            rooms.Add(room);

            Console.WriteLine("Room added successfully.");
        }

        static void RegisterNewGuest(List<Guest> guests)
        {
            string guestId = "G" + (guests.Count + 1).ToString("000");

            Console.Write("\nEnter Guest Name: ");
            string guestName = Console.ReadLine();

            Console.Write("Enter Check-In Date: ");
            string checkInDate = Console.ReadLine();

            Console.Write("Enter Total Nights: ");
            int totalNights = int.Parse(Console.ReadLine());

            Guest guest = new Guest(
                guestId,
                guestName,
                "Not Assigned",
                checkInDate,
                totalNights
            );

            guests.Add(guest);

            Console.WriteLine("\nGuest registered successfully.");
            Console.WriteLine("Guest ID: " + guest.GuestId);
        }
    }
    }