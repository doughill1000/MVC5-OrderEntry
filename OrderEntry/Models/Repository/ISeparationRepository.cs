using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderEntry.Models.Repository
{
    public interface ISeparationRepository
    {
        /// <summary>
        /// Creates a new separation
        /// </summary>
        /// <param name="order">The separation to create</param>
        void Create(Separation separation);

        /// <summary>
        /// Deletes a separation with the specified ID
        /// </summary>
        /// <param name="id">The separation ID</param>
        void Delete(Guid? id);

        /// <summary>
        /// Disposes the class
        /// </summary>
        void Dispose();

        /// <summary>
        /// Returns a list of all separations
        /// </summary>
        /// <returns>A list of all separations</returns>
        List<Order> GetAll();

        /// <summary>
        /// Returns the separation with the specified ID (or null if no order is found)
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>The separation with the specified ID</returns>
        Order GetById(Guid? Id);

        /// <summary>
        /// Updates a separation
        /// </summary>
        /// <param name="order">The separation to update</param>
        void Update(Order order);

    }
}