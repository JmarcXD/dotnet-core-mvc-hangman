using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace dotnet_core_mvc_ahorcado.Models
{
    public class HangmanViewModel
    {
        public string wordToGuess { get; set; }
        public string[] letters { get; set; }
    }
}
