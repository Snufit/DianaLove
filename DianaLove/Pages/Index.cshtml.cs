using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dianalove.Pages
{
    public class IndexModel : PageModel
    {
        private static readonly string[] compliments = {
            "Диана, ты просто очаровательна!",
            "Твоя улыбка, Диана, освещает весь мир!",
            "Диана, ты воплощение грации и красоты!",
            "Ты, Диана, настоящее сокровище!",
            "Диана, твоя доброта не знает границ!"
        };

        public IActionResult OnGetGenerateCompliment()
        {
            var random = new Random();
            var compliment = compliments[random.Next(compliments.Length)];
            return Content(compliment);
        }
    }
}