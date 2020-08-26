using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkyAPI.Repository.IRepository;

namespace ParkyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalParkController : ControllerBase
    {
        private INationalRepository _npRepo; 
        private readonly IMapper _mapper;

        public NationalParkController(INationalRepository npRepo, IMapper mapper)
        {
            _npRepo = npRepo;
            _mapper = mapper;

        }

        [HttpGet]
        public IActionResult GetAllNationalPark()
        {
            var objgetAll = _npRepo.GetNationalParks();
            return Ok(objgetAll);
        }

        [HttpGet]
        public IActionResult GetNationalParkByID()
        {
            return Ok();
        }

    }
}