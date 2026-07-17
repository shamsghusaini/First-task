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

class Program
{
    static void Main(string[] args)
    {
        List<Room> rooms = new List<Room>();

        AddNewRoom(rooms);
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
}