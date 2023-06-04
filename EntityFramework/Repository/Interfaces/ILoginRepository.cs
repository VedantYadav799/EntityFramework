using System.Collections;
using System.Net.Http.Headers;
using EntityFramework.Models;
namespace EntityFramework.Repositories.Interfaces;
public interface ILoginRepository
{
IEnumerable<Employee> GetAll();
}