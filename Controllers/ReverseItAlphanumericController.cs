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
    public class ReverseItAlphanumeric : ControllerBase
    {
        private ReverseItAlphanumericServices _reverseItAlphanumericServices;
        public ReverseItAlphanumeric(ReverseItAlphanumericServices reverseItAlphanumericServices){
            _reverseItAlphanumericServices = reverseItAlphanumericServices;
        }
        [HttpPost]
        [Route("reversedWord/{userInput}")]
         public List<string> ReversedWord(string userInput){
            return _reverseItAlphanumericServices.ReversedWord(userInput);
         }
    }
}