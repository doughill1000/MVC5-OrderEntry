using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderEntry.Models.Repository
{
    interface ITransprintRepository
    {
        /// <summary>
        /// Gets a current list of Customers 
        /// </summary>
        /// <returns>A list of active Customers</returns>
        List<Customer> GetCustomers();

        /// <summary>
        /// Gets a list of countries to ship to
        /// </summary>
        /// <returns></returns>
        List<Country> GetCountries();
    }
}
