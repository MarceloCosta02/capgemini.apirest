using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apirest.Exceptions
{
    public class PetException : ApplicationException
    {
        /// <summary> 
        /// Excessão personalizada da classe Pets
        /// </summary>
        public PetException(string message) : base(message) { }
    }
}
