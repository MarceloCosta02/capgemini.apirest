using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apirest.Exceptions
{
    public class PetNotFoundException : ApplicationException
    {
        /// <summary> 
        /// Excessão personalizada da classe Pets para Not Found 404
        /// </summary>
        public PetNotFoundException(string message) : base(message) { }
    }
}
