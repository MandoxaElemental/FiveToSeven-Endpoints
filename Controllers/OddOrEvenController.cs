using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FiveToSeven_Endpoints.Services;

namespace OddOrEven.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OddOrEvenController : ControllerBase
    {
        private readonly OddOrEvenServices _oddOrEvenServices;
        public OddOrEvenController(OddOrEvenServices oddOrEvenServices){
            _oddOrEvenServices = oddOrEvenServices;
        }
        [HttpPost]
        [Route("evenOrOdd/{num}")]
        public List<string> EvenOrOdd(string num){
        return _oddOrEvenServices.EvenOrOdd(num);
        }
    }
}