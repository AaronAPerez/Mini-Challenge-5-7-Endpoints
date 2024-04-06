using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mini_Challenge_5_7_Endpoints.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FourEndpointsController : ControllerBase
    {
        [HttpGet("/MadLibs")]
        public string MadLibs(string instrument, string pluralNoun, string adjective, string pluralNoun2, string adjective2, string musicGenre, string sound, string emotion)
    {
        string MadLibsText = $"I love music. I play my {instrument} every night, and I write songs about {pluralNoun} as often as I can. I used to be in a band called The {adjective} {pluralNoun2}. We played {adjective2} {musicGenre} music, which sounds a lot like {sound}, but with a lot of {emotion} put into it.";
        return MadLibsText;
    }
    

        [HttpGet("/OddOrEven")]
        public string OddOrEven(string number)
        {
            if (int.TryParse(number, out int num))
            {
            return (num % 2 == 0) ? $"{num} is an even number." : $"{num} is an odd number.";
            }
        else{
                return "ERROR! Invalid input, please enter another number.";
            }
        }

        [HttpGet("/ReverseItAll")]
        public string ReverseItAll(string userInput)
            {
                if (string.IsNullOrEmpty(userInput))
                    return "User input is necessary";

                char[] changeToCharArray = userInput.ToCharArray();
                Array.Reverse(changeToCharArray);
                
                string reversed = new string (changeToCharArray);

                return "Your input was:  " + userInput + "!\nYour input reversed is:  " + reversed + "!";
            }
    

        [HttpGet("/ReversedItNumber")]
            public string ReversedNumber(string userNumber)
            {
            string reversed = "";
            if (double.TryParse(userNumber, out double num))
            {
                for (int i = userNumber.Length - 1; i >= 0; i--)
                {
                    reversed += userNumber[i];
                }
                return $"You entered {userNumber}, reversed is {reversed}";
            }
            else
            {
            return "ERROR! Invalid input, please enter a number";
            }
        }
    }
}
