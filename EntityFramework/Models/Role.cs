using System.ComponentModel.DataAnnotations.Schema;
namespace EntityFramework.Models;
public class Role
{
    [Column("role_id")]
    public int RoleId { get; set; }

    [Column("role")]
    public string? RoleName { get; set; }
}