using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAuthorization.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AccountController : ControllerBase
    {
        [AllowAnonymous]
        public ActionResult Login()
        {

        }

        [Authorize]
        public ActionResult Logout()
        {

        }
    }
}
