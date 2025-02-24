using System;

namespace BankingCreditSystem.Domain.Entities
{
    public class IndividualCustomer : Customer
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string NationalId { get; set; } = string.Empty;
        public string? MotherName { get; set; }
        public string? FatherName { get; set; }
        public string IdentityNumber { get; set; } = default!; // TC Kimlik No
        public DateTime DateOfBirth { get; set; }
        public string Occupation { get; set; } = default!;
        public decimal MonthlyIncome { get; set; }
    }
} 