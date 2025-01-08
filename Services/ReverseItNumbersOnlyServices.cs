using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven_Endpoints.Services
{
    public class ReverseItNumbersOnlyServices
    {
        public List<string> reversedNum = new ();
        bool validCheck = false;
        int convertedNum;
        string emptyNum = string.Empty;
        public List<string> ReversedNum(string userInput){
             validCheck = int.TryParse(userInput, out convertedNum);
            if(validCheck == false){
                reversedNum.Add("Enter Only Numbers Please");
                return reversedNum;
            }
            else{
            for(int i=userInput.Length-1; i >= 0; i--){
                emptyNum += userInput[i];
            }
            }
            reversedNum.Add($"Input = {userInput}... Output = {emptyNum} Have a nice day");
            return reversedNum;
        }
    }
}