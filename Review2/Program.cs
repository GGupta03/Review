using System;

public class Booking
{

    private readonly string bookingRef;
    public string Bean { get; set; }
    private readonly string hotelName;
    private readonly string checkInId;
    private string guestFeedback;

    public Booking(string bookingRef, string hotelName, string checkInId)
    {
        this.bookingRef = bookingRef;
        this.hotelName = hotelName;
        this.checkInId = checkInId;
    }

    public string GetBookingRef() => bookingRef;
    public string GetHotelName() => hotelName;
    public string GetCheckInId() => checkInId;

    public void SetGuestFeedback(string feedback)
    {
        guestFeedback = feedback;
    }

    public void addGuest(string guest)
    {
        Console.WriteLine("Welcome {0} to Hotel", guest);
    }

    public virtual void calculateBill(double nights)
    {
        Console.WriteLine("Total Bill is {0} for the Booking", nights);
    }

    public class StandardRoom : Booking
    {
        public StandardRoom(string bookingRef, string hotelName, string checkInId) : base(bookingRef, hotelName, checkInId) { }

        public override void calculateBill(double nights)
        {
            double total = nights * 100;
            Console.WriteLine("Standard Room Bill: {0}", total);
        }
    }

    public class DeluxeRoom : Booking
    {
        public DeluxeRoom(string bookingRef, string hotelName, string checkInId) : base(bookingRef, hotelName, checkInId) { }

        public override void calculateBill(double nights)
        {
            double total = nights * 200;
            Console.WriteLine("Deluxe Room Bill: {0}", total);
        }
    }

    public class Suite : Booking
    {
        public Suite(string bookingRef, string hotelName, string checkInId) : base(bookingRef, hotelName, checkInId) { }

        public override void calculateBill(double nights)
        {
            double total = nights * 500;
            Console.WriteLine("Suite Room Bill: {0}", total);
        }
    }

    public class Program
    {
        public static void Main()
        {
            Booking b1 = new StandardRoom("BR101", "SeaView Hotel", "CIN001");
            Booking b2 = new DeluxeRoom("BR102", "Royal Inn", "CIN002");
            Booking b3 = new Suite("BR103", "Grand Palace", "CIN003");

            b1.addGuest("Gaurav");
            b2.addGuest("Rishabh");
            b3.addGuest("Mishra");

            b1.calculateBill(3);
            b2.calculateBill(2);
            b3.calculateBill(5);

            b1.SetGuestFeedback("Good stay!");
            b2.SetGuestFeedback("Excellent service!");
            b3.SetGuestFeedback("Loved the suite!");

        }
    }
}








































