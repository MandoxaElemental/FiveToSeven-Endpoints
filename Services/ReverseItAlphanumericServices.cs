using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven_Endpoints.Services
{
    public class ReverseItAlphanumericServices : ControllerBase
    {
        public List<string> reversedWord = new ();
        string emptyWord = string.Empty;
        public List<string> ReversedWord(string userInput){
            for(int i=userInput.Length-1; i >= 0; i--){
                emptyWord += userInput[i];
            }
            reversedWord.Add($"Input = {userInput}... Output = {emptyWord} Have a nice day");
            return reversedWord;
        }
    }
}