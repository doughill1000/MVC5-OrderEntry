using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OrderEntry.Models.Repository
{
    public interface IOrderEntryRepository
    {
        /// <summary>
        /// Creates a new order
        /// </summary>
        /// <param name="order">The order to create</param>
        void Create(Order order);

        /// <summary>
        /// Deletes an order with the specified ID
        /// </summary>
        /// <param name="id">The order ID</param>
        void Delete(Guid? id);

        /// <summary>
        /// Disposes the class
        /// </summary>
        void Dispose();

        /// <summary>
        /// Edits the specified order
        /// </summary>
        void Edit(Order order);

        /// <summary>
        /// Returns a list of all orders
        /// </summary>
        /// <returns>A list of all orders</returns>
        List<Order> GetAll();

        /// <summary>
        /// Returns the order with the specified ID (or null if no order is found)
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>The Order with the specified ID</returns>
        Order GetById(Guid? Id);

        /// <summary>
        /// Updates an order
        /// </summary>
        /// <param name="order">The order to update</param>
        void Update(Order order);

        /// <summary>
        /// Gets a list of sales persons
        /// </summary>
        /// <returns>List of sales persons</returns>
        List<SelectListItem> GetSalesPersons();

        
    }
}
