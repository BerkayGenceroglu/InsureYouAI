using InsureYouAI.Dtos;
using InsureYouAI.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace InsureYouAI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserRegisterDto dto)
        {
            AppUser appUser = new AppUser
            {
                Name = dto.Name,
                Surname = dto.Surname,
                UserName = dto.UserName,
                Email = dto.Email,
                Description = "Açıklama",
                ImageUrl = "ImageUrl"
            };
            await  _userManager.CreateAsync(appUser, dto.Password);
            return RedirectToAction("LoginUser","Login");
        }
    }
}
