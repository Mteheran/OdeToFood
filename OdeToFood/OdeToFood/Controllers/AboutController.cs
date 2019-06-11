using System;
using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    //[Route("about")]
    [Route("[controller]")]
    public class AboutController
    {
        public AboutController()
        {
        }

        [Route("")]
        public string Phone()
        {
            return "56565656-5656-56-56";
        }

        [Route("[action]")]
        public string Address()
        {
            return "Street fake 123";
        }
    }
}
