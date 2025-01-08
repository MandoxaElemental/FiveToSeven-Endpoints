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
            bool validCheck = false;
            int convertedNum;
        public List<string> EvenOrOdd(string num){
            validCheck = int.TryParse(num, out convertedNum);
            if(validCheck == false){
                result.Add("Please Enter a Valid Number");
                return result;
            }
            else{
            if((convertedNum % 2) == 0){
                result.Add($"{num} is an Even Number");
            } else {
                result.Add($"{num} is an Odd Number");
            }
            }
            return result;
        }
    }
}