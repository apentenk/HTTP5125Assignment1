using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Creates a greeting message to a given number of people
        /// </summary>
        /// <param name="id">the number of people being greeted</param>
        /// <returns>Greetings to {id} people!</returns>
        /// <example>
        /// localhost:xx/api/Greeting/3 => Greetings to 3 people
        /// </example>
        public String Get(String id)
        {
            return "Greetings to " + id + " people!"; 
        }

        /// <summary>
        /// Responds Hello World
        /// </summary>
        /// <returns>"Hello World"</returns>
        /// <example>
        /// localhost:xx/api/Greeting => Hello World
        /// </example>
        public String Post() 
        {
            return "Hello World!";
        }
    }
}
