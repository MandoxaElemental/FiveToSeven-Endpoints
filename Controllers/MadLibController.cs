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
    public class MadLibController : ControllerBase
    {
        private readonly MadLibServices _madLibServices;
        public MadLibController(MadLibServices madLibServices)
        {
            _madLibServices = madLibServices;
        }
        [HttpPost]
        [Route("addToMadLibList/{name}/{adjective}/{name2}/{time}/{room}/{item}/{bodyPart}/{jobPosition}/{name3}/{ingVerb}/{emotion}/{adjective2}/{oceanCreature}/{color}/{number}/{animal}/{familyMember}/{timeOfDay}/{adjective3}/{nationality}/{item2}/{drink}/{number2}/{item3}/{city}")]
        public List<string> AddToMadLibList(string name, string adjective, string name2, string time, string room, string item, string bodyPart, string jobPosition, string name3, string ingVerb, string emotion, string adjective2, string oceanCreature, string color, string number, string animal, string familyMember, string timeOfDay, string adjective3, string nationality, string item2, string drink, string number2, string item3, string city)
        {
            return _madLibServices.AddToMadLibList(name, adjective, name2, time, room, item, bodyPart, jobPosition, name3, ingVerb, emotion, adjective2, oceanCreature, color, number, animal, familyMember, timeOfDay, adjective3, nationality, item2, drink, number2, item3, city);
        }
    }
}
