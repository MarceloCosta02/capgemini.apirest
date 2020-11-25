using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apirest.Exceptions
{
    public class PetBadRequestException : ApplicationException
    {
        /// <summary> 
        /// Excessão personalizada da classe Pets para Bad Request 400
        /// </summary>
        public PetBadRequestException(string message) : base(message) { }
    }
}
