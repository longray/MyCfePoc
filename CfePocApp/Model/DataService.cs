using System;

namespace CfePocApp.Model
{
    using System.Collections.ObjectModel;

    public class DataService : IDataService
    {
        public void GetTexts(Action<Texts, Exception> callback)
        {
            var item = new Texts(14,"CFE 2015");
            callback(item, null);
        }

        public void GetCustomers(Action<ObservableCollection<Customer>, Exception> callback)
        {
            var customers = new ObservableCollection<Customer>
                                {
                                    new Customer
                                        {
                                            FirstName = "Orlando",
                                            LastName = "Gee",
                                            Email = "orlando0@adventure-works.com",
                                            IsMember = true,
                                            Status = OrderStatus.New
                                        },
                                    new Customer
                                        {
                                            FirstName = "Keith",
                                            LastName = "Harris",
                                            Email = "keith0@adventure-works.com",
                                            IsMember = true,
                                            Status = OrderStatus.Received
                                        },
                                    new Customer
                                        {
                                            FirstName = "Donna",
                                            LastName = "Carreras",
                                            Email = "donna0@adventure-works.com",
                                            IsMember = false,
                                            Status = OrderStatus.None
                                        },
                                    new Customer
                                        {
                                            FirstName = "Janet",
                                            LastName = "Gates",
                                            Email = "janet0@adventure-works.com",
                                            IsMember = true,
                                            Status = OrderStatus.Shipped
                                        },
                                    new Customer
                                        {
                                            FirstName = "Lucy",
                                            LastName = "Harrington",
                                            Email = "lucy0@adventure-works.com",
                                            IsMember = false,
                                            Status = OrderStatus.New
                                        },
                                    new Customer
                                        {
                                            FirstName = "Rosmarie",
                                            LastName = "Carroll",
                                            Email = "rosmarie0@adventure-works.com",
                                            IsMember = true,
                                            Status = OrderStatus.Processing
                                        },
                                    new Customer
                                        {
                                            FirstName = "Dominic",
                                            LastName = "Gash",
                                            Email = "dominic0@adventure-works.com",
                                            IsMember = true,
                                            Status = OrderStatus.Received
                                        },
                                    new Customer
                                        {
                                            FirstName = "Kathleen",
                                            LastName = "Garza",
                                            Email = "kathleen0@adventure-works.com",
                                            IsMember = false,
                                            Status = OrderStatus.None
                                        },
                                    new Customer
                                        {
                                            FirstName = "Katherine",
                                            LastName = "Harding",
                                            Email = "katherine0@adventure-works.com",
                                            IsMember = true,
                                            Status = OrderStatus.Shipped
                                        },
                                    new Customer
                                        {
                                            FirstName = "Johnny",
                                            LastName = "Caprio",
                                            Email = "johnny0@adventure-works.com",
                                            IsMember = false,
                                            Status = OrderStatus.Processing
                                        }
                                };

            callback(customers, null);
        }
    }
}