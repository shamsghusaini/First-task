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

        AddNewRoom(rooms);
        RegisterNewGuest(guests);
    }

    static void AddNewRoom(List<Room> rooms)
    {
        Console.Write("Enter room number: ");
        int roomNumber = int.Parse(Console.ReadLine());

        if (roomNumber <= 0)
        {
            Console.WriteLine("Room number must be positive.");
            return;
        }

        if (rooms.Any(r => r.RoomNumber == roomNumber))
        {
            Console.WriteLine("This room number already exists.");
            return;
        }

        Console.Write("Enter room type (Single/Double/Suite): ");
        string roomType = Console.ReadLine();

        Console.Write("Enter price per night: ");
        double price = double.Parse(Console.ReadLine());

        if (price <= 0)
        {
            Console.WriteLine("Price must be positive.");
            return;
        }

        Room newRoom = new Room(roomNumber, roomType, price, true);

        rooms.Add(newRoom);

        Console.WriteLine("\nRoom added successfully!");
        Console.WriteLine($"Room Number: {roomNumber}");
        Console.WriteLine($"Room Type: {roomType}");
        Console.WriteLine($"Price Per Night: {price}");
        Console.WriteLine($"Available: Yes");
        Console.WriteLine($"Total Rooms: {rooms.Count}");
    }
    static void RegisterNewGuest(List<Guest> guests)
    {
        Console.Write("Enter guest name: ");
        string guestName = Console.ReadLine();

        Console.Write("Enter check-in date: ");
        string checkInDate = Console.ReadLine();

        Console.Write("Enter total nights: ");
        int totalNights = int.Parse(Console.ReadLine());

        if (totalNights <= 0)
        {
            Console.WriteLine("Number of nights must be positive.");
            return;
        }

        string guestId = "G" + (guests.Count + 1).ToString("000");

        Guest guest = new Guest(guestId, guestName, "Not Assigned", checkInDate, totalNights);

        guests.Add(guest);

        Console.WriteLine("\nGuest registered successfully!");
        Console.WriteLine($"Guest ID: {guest.GuestId}");
        Console.WriteLine($"Guest Name: {guest.GuestName}");
        Console.WriteLine($"Check-In Date: {guest.CheckInDate}");
        Console.WriteLine($"Total Nights: {guest.TotalNights}");
        Console.WriteLine($"Room Number: {guest.RoomNumber}");
    }
}