using Microsoft.AspNetCore.Mvc;

namespace PalindromeChecker.Controllers
{
    public class PalindromeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PalindromeCheck(int number)
        {
            if (number < 0) return BadRequest("Please input positive numbers only.");

            var originalNumber = number.ToString();
            var reversedNumber = new string(originalNumber.Reverse().ToArray());
            bool isPalindrome = originalNumber == reversedNumber;

            return Json(new {Number  = number, IsPalindrome = isPalindrome});
            
        }
    }
}
