// -------------------------------------------------------------------------------------
//  <copyright file="ICustomerService.cs" company="The AA (Ireland)">
//    Copyright (c) The AA (Ireland). All rights reserved.
//  </copyright>
// -------------------------------------------------------------------------------------

namespace WebApiTest.Services.Interfaces;

using Models;

public interface ICustomerService
{
    Customer GetCustomer(int id);
}