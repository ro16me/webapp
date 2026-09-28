using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Answer4 = "Value types (e.g., int, bool, double, struct) store their data directly in their own memory allocation on the stack. When assigned to a new variable or passed to a method, a complete copy of the value is made. In contrast, reference types (e.g., class, string, object, arrays) store a memory address pointer on the stack that references the actual object data located on the managed heap. When assigned or passed, only the reference pointer is copied, meaning multiple variables point to the exact same object in memory.";

            ViewBag.Answer5 = "In C#, a property is a member of a class that provides a flexible mechanism to read, write, or compute the value of a private field using 'get' and 'set' accessors. Properties enforce the object-oriented principle of encapsulation: to external consumers, they look and behave just like public fields, but internally they allow data validation, business logic, access restrictions (such as private set or init-only), and change notifications without exposing internal state directly.";

            return View();
        }
    }
}