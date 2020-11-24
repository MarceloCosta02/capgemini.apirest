using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apirest.Exceptions;
using apirest.Models;
using apirest.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace apirest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetsController : ControllerBase
    {
        //Declaração do serviço usado
        private readonly IPetService _petService;

        public PetsController(IPetService petService)
        {
            _petService = petService;
        }

        /// <summary>
        /// Lista todos os Pets
        /// </summary>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_petService.GetAll());
        }

        /// <summary>
        /// Lista o Pet por nome
        /// </summary>
        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
        {
            try
            {
                return Ok(_petService.GetByName(name));
            }
            catch (PetException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Insere o Pet
        /// </summary>
        [HttpPost]     
        public IActionResult Post([FromBody] Pets pet)
        {
            try
            {
                return Ok(_petService.Create(pet));
            }
            catch (PetException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Atualiza o Pet
        /// </summary>
        [HttpPut]
        public IActionResult Put([FromBody] Pets pet)
        {
            try
            {
                return Ok(_petService.Update(pet));
            }
            catch (PetException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Modifica o Pet
        /// </summary>
        [HttpPatch]
        public IActionResult Patch([FromBody] Pets pet)
        {
            try
            {
                return Ok(_petService.Modify(pet));
            }
            catch (PetException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Deleta o Pet
        /// </summary>
        [HttpDelete("{id}")]
        public IActionResult Delete(int petNumber)
        {
            _petService.Delete(petNumber);
            return NoContent();
        }
    }
}
