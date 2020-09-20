using System.ComponentModel.DataAnnotations;
namespace SimpleLoginRegistration.Models
{
    public class IndexViewModel
    {
        public Login User{get;set;} 
        public Register NewUser{get;set;} 
    }
}