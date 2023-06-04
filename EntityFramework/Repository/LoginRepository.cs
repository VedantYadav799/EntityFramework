using EntityFramework.Models;
using EntityFramework.Repositories.Interfaces;
using EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EntityFramework.Repositories;
public class LoginRepository : ILoginRepository
{
    private IConfiguration _configuration;
    public LoginRepository(IConfiguration configuration)
    {

        _configuration = configuration;

    }
        public IEnumerable<Employee> GetAll(){
         using (var context = new LoginContext())
            {
             var users = from emp in context.employees select emp;
             return users.ToList<Employee>();
            }
    }


 
    
}