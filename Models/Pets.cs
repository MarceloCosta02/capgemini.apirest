using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apirest.Models
{
    public class Pets
    {       
        public int PetNumber { get; set; }
        public string Name { get; set; }
        public string PetType { get; set; }
        public double Weight { get; set; }

        /// <summary>
        /// Contrutor
        /// </summary>
        /// <param name="petNumber"></param>
        /// <param name="name"></param>
        /// <param name="petType"></param>
        /// <param name="weight"></param>

        public Pets(int petNumber, string name, string petType, double weight)
        {
            PetNumber = petNumber;
            Name = name;
            PetType = petType;
            Weight = weight;
        }
    }
}
