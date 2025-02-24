
namespace BankingCreditSystem.Domain.Entities
{
    public class CorporateCustomer : Customer
    {
        public string CompanyName { get; set; } = string.Empty;
        public string TaxNumber { get; set; } = string.Empty;
        public string TaxOffice { get; set; } = string.Empty;
        public string CompanyRegistrationNumber { get; set; } = string.Empty;
        public string AuthorizedPersonName { get; set; } = string.Empty;
    }
} 