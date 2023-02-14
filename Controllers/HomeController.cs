using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller //you can define a controller by deriving from the Controller class
                                             //you can define multiple controllers in a single file
    {
        public IActionResult Index()
        {
            return View(); //Razor engine will use the Index.cshtml file to generate the response
        }

        public ViewResult RsvpForm() //defines the method that will handle the received request
        { 
            return View(); //Razor engine will use the RsvpForm.cshtml file to generate the response
        }
    }
}
