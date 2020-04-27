
using AutoMapper;
using Library.API.Models;
using Library.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Controllers
{
    [ApiController]
    [Produces("application/json", "application/xml")]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/authors")]
    public class AuthorsontrollerV2: ControllerBase
    {
        private readonly IAuthorRepository _authorsRepository;
        private readonly IMapper _mapper;

        public AuthorsontrollerV2(
            IAuthorRepository authorsRepository,
            IMapper mapper)
        {
            _authorsRepository = authorsRepository;
            _mapper = mapper;
        }
        /// <summary>
        /// Authors Controller V2
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Author>>> GetAuthors()
        {
            var authorsFromRepo = await _authorsRepository.GetAuthorsAsync();
            return Ok(_mapper.Map<IEnumerable<Author>>(authorsFromRepo));
        }
    }
}
