using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Takes a number adds 16 to it, then multiples the result by 8 then subtracts from that result and finally divides by 2
        /// </summary>
        /// <param name="id">The initial number in the equation</param>
        /// <returns>((({id} + 16)*8)-4)/2</returns>
        /// <example>
        /// localhost:xx/api/NumberMachine/10 => 102
        /// </example>
        /// <example>
        /// localhost:xx/api/NumberMachine/-5 => 42
        /// </example>
        /// <example>
        /// localhost:xx/api/NumberMachine/30 => 182
        /// </example>
        public float Get(float id)
        {
            id += 16;
            id *= 8;
            id -= 4;
            id /= 2; 
            return (float)id;
        }
    }
}
