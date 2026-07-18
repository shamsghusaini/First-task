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
            Console.WriteLine("6. Search & Filter Rooms");
            Console.WriteLine("7. Guest & Booking Statistics");
            Console.WriteLine("8. Update Room Price");
            Console.WriteLine("9. Guest Lookup by Name");
            Console.WriteLine("10. Room Type Breakdown Report");
            Console.WriteLine("11. Check Out a Guest");
            Console.WriteLine("12. Remove Unavailable Rooms");
            Console.WriteLine("13. Extend Guest Stay");
            Console.WriteLine("14. Highest Revenue Booking");
            Console.WriteLine("15. Guest Pagination Viewer");
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
                
                case 3:
                    BookRoom(rooms, guests);
                    break;
                
                case 4:
                    ViewAllRooms(rooms);
                    break;
                
                case 5:
                    ViewAllGuests(guests);
                    break;
                
                case 6:
                    SearchFilterRooms(rooms);
                    break;
                
                case 7:
                    GuestBookingStatistics(rooms, guests);
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
    static void BookRoom(List<Room> rooms, List<Guest> guests)
    {
        Console.Write("\nEnter Guest ID: ");
        string guestId = Console.ReadLine();

        Guest guest = guests.FirstOrDefault(g => g.GuestId == guestId);

        if (guest == null)
        {
            Console.WriteLine("Guest not found.");
            return;
        }

        Console.Write("Enter Room Number: ");
        int roomNumber = int.Parse(Console.ReadLine());

        Room room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

        if (room == null)
        {
            Console.WriteLine("Room not found.");
            return;
        }

        if (!room.IsAvailable)
        {
            Console.WriteLine("Room is already booked.");
            return;
        }

        guest.RoomNumber = room.RoomNumber.ToString();
        room.IsAvailable = false;

        double totalCost = room.PricePerNight * guest.TotalNights;

        Console.WriteLine("\n===== Booking Successful =====");
        Console.WriteLine("Guest ID: " + guest.GuestId);
        Console.WriteLine("Guest Name: " + guest.GuestName);
        Console.WriteLine("Room Number: " + room.RoomNumber);
        Console.WriteLine("Room Type: " + room.RoomType);
        Console.WriteLine("Total Nights: " + guest.TotalNights);
        Console.WriteLine("Total Cost: " + totalCost);
    }
    static void ViewAllRooms(List<Room> rooms)
    {
        if (rooms.Count == 0)
        {
            Console.WriteLine("No rooms have been added yet.");
            return;
        }

        Console.WriteLine("\n===== ALL ROOMS =====");
        Console.WriteLine("Total Rooms: " + rooms.Count);

        foreach (Room room in rooms.OrderBy(r => r.RoomNumber))
        {
            string status;

            if (room.IsAvailable)
            {
                status = "Available";
            }
            else
            {
                status = "Booked";
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("Room Number: " + room.RoomNumber);
            Console.WriteLine("Room Type: " + room.RoomType);
            Console.WriteLine("Price Per Night: " + room.PricePerNight);
            Console.WriteLine("Status: " + status);
        }
    }
    static void ViewAllGuests(List<Guest> guests)
    {
        if (guests.Count == 0)
        {
            Console.WriteLine("No guests have been registered yet.");
            return;
        }

        Console.WriteLine("\n===== ALL GUESTS =====");
        Console.WriteLine("Total Guests: " + guests.Count);

        foreach (Guest guest in guests.OrderBy(g => g.GuestName))
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Guest ID: " + guest.GuestId);
            Console.WriteLine("Guest Name: " + guest.GuestName);
            Console.WriteLine("Room Number: " + guest.RoomNumber);
            Console.WriteLine("Check-In Date: " + guest.CheckInDate);
            Console.WriteLine("Total Nights: " + guest.TotalNights);
        }
    }
    static void SearchFilterRooms(List<Room> rooms)
    {
        while (true)
        {
            Console.WriteLine("\n===== SEARCH & FILTER ROOMS =====");
            Console.WriteLine("1. Show Available Rooms");
            Console.WriteLine("2. Filter by Room Type");
            Console.WriteLine("3. Filter by Maximum Price");
            Console.WriteLine("4. Room Price Statistics");
            Console.WriteLine("0. Back");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ShowAvailableRooms(rooms);
                    break;

                case 2:
                    FilterByRoomType(rooms);
                    break;

                case 3:
                    FilterByPrice(rooms);
                    break;

                case 4:
                    RoomStatistics(rooms);
                    break;

                case 0:
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
    static void ShowAvailableRooms(List<Room> rooms)
    {
        var availableRooms = rooms
            .Where(r => r.IsAvailable)
            .OrderBy(r => r.PricePerNight);

        if (!availableRooms.Any())
        {
            Console.WriteLine("No available rooms.");
            return;
        }

        Console.WriteLine("\n===== AVAILABLE ROOMS =====");

        foreach (Room room in availableRooms)
        {
            Console.WriteLine("Room Number: " + room.RoomNumber);
            Console.WriteLine("Room Type: " + room.RoomType);
            Console.WriteLine("Price: " + room.PricePerNight);
            Console.WriteLine("-----------------------");
        }
    }
    static void FilterByRoomType(List<Room> rooms)
    {
        Console.Write("Enter Room Type (Single/Double/Suite): ");
        string roomType = Console.ReadLine();

        var filteredRooms = rooms
            .Where(r => r.RoomType.Equals(roomType, StringComparison.OrdinalIgnoreCase));

        if (!filteredRooms.Any())
        {
            Console.WriteLine("No rooms found for the selected criteria.");
            return;
        }

        Console.WriteLine("\n===== MATCHING ROOMS =====");

        foreach (Room room in filteredRooms)
        {
            Console.WriteLine("Room Number: " + room.RoomNumber);
            Console.WriteLine("Room Type: " + room.RoomType);
            Console.WriteLine("Price: " + room.PricePerNight);
            Console.WriteLine("------------------------");
        }
    }
    static void FilterByPrice(List<Room> rooms)
    {
        Console.Write("Enter Maximum Price: ");
        double maxPrice = double.Parse(Console.ReadLine());

        var filteredRooms = rooms
            .Where(r => r.IsAvailable && r.PricePerNight <= maxPrice)
            .OrderBy(r => r.PricePerNight);

        if (!filteredRooms.Any())
        {
            Console.WriteLine("No rooms found for the selected criteria.");
            return;
        }

        Console.WriteLine("\n===== MATCHING ROOMS =====");

        foreach (Room room in filteredRooms)
        {
            Console.WriteLine("Room Number: " + room.RoomNumber);
            Console.WriteLine("Room Type: " + room.RoomType);
            Console.WriteLine("Price: " + room.PricePerNight);
            Console.WriteLine("------------------------");
        }
    }
    static void RoomStatistics(List<Room> rooms)
    {
        if (!rooms.Any())
        {
            Console.WriteLine("No rooms have been added yet.");
            return;
        }

        Console.WriteLine("\n===== ROOM STATISTICS =====");

        Console.WriteLine("Total Rooms: " + rooms.Count());

        Console.WriteLine("Available Rooms: " +
                          rooms.Count(r => r.IsAvailable));

        Console.WriteLine("Average Price: " +
                          rooms.Average(r => r.PricePerNight).ToString("F2"));

        Console.WriteLine("Cheapest Price: " +
                          rooms.Min(r => r.PricePerNight).ToString("F2"));

        Console.WriteLine("Most Expensive Price: " +
                          rooms.Max(r => r.PricePerNight).ToString("F2"));
    }
    static void GuestBookingStatistics(List<Room> rooms, List<Guest> guests)
    {
        Console.WriteLine("\n===== GUEST & BOOKING STATISTICS =====");

        Console.WriteLine("Total Registered Guests: " + guests.Count());

        Console.WriteLine("Guests With Booking: " +
                          guests.Count(g => g.RoomNumber != "Not Assigned"));

        Console.WriteLine("Total Rooms: " + rooms.Count());

        Console.WriteLine("Booked Rooms: " +
                          rooms.Count(r => !r.IsAvailable));

        if (!guests.Any(g => g.RoomNumber != "Not Assigned"))
        {
            Console.WriteLine("\nNo active bookings recorded.");
            return;
        }

        Console.WriteLine("Average Nights: " +
                          guests
                              .Where(g => g.RoomNumber != "Not Assigned")
                              .Average(g => g.TotalNights)
                              .ToString("F2"));
    }
}