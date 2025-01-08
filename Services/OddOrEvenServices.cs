using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven_Endpoints.Services
{
    public class OddOrEvenServices
    {
        public List<string> result = new();

        public List<string> EvenOrOdd(int num){
            if((num % 2) == 0){
                result.Add($"{num} is an Even Number");
            } else {
                result.Add($"{num} is an Odd Number");
            }
            return result;
        }
    }
}