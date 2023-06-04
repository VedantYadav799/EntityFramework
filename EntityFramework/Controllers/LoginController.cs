using EntityFramework.Models;
using EntityFramework.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _lgsvr;
    
        public LoginController(ILoginService lgsvr)
        {
            _lgsvr = lgsvr;
        }

        [HttpGet]
        [Route("employees")]
        public IEnumerable<Employee> GetAll()
        {
            IEnumerable<Employee> employees = _lgsvr.GetAll();
            return employees;
        }


    }
}
