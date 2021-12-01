using DataAccess.Repositories;
using Dto.Request;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _ProyectoPueblosMagicosAPI.Controllers
{
    [ApiController]
    [Route("controller")]
    public class ArtesanoController : ControllerBase
    {
        private readonly IArtesanoService _service;
        public ArtesanoController(IArtesanoService service)
        {
            _service = service;
        }


        [HttpGet]
        [Route("TodosRegistros")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.ListAsync());
        }

        [HttpGet]
        [Route("{id:int}")]

        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _service.GetAsync(id));
        }

        [HttpPost]
        [Route("Registro_Artesano")]
        public async Task<IActionResult> Post([FromBody] ArtesanoDtoRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _service.CreateAsync(request);

            return Created($"/{response}", new
            {
                Id = response
            });
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Put(int id, ArtesanoDtoRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _service.UpdateAsync(id, request);

            return Accepted(new
            {
                Id = response
            });
        }

        [HttpPost]
        [Route("Registro_Productos")]
        public async Task<IActionResult> Post([FromBody] ArtesaniasDtoRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _service.CreateAsync1(request);

            return Created($"/{response}", new
            {
                Id = response
            });
        }

        [HttpGet]
        [Route("{Buscar_Restaurantes}")]
        public async Task<IActionResult> Get(string Buscar_Restaurantes)
        {
            return Ok(await _service.GetAsync1(Buscar_Restaurantes));
        }

        [HttpGet]
        [Route("Todos_Restaurantes")]
        public async Task<IActionResult> Get2()
        {
            return Ok(await _service.ListAsync2());
        }

        [HttpPost]
        [Route("Registro_Restaurantes")]
        public async Task<IActionResult> Post2([FromBody] RestaurantesDtoRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _service.CreateAsync2(request);

            return Created($"/{response}", new
            {
                Id = response
            });
        }
    }
}
