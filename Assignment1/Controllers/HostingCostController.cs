using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// Calculates the cost of a clients stay based on the length of the stay. Includes tax.
        /// </summary>
        /// <param name="id">represents the number of days whihc has elapsed since the beginning of the hosting</param>
        /// <returns>A receipt detailing the subtotal, tax, and total cost of stay</returns>
        /// <example>
        /// localhost:xx/api/HostingCost/0 => “1 fortnights at $5.50/FN = $5.50 CAD”,“HST 13% = $0.72 CAD”,“Total = $6.22 CAD”
        /// </example>
        /// <example>
        /// localhost:xx/api/HostingCost/14 => “2 fortnights at $5.50/FN = $11.00 CAD”,“HST 13% = $1.43 CAD”,“Total = $12.43 CAD”
        /// </example>
        /// <example>
        /// localhost:xx/api/HostingCost/21 => “2 fortnights at $5.50/FN = $11.0 CAD”,“HST 13% = $1.43 CAD”,“Total = $12.43 CAD”
        /// </example>
        public IEnumerable<string> Get(int id)
        {
            int fortnights = (id / 14) + 1;
            float subtotal = fortnights * 5.5f;
            string hst = string.Format("{0:0.00}", (subtotal * 0.13f));
            string total = string.Format("{0:0.00}", (subtotal * 1.13f));



            return new string[]
            {
                fortnights + " fornights at $ 5.50/FN = $" +string.Format("{0:0.00}",subtotal) +" CAD",
                "HST 13% = $" +hst+" CAD",
                "Total = $"+ total + " CAD"
            };
        }
    }
}
