using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TaskManager.Web.Models;

public class LoginViewModel
{
    [Required(ErrorMessage = "Email Address is Required"), EmailAddress(ErrorMessage = "Invalid email address format")]
    [Display(Name = "Email Address")]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = "Password is required"), DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; } = "";

    public bool RememberMe { get; set; }
}