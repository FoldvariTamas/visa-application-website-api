using Microsoft.AspNetCore.Mvc;
using visa_application_website_API.Services;

namespace visa_application_website_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("allUsers")]
        public IActionResult GetAllBikes()
        {
            return Ok(_userService.GetAll());
        }
    }
}
