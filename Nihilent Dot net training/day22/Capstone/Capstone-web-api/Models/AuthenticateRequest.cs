using System.ComponentModel.DataAnnotations;

namespace Capstone_web_api.Models;

public class AuthenticateRequest
{
    [Required]
    public string UserName { get; set; }
    
    [Required] 
    public string Password { get; set; }
}