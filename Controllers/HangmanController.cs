using dotnet_core_mvc_ahorcado.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_core_mvc_ahorcado.Controllers
{
    public class HangmanController : Controller
    {
        public IActionResult Index()
        {
            string[] words = { "AMOR", "VIDA", "LUZ", "PAZ", "FELIZ", "MUNDO", "TIEMPO", "CIUDAD", "CASA", "FAMILIA", "AMIGO", "ESCUELA", "TRABAJO", "DINERO", "SALUD", "LIBRO" };
            string[] letters = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
            

            HangmanViewModel model = new HangmanViewModel();

            Random random = new Random();

            model.wordToGuess = words[random.Next(0,words.Length-1)];
            model.letters = letters;


            return View(model);
        }
    }
}
