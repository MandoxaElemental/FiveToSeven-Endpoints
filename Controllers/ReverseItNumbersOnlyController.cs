using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FiveToSeven_Endpoints.Services;

namespace FiveToSeven_Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItNumbersOnly : ControllerBase
    {
        private readonly ReverseItNumbersOnlyServices _reverseItNumbersOnlyServices;
        public ReverseItNumbersOnly(ReverseItNumbersOnlyServices reverseItNumbersOnlyServices){
            _reverseItNumbersOnlyServices = reverseItNumbersOnlyServices;
        }
        [HttpPost]
        [Route("reversedNum/{userInput}")]
         public List<string> ReversedNum(string userInput){
            return _reverseItNumbersOnlyServices.ReversedNum(userInput);
         }
    }
}