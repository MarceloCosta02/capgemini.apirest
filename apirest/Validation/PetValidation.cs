using apirest.Exceptions;
using apirest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apirest.Validation
{
    public abstract class PetValidation
    {
        /// <summary> 
        /// Verifica se os campos do Pet não é nulo
        /// </summary>
        public void PetIsNotNull(Pets pets)
        {
            if (pets.PetNumber.Equals(0))
                throw new PetBadRequestException("O numero do pet não pode ser 0");
            else if (string.IsNullOrEmpty(pets.Name))
                throw new PetBadRequestException("O nome do pet está vazio");
            else if (string.IsNullOrEmpty(pets.PetType))
                throw new PetBadRequestException("O tipo do pet está vazio");
            else if (pets.Weight.Equals(0))
                throw new PetBadRequestException("O peso do pet está vazio");
        }       
    }
}
