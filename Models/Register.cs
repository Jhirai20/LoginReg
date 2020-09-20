using System.ComponentModel.DataAnnotations;
namespace SimpleLoginRegistration.Models
{
    public class Register 
    {
    [Required(ErrorMessage="Please enter a First Name!")]
    [MinLength(2, ErrorMessage = "Frist name must be at least 2 characters")]

    public string FirstName {get;set;}
    [MinLength(2, ErrorMessage = "Last name must be at least 2 characters")]
    
    [Required(ErrorMessage="Please enter a Last Name!")]
    public string LastName{get;set;}
    [Required(ErrorMessage="Please enter a Email!")]
    [EmailAddress(ErrorMessage = "Enter a valid email address")]
    public string Email{get;set;}
    [Required(ErrorMessage="Please enter a Password!")]
    [MinLength(8, ErrorMessage = "Last name must be at least 8 characters")]
    public string Password{get;set;}
    [Required(ErrorMessage="Please enter a Confirm Password!")]
    [Compare("Password", ErrorMessage = "Confirm password doesn't match, please try again!")]
    public string ConfirmPassword{get;set;}

    }
}