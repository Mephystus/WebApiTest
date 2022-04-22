// -------------------------------------------------------------------------------------
//  <copyright file="AnotherCustomerService.cs" company="The AA (Ireland)">
//    Copyright (c) The AA (Ireland). All rights reserved.
//  </copyright>
// -------------------------------------------------------------------------------------

namespace WebApiTest.Services.Implementations;

using Interfaces;
using Models;

public class AnotherCustomerService : ICustomerService
{
    public Customer GetCustomer(int id)
    {
        throw new NotImplementedException();
    }
}