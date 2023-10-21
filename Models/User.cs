namespace Online_Laundry.Models
{
    
    
        public class User
        {
            public int UserId { get; set; }
            public byte[] ProfilePhoto { get; set; }
            public string Fullname { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public int PhoneNumber { get; set; }
            public bool TermsAndConditionsAccepted { get; set; }
            public bool PhoneNumberVerified { get; set; }
            public bool EmailVerified { get; set; }
            public string Address { get; set; }

            // Contact Information
            public string ContactName { get; set; }
            public string ContactEmail { get; set; }
            public int ContactPhone { get; set; }
            public string ContactMessage { get; set; }
        }

        public class Package
        {
            public int PackageId { get; set; }
            public string PackageName { get; set; }
            public string PackageDetail { get; set; }
            public int PackagePrice { get; set; }
        }

        public class Booking
        {
            public int BookingId { get; set; }
            public int UserId { get; set; }
            public int BookingOptionType { get; set; }
            public string ItemName { get; set; }
            public int Quantity { get; set; }
            public decimal? Weight { get; set; }
            public bool Pressing { get; set; }
            public int? PackageId { get; set; }
            public DateTime BookingDatetime { get; set; }
            public int OrderStatus { get; set; }
            public decimal BookingPrice { get; set; }
        }

    
}
