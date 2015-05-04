using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web.Mvc;
using OrderEntry.Models.Utility;


namespace OrderEntry.Models.Repository
{
    /// <summary>
    /// This class is used for managing orders
    /// </summary>
    public class OrderEntryRepository : IOrderEntryRepository
    {
        /// <summary>
        /// The database used to manage orders
        /// </summary>
        private OrderEntryEntities db;

        /// <summary>
        /// Constructs a new order repository
        /// </summary>
        public OrderEntryRepository()
        {
            db = new OrderEntryEntities();

            db.Database.Log = (s => System.Diagnostics.Debug.WriteLine(s));
        }

        /// <summary>
        /// Creates a new order
        /// </summary>
        /// <param name="order">The order to create</param>
        public void Create(Order order)
        {
            order.ID = Guid.NewGuid();

            order.ODATE = DateTime.Now;

            db.Orders.Add(order);

            db.SaveChanges();
        }

        /// <summary>
        /// Deletes an order with the specified ID
        /// </summary>
        /// <param name="id">The order ID</param>
        public void Delete(Guid? id)
        {
            Order order = db.Orders.Find(id);

            db.Orders.Remove(order);

            db.SaveChanges();
        }

        /// <summary>
        /// Manages the disposal of the class
        /// </summary>
        public void Dispose()
        {
            db.Dispose();
        }

        /// <summary>
        /// Gets a list of all orders
        /// </summary>
        /// <returns>A list of all orders</returns>
        public List<Order> GetAll()
        {
            List<Order> orders = db.Orders
                .OrderBy(o => o.ODATE)
                .ToList();

            return orders;
        }

        /// <summary>
        /// Returns order with the specified ID 
        /// </summary>
        /// <param name="Id">The order with the specified ID</param>
        /// <returns></returns>
        public Order GetById(Guid? Id)
        {
            Order order = db.Orders.Find(Id);

            return order;
        }

        /// <summary>
        /// Updates an order
        /// </summary>
        /// <param name="order">The order to be updated</param>
        public void Update(Order order)
        {
            db.Entry(order).State = EntityState.Modified;

            db.SaveChanges();
        }
        /// <summary>
        /// Returns a list of Sales Persons
        /// </summary>
        /// <returns>List of Sales Persons</returns>
        public List<SelectListItem> GetSalesPersons()
        {
            var sales = db.SalesPersons
                .ToList()
                .Select(s => new SelectListItem
                {
                    Value = s.SalesId.ToString(),
                    Text = s.Name.ConvertToTitleCase()

                }).OrderBy(c => c.Text).ToList();

            return sales;

            throw new NotImplementedException();
        }
        /// <summary>
        /// Returns a list of all active shipping methods' names
        /// </summary>
        /// <returns>A list of all active shipping methods' names</returns>
        public List<String> GetAllActiveShippingMethods(String text)
        {
            List<String> shippingMethods = db.ShippingMethods
                .OrderBy(s => s.Name)
                .Where(s => s.Active == true && s.Name.StartsWith(text))
                .Select(s => s.Name)
                .ToList();

            return shippingMethods;
        }
    }
}