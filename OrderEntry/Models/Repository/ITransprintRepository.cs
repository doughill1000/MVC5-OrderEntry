using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OrderEntry.Models.Repository
{
    public interface ITransprintRepository
    {
        /// <summary>
        /// Gets a current list of Customers 
        /// </summary>
        /// <returns>A list of active Customers</returns>
        List<SelectListItem> GetCustomers();

        /// <summary>
        /// Gets a list of countries to ship to
        /// </summary>
        /// <returns></returns>
        List<SelectListItem> GetCountries();

        /// <summary>
        /// Gets a customer by finding the Customer Number (CUSTNO)
        /// </summary>
        /// <param name="custnum">The customer number</param>
        /// <returns>A Customer</returns>
        Customer GetByCustNum(double custnum);
    }
}
