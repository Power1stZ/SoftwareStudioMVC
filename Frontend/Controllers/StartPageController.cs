using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Frontend.Models;
using Frontend.Services;
using System.Net.Http;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Frontend.Controllers
{
    [AllowAnonymous]
    public class StartPageController : Controller
    {

        ILogger<StartPageController> _logger;
        private readonly UserService _userService;

        private readonly IHttpContextAccessor _httpContextAcessor;

        public StartPageController(ILogger<StartPageController> logger, UserService userService, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _userService = userService;
            _httpContextAcessor = httpContextAccessor;

        }


        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "MainPage");
            }
            return View();
        }

        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "MainPage");
            }
            return View();
        }
        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "MainPage");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Register register)
        {
            if (ModelState.IsValid)
            {
                var data = _userService.Create(new User
                {
                    firstName = register.firstName,
                    lastName = register.lastName,
                    studentNumber = register.studentNumber,
                    password = register.password,
                    email = register.email,
                    isBan = false,
                    role = 0,
                    exceedCount = 0
                });
                if (!data.isBan)
                {
                    var claims = new List<Claim>
                    {
                        new Claim("studentNumber", data.studentNumber),
                        new Claim("firstName",data.firstName),
                        new Claim("lastName",data.lastName),
                        new Claim("email", data.email),
                        new Claim("password",data.password),
                        new Claim(ClaimTypes.Role, data.role.ToString())
                    };

                    var claimsIdentity = new ClaimsIdentity(
                       claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                    return RedirectToAction("Index", "MainPage");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "บัญชีโดนระงับการใช้งาน");
                    return View(register);
                }

            }
            else return View(register);
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login login)
        {
            if (ModelState.IsValid)
            {
                User data = _userService.Login(login.email, login.password);
                //Console.WriteLine(JsonConvert.SerializeObject(data, Formatting.Indented));
                if (data != null)
                {

                    if (!data.isBan)
                    {
                        var claims = new List<Claim>
                        {
                            new Claim("studentNumber", data.studentNumber),
                            new Claim("firstName",data.firstName),
                            new Claim("lastName",data.lastName),
                            new Claim("email", data.email),
                            new Claim("password",data.password),
                            new Claim(ClaimTypes.Role, data.role.ToString())
                        };

                        var claimsIdentity = new ClaimsIdentity(
                           claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                        return RedirectToAction("Index", "MainPage");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "บัญชีโดนระงับการใช้งาน");
                        return View(login);
                    }

                }
                else
                {
                    ModelState.AddModelError(string.Empty, "อีเมลหรือรหัสผ่านไม่ถูกต้อง");
                    return View(login);
                }
            }
            return View(login);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "StartPage");
        }
    }
}
