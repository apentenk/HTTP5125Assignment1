using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Returns the square of a given number
        /// </summary>
        /// <param name="id">the number that is going to be squared</param>
        /// <returns>a number multiplied by itself</returns>
        /// <example>
        /// localhost:xx/api/Square/2 => 4
        /// </example>
        /// <example>
        /// localhost:xx/api/Square/-2 => 4
        /// </example>
        /// <example>
        /// localhost:xx/api/Square/10 => 100
        /// </example>
        public int Get(int id)
        {
            return id * id;
        }
    }
}
