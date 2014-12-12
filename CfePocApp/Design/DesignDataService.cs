using System;
using CfePocApp.Model;

namespace CfePocApp.Design
{
    using System.Collections.ObjectModel;

    public class DesignDataService : IDataService
    {
        public void GetTexts(Action<Texts, Exception> callback)
        {
            // Use this to create design time data

            var item = new Texts(12,"CFE(Design)");
            callback(item, null);
        }

        public void GetCustomers(Action<ObservableCollection<Customer>, Exception> callback)
        {
            var customers = new ObservableCollection<Customer>
                                {
                                    new Customer
                                        {
                                            FirstName = "Orlando(Design)",
                                            LastName = "Gee",
                                            Email = "orlando0@adventure-works.com",
                                            IsMember = true,
                                            Status = OrderStatus.New
                                        },
                                    new Customer
                                        {
                                            FirstName = "Keith(Design)",
                                            LastName = "Harris",
                                            Email = "keith0@adventure-works.com",
                                            IsMember = true,
                                            Status = OrderStatus.Received
                                        },
                                    new Customer
                                        {
                                            FirstName = "Donna(Design)",
                                            LastName = "Carreras",
                                            Email = "donna0@adventure-works.com",
                                            IsMember = false,
                                            Status = OrderStatus.None
                                        },
                                    new Customer
                                        {
                                            FirstName = "Janet(Design)",
                                            LastName = "Gates",
                                            Email = "janet0@adventure-works.com",
                                            IsMember = true,
                                            Status = OrderStatus.Shipped
                                        },
                                    new Customer
                                        {
                                            FirstName = "Lucy(Design)",
                                            LastName = "Harrington",
                                            Email = "lucy0@adventure-works.com",
                                            IsMember = false,
                                            Status = OrderStatus.New
                                        },
                                    new Customer
                                        {
                                            FirstName = "Rosmarie(Design)",
                                            LastName = "Carroll",
                                            Email = "rosmarie0@adventure-works.com",
                                            IsMember = true,
                                            Status = OrderStatus.Processing
                                        },
                                    new Customer
                                        {
                                            FirstName = "Dominic(Design)",
                                            LastName = "Gash",
                                            Email = "dominic0@adventure-works.com",
                                            IsMember = true,
                                            Status = OrderStatus.Received
                                        },
                                    new Customer
                                        {
                                            FirstName = "Kathleen(Design)",
                                            LastName = "Garza",
                                            Email = "kathleen0@adventure-works.com",
                                            IsMember = false,
                                            Status = OrderStatus.None
                                        },
                                    new Customer
                                        {
                                            FirstName = "Katherine(Design)",
                                            LastName = "Harding",
                                            Email = "katherine0@adventure-works.com",
                                            IsMember = true,
                                            Status = OrderStatus.Shipped
                                        },
                                    new Customer
                                        {
                                            FirstName = "Johnny(Design)",
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