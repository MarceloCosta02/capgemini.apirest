using apirest.Exceptions;
using apirest.Models;
using apirest.Services.Interfaces;
using apirest.Validation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace apirest.Services
{
    public class PetService : PetValidation, IPetService
    {

        /// <summary> 
        /// Retorna todos Pets
        /// </summary>
        public IEnumerable<Pets> GetAll()
        {
            var pets = GeneratePetList();
            return pets;
        }

        /// <summary> 
        /// Retorna o pet por nome
        /// </summary>
        /// <param name="name"></param>
        public IEnumerable<Pets> GetByName(string name)
        {
            var pet = GeneratePetList().Where(p => p.Name.Contains(name));

            if (!pet.Any())
                throw new PetException($"Pet {name} não encontrado");
            else
                return pet;
        }

        /// <summary> 
        /// Cria o Pet
        /// </summary>
        public Pets Create(Pets pets)
        {
            PetIsNotNull(pets);

            Debug.WriteLine($"Pet {pets.Name} criado com sucesso");
            return new Pets(pets.PetNumber, pets.Name, pets.PetType, pets.Weight);
        }

        /// <summary> 
        /// Atualiza o Pet
        /// </summary>
        /// <param name="pets"></param>
        public Pets Update(Pets pets)
        {
            PetIsNotNull(pets);

            Debug.WriteLine($"Pet {pets.Name} atualzado com sucesso");
            return new Pets(pets.PetNumber, pets.Name, pets.PetType, pets.Weight);
        }

        /// <summary> 
        /// Implementação do método que deleta o Pet
        /// </summary>
        /// <param name="petNumber"></param>
        public void Delete(int petNumber)
        {
            Debug.WriteLine($"Pet com id {petNumber} deletado com sucesso");
        }                
    }
}
