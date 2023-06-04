using System.Collections;
using System.Threading.Tasks;
using EntityFramework.Models;
using EntityFramework.Repositories.Interfaces;
using EntityFramework.Services.Interfaces;
namespace EntityFramework.Services;
public class LoginService : ILoginService
{
    private readonly ILoginRepository _repo;
    public LoginService(ILoginRepository repo)
    {
       _repo = repo;
    }

    public IEnumerable<Employee> GetAll() =>_repo.GetAll();

}