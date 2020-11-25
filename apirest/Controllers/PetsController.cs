using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apirest.Exceptions;
using apirest.Models;
using apirest.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace apirest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetsController : BaseController
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
            var result = _petService.GetAll();
            return new ObjectResult(result) { StatusCode = StatusCodes.Status200OK };
        }

        /// <summary>
        /// Lista o Pet por nome
        /// </summary>
        [HttpGet("{find-by-name}")]
        public IActionResult GetByName([FromQuery] string name) => VerifyResult(() =>
        {
            var result = _petService.GetByName(name);
            return new ObjectResult(result) { StatusCode = StatusCodes.Status200OK };
        });

        /// <summary>
        /// Insere o Pet
        /// </summary>
        [HttpPost]
        public IActionResult Post([FromBody] Pets pet)
        {
            var result = _petService.Create(pet);
            return new ObjectResult(result) { StatusCode = StatusCodes.Status201Created };
        }

        /// <summary>
        /// Atualiza o Pet
        /// </summary>
        [HttpPut]
        public IActionResult Put([FromBody] Pets pet)
        {
            var result = _petService.Update(pet);
            return new ObjectResult(result) { StatusCode = StatusCodes.Status200OK };
        }

        /// <summary>
        /// Modifica o Pet
        /// </summary>
        [HttpPatch]
        public IActionResult Patch([FromBody] Pets pet)
        {
            var result = _petService.Modify(pet);
            return new ObjectResult(result) { StatusCode = StatusCodes.Status200OK };
        }

        /// <summary>
        /// Deleta o Pet
        /// </summary>
        [HttpDelete("{id}")]
        public IActionResult Delete([FromQuery] int petNumber)
        {
            _petService.Delete(petNumber);
            return NoContent();
        }
    }
}
