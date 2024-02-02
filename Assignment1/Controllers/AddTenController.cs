using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class AddTenController : ApiController
    {

        /// <summary>
        /// Adds 10 to a given number
        /// </summary>
        /// <param name="id">the number that is going to be increased by 10</param>
        /// <returns>{id} + 10</returns>
        /// <example>
        /// localhost:xx/api/AddTen/21 => 31
        /// </example>
        /// <example>
        /// localhost:xx/api/AddTen/0 => 10
        /// </example>
        /// <example>
        /// localhost:xx/api/AddTen/-9 => 1
        /// </example>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
