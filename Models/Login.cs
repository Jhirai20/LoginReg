using System.ComponentModel.DataAnnotations;
namespace SimpleLoginRegistration.Models
{
    public class Login 
    {
        [Required(ErrorMessage="Please enter a email!")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string email {get;set;}
        [Required(ErrorMessage="Please enter a password!")]
        public string password{get;set;}
    }
}
