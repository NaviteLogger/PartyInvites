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

        [HttpGet]
        public ViewResult RsvpForm() //defines the method that will handle the received request
        { 
            return View(); //Razor engine will use the RsvpForm.cshtml file to generate the response
        }

        [HttpPost] //This version of the action will be responsible for receiving submitted data and deciding what to do with it.
        public ViewResult RsvpForm(GuestResponse guestResponse) //defines the method that will handle the received request
        {
            Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse);
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}
