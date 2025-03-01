using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dianalove.Pages
{
    public class IndexModel : PageModel
    {
        private static readonly string[] compliments = {
            "�����, �� ������ �������������!",
            "���� ������, �����, �������� ���� ���!",
            "�����, �� ���������� ������ � �������!",
            "��, �����, ��������� ���������!",
            "�����, ���� ������� �� ����� ������!"
        };

        public IActionResult OnGetGenerateCompliment()
        {
            var random = new Random();
            var compliment = compliments[random.Next(compliments.Length)];
            return Content(compliment);
        }
    }
}