// -------------------------------------------------------------------------------------
//  <copyright file="CustomerService.cs" company="The AA (Ireland)">
//    Copyright (c) The AA (Ireland). All rights reserved.
//  </copyright>
// -------------------------------------------------------------------------------------

namespace WebApiTest.Services.Implementations;

using DataSource;
using Interfaces;
using Models;

public class CustomerService : ICustomerService
{

    public Customer GetCustomer(int id)
    {
        return CustomerDataSource.GetCustomer(id);
    }
}