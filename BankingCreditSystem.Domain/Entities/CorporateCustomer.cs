using System;

public class CorporateCustomer : Customer
{
    public string CompanyName { get; set; } = default!;
    public string TaxNumber { get; set; } = default!;
    public string TaxOffice { get; set; } = default!;
    public string CompanyRegistrationNumber { get; set; } = default!;
    public DateTime EstablishmentDate { get; set; }
    public decimal AnnualRevenue { get; set; }
    public string BusinessSector { get; set; } = default!;
} 