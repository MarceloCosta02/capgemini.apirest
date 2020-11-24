using apirest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apirest.Services.Interfaces
{
    public interface IPetService
    {
        /// <summary> 
        /// Retorna todos Pets
        /// </summary>
        IEnumerable<Pets> GetAll();

        /// <summary> 
        /// Retorna o pet por nome
        /// </summary>
        /// <param name="name"></param>
        IEnumerable<Pets> GetByName(string name);

        /// <summary> 
        /// Cria o Pet
        /// </summary>
        /// <param name="pets"></param>
        Pets Create(Pets pets);

        /// <summary> 
        /// Atualiza o Pet
        /// </summary>
        /// <param name="pets"></param>
        Pets Update(Pets pets);

        /// <summary> 
        /// Deleta o Pet
        /// </summary>
        /// <param name="petNumber"></param>
        void Delete(int petNumber);
    }
}
