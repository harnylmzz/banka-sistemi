using System;
using BankingCreditSystem.Application.Services.Repositories;
using BankingCreditSystem.Domain.Entities;

public interface ICustomerRepository : IAsyncRepository<Customer, Guid>
{
} 