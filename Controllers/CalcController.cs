using Microsoft.AspNetCore.Mvc;

namespace KR1.Controllers
{
    public class CalcController : Controller
    {
        [HttpGet]
        public IActionResult plus(double o1, double o2)
        {
            return Content($"{o1} + {o2} = {o1 + o2}");
        }

        [HttpGet]
        public IActionResult subtract(double o1, double o2)
        {
            return Content($"{o1} - {o2} = {o1 - o2}");
        }

        [HttpGet]
        public IActionResult multiply(double o1, double o2)
        {
            return Content($"{o1} * {o2} = {o1 * o2}");
        }

        [HttpGet]
        public IActionResult divide(double o1, double o2)
        {
            if (o2 == 0)
            {
                return Content("Деление на ноль невозможно.");
            }
            return Content($"{o1} / {o2} = {o1 / o2}");
        }
    }
}
