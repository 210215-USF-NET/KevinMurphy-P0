using System.Collections.Generic;
using Model =  StoreModels;
using Entity = StoreDL.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StoreModels;
namespace StoreDL
{
    public class StoreDB : IStoreRepository
    {
        public Customer AddCustomer(Customer newCustomer)
        {
            throw new System.NotImplementedException();
        }

        public Item AddIO(Item I)
        {
            throw new System.NotImplementedException();
        }

        public Order AddOrder(Order newOrder)
        {
            throw new System.NotImplementedException();
        }

        public List<Customer> GetCustomer()
        {
            throw new System.NotImplementedException();
        }

        public Customer GetCustomerById(int? Id)
        {
            throw new System.NotImplementedException();
        }

        public Customer GetCustomerByNumber(string PhoneNumber)
        {
            throw new System.NotImplementedException();
        }

        public Item GetItemByOID(int? Id)
        {
            throw new System.NotImplementedException();
        }

        public List<Location> GetLocation()
        {
            throw new System.NotImplementedException();
        }

        public Location GetLocationById(int? Id)
        {
            throw new System.NotImplementedException();
        }

        public Location GetLocationByName(string number)
        {
            throw new System.NotImplementedException();
        }

        public List<Item> GetLocationItems()
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetLocations()
        {
            throw new System.NotImplementedException();
        }

        public List<Order> GetOrder()
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetProduct()
        {
            throw new System.NotImplementedException();
        }

        public Product GetProductById(int? Id)
        {
            throw new System.NotImplementedException();
        }

        public Product GetProductByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            throw new System.NotImplementedException();
        }

        List<Location> IStoreRepository.GetLocations()
        {
            throw new System.NotImplementedException();
        }
    }
}