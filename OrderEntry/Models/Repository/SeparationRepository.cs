using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OrderEntry.Models.Repository
{
    /// <summary>
    /// This class is used for managing Separations
    /// </summary>
    public class SeparationRepository : ISeparationRepository
    {
        /// <summary>
        /// The database to manage separations
        /// </summary>
        private OrderEntryEntities db;

        /// <summary>
        /// Constructs a new separation repository
        /// </summary>
        public SeparationRepository()
        {
            db = new OrderEntryEntities();
            db.Database.Log = (s => System.Diagnostics.Debug.WriteLine(s));
        }

        /// <summary>
        /// Creates a new separation
        /// </summary>
        /// <param name="separation">The separation to create</param>
        public void Create(Separation separation)
        {
            separation.SeparationId = Guid.NewGuid();

            separation.DateReceived = DateTime.Now;

            db.Separations.Add(separation);

            db.SaveChanges();
        }

        /// <summary>
        /// Deletes a separation
        /// </summary>
        /// <param name="id">The ID of the separation</param>
        public void Delete (Guid? id)
        {
            Separation separation = db.Separations.Find(id);

            db.Separations.Remove(separation);

            db.SaveChanges();
        }

        /// <summary>
        /// Manages disposal fo the class
        /// </summary>
        public void Dispose()
        {
            db.Dispose();
        }

        /// <summary>
        /// Gets a list of all separations
        /// </summary>
        /// <returns></returns>
        public List<Separation> GetAll()
        {
            List<Separation> separations = db.Separations
                .OrderBy(s => s.DateReceived)                
                .ToList();

            return separations;
        }

        /// <summary>
        /// Returns the separation with the specified ID
        /// </summary>
        /// <param name="Id">The separation with the specified ID</param>
        /// <returns></returns>
        public Separation GetById(Guid? Id)
        {
            Separation separation = db.Separations.Find(Id);

            return separation;
        }

        /// <summary>
        /// Updates the separation
        /// </summary>
        /// <param name="separation">The separation to be updated</param>
        public void Update(Separation separation)
        {
            db.Entry(separation).State = EntityState.Modified;

            db.SaveChanges();
        }


        
    }
}