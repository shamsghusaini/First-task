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
                
                case 8:
                    UpdateRoomPrice(rooms);
                    break;
                
                case 9:
                    GuestLookupByName(guests);
                    break;
                
                case 10:
                    RoomTypeBreakdownReport(rooms);
                    break;
                
                case 11:
                    CheckOutGuest(rooms, guests);
                    break;
                
                case 12:
                    RemoveUnavailableRooms(rooms, guests);
                    break;
                
                case 13:
                    ExtendGuestStay(rooms, guests);
                    break;
                
                case 14:
                    HighestRevenueBooking(rooms, guests);
                    break;
                
                case 15:
                    GuestPaginationViewer(guests);
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
    static void UpdateRoomPrice(List<Room> rooms)
    {
        Console.Write("Enter Room Number: ");
        int roomNumber = int.Parse(Console.ReadLine());

        Room room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

        if (room == null)
        {
            Console.WriteLine("Room not found.");
            return;
        }

        double oldPrice = room.PricePerNight;

        Console.Write("Enter New Price: ");
        double newPrice = double.Parse(Console.ReadLine());

        if (newPrice <= 0)
        {
            Console.WriteLine("Price must be greater than 0.");
            return;
        }

        room.PricePerNight = newPrice;

        Console.WriteLine("\nRoom price updated successfully.");
        Console.WriteLine("Room Number: " + room.RoomNumber);
        Console.WriteLine("Old Price: " + oldPrice);
        Console.WriteLine("New Price: " + room.PricePerNight);
    }
    static void GuestLookupByName(List<Guest> guests)
    {
        Console.Write("Enter Guest Name or Part of Name: ");
        string search = Console.ReadLine();

        var matchingGuests = guests.Where(g =>
            g.GuestName.Contains(search, StringComparison.OrdinalIgnoreCase));

        if (!matchingGuests.Any())
        {
            Console.WriteLine("No guests matched that search.");
            return;
        }

        Console.WriteLine("\nMatching Guests: " + matchingGuests.Count());

        foreach (Guest guest in matchingGuests)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Guest ID: " + guest.GuestId);
            Console.WriteLine("Guest Name: " + guest.GuestName);
            Console.WriteLine("Room Number: " + guest.RoomNumber);
        }
    }static void RoomTypeBreakdownReport(List<Room> rooms)
    {
        Console.WriteLine("\n===== ROOM TYPE BREAKDOWN REPORT =====");

        string[] roomTypes = { "Single", "Double", "Suite" };

        foreach (string type in roomTypes)
        {
            int count = rooms.Count(r => r.RoomType.Equals(type, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("\nRoom Type: " + type);
            Console.WriteLine("Number of Rooms: " + count);

            if (count > 0)
            {
                double averagePrice = rooms
                    .Where(r => r.RoomType.Equals(type, StringComparison.OrdinalIgnoreCase))
                    .Average(r => r.PricePerNight);

                Console.WriteLine("Average Price: " + averagePrice.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Average Price: N/A");
            }
        }

        if (rooms.Any())
        {
            Console.WriteLine("\nOverall Average Price: " +
                              rooms.Average(r => r.PricePerNight).ToString("F2"));
        }
        else
        {
            Console.WriteLine("\nNo rooms available.");
        }
    }
    static void CheckOutGuest(List<Room> rooms, List<Guest> guests)
    {
        Console.Write("Enter Guest ID: ");
        string guestId = Console.ReadLine();

        Guest guest = guests.FirstOrDefault(g => g.GuestId == guestId);

        if (guest == null)
        {
            Console.WriteLine("Guest not found.");
            return;
        }

        if (guest.RoomNumber == "Not Assigned")
        {
            Console.WriteLine("This guest has no active booking.");
            return;
        }

        Room room = rooms.FirstOrDefault(r => r.RoomNumber.ToString() == guest.RoomNumber);

        if (room == null)
        {
            Console.WriteLine("Room not found.");
            return;
        }

        double totalCost = room.PricePerNight * guest.TotalNights;

        Console.WriteLine("\n===== FINAL BILL =====");
        Console.WriteLine("Guest Name: " + guest.GuestName);
        Console.WriteLine("Room Number: " + room.RoomNumber);
        Console.WriteLine("Room Type: " + room.RoomType);
        Console.WriteLine("Check-In Date: " + guest.CheckInDate);
        Console.WriteLine("Total Nights: " + guest.TotalNights);
        Console.WriteLine("Price Per Night: " + room.PricePerNight);
        Console.WriteLine("Total Cost: " + totalCost);

        Console.Write("\nConfirm Checkout (Y/N): ");
        string choice = Console.ReadLine();

        if (choice.ToUpper() == "Y")
        {
            room.IsAvailable = true;

            guests.Remove(guest);

            Console.WriteLine("\nGuest checked out successfully.");
            Console.WriteLine("Total Guests: " + guests.Count);
            Console.WriteLine("Total Rooms: " + rooms.Count);

            bool roomAvailable = rooms.Any(r =>
                r.RoomNumber == room.RoomNumber && r.IsAvailable);

            Console.WriteLine("Room Available: " + roomAvailable);
        }
        else
        {
            Console.WriteLine("Checkout cancelled.");
        }
    }
    static void RemoveUnavailableRooms(List<Room> rooms, List<Guest> guests)
    {
        var removableRooms = rooms
            .Where(r => !r.IsAvailable &&
                        !guests.Any(g => g.RoomNumber == r.RoomNumber.ToString()))
            .OrderBy(r => r.RoomNumber);

        if (!removableRooms.Any())
        {
            Console.WriteLine("All unavailable rooms are currently occupied.");
            Console.WriteLine("No rooms can be decommissioned.");
            return;
        }

        Console.WriteLine("\n===== REMOVABLE ROOMS =====");

        foreach (Room room in removableRooms)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Room Number: " + room.RoomNumber);
            Console.WriteLine("Room Type: " + room.RoomType);
            Console.WriteLine("Price: " + room.PricePerNight);
        }

        Console.WriteLine("\nTotal Removable Rooms: " + removableRooms.Count());

        Console.Write("Confirm removal (Y/N): ");
        string choice = Console.ReadLine();

        if (choice.ToUpper() == "Y")
        {
            rooms.RemoveAll(r =>
                !r.IsAvailable &&
                !guests.Any(g => g.RoomNumber == r.RoomNumber.ToString()));

            Console.WriteLine("\nRooms removed successfully.");
            Console.WriteLine("Updated Total Rooms: " + rooms.Count);

            Console.WriteLine("\nRemaining Rooms:");

            var remainingRooms = rooms
                .Select(r => new
                {
                    r.RoomNumber,
                    r.RoomType
                });

            foreach (var room in remainingRooms)
            {
                Console.WriteLine("Room " + room.RoomNumber + " - " + room.RoomType);
            }
        }
        else
        {
            Console.WriteLine("Operation cancelled.");
        }
    }
    static void ExtendGuestStay(List<Room> rooms, List<Guest> guests)
    {
        Console.Write("Enter Guest ID: ");
        string guestId = Console.ReadLine();

        Guest guest = guests.FirstOrDefault(g => g.GuestId == guestId);

        if (guest == null)
        {
            Console.WriteLine("Guest not found.");
            return;
        }

        if (guest.RoomNumber == "Not Assigned")
        {
            Console.WriteLine("This guest has no active booking.");
            return;
        }

        Console.Write("Enter Additional Nights: ");
        int extraNights = int.Parse(Console.ReadLine());

        if (extraNights <= 0)
        {
            Console.WriteLine("Additional nights must be greater than 0.");
            return;
        }

        guest.TotalNights += extraNights;

        Room room = rooms.FirstOrDefault(r =>
            r.RoomNumber.ToString() == guest.RoomNumber);

        if (room == null)
        {
            Console.WriteLine("Room not found.");
            return;
        }

        double totalCost = room.PricePerNight * guest.TotalNights;

        Console.WriteLine("\nStay extended successfully.");
        Console.WriteLine("Guest Name: " + guest.GuestName);
        Console.WriteLine("Room Number: " + guest.RoomNumber);
        Console.WriteLine("Updated Total Nights: " + guest.TotalNights);
        Console.WriteLine("Updated Total Cost: " + totalCost);
    }
    static void HighestRevenueBooking(List<Room> rooms, List<Guest> guests)
    {
        var highestBooking = guests
            .Where(g => g.RoomNumber != "Not Assigned")
            .Select(g =>
            {
                Room room = rooms.FirstOrDefault(r => r.RoomNumber.ToString() == g.RoomNumber);

                return new
                {
                    GuestName = g.GuestName,
                    RoomNumber = g.RoomNumber,
                    TotalCost = room != null ? room.PricePerNight * g.TotalNights : 0
                };
            })
            .OrderByDescending(g => g.TotalCost)
            .Take(1);

        if (!highestBooking.Any())
        {
            Console.WriteLine("No active bookings recorded.");
            return;
        }

        Console.WriteLine("\n===== HIGHEST REVENUE BOOKING =====");

        foreach (var booking in highestBooking)
        {
            Console.WriteLine("Guest Name: " + booking.GuestName);
            Console.WriteLine("Room Number: " + booking.RoomNumber);
            Console.WriteLine("Total Revenue: OMR " + booking.TotalCost.ToString("F2"));
        }
    }static void GuestPaginationViewer(List<Guest> guests)
    {
        const int pageSize = 3;

        if (!guests.Any())
        {
            Console.WriteLine("No guests found.");
            return;
        }

        Console.Write("Enter Page Number: ");
        int pageNumber = int.Parse(Console.ReadLine());

        int totalPages = (int)Math.Ceiling((double)guests.Count / pageSize);

        if (pageNumber < 1 || pageNumber > totalPages)
        {
            Console.WriteLine("That page does not exist.");
            return;
        }

        var pageGuests = guests
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize);

        Console.WriteLine($"\n===== PAGE {pageNumber} OF {totalPages} =====");

        foreach (Guest guest in pageGuests)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Guest ID: " + guest.GuestId);
            Console.WriteLine("Guest Name: " + guest.GuestName);
            Console.WriteLine("Room Number: " + guest.RoomNumber);
            Console.WriteLine("Check-In Date: " + guest.CheckInDate);
            Console.WriteLine("Total Nights: " + guest.TotalNights);
        }
    }
    
}