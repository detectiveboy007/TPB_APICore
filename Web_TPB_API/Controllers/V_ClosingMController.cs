using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_TPB_API.Models.Dtos;
using Web_TPB_API.Repository.IRepository;

namespace Web_TPB_API.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/closingm")]
    [ApiController]
    public class V_ClosingMController : ControllerBase
    {
        private readonly IV_ClosingMRepository _npRepo;
        private readonly IMapper _mapper;
        public V_ClosingMController(IV_ClosingMRepository npRepo, IMapper mapper)
        {
            _npRepo = npRepo;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<V_ClosingMDto>))]
        public IActionResult GetNationalParks()
        {
            var objList = _npRepo.GetV_ClosingM();
            var objDto = new List<V_ClosingMDto>();
            foreach (var obj in objList)
            {
                objDto.Add(_mapper.Map<V_ClosingMDto>(obj));
            }
            return Ok(objDto);
        }
    }
}
