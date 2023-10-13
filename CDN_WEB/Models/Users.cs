using System.ComponentModel.DataAnnotations;
namespace CDN_WEB.Models
{
    
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Mail { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        public string Skillsets { get; set; }
        public string Hobby { get; set; }
    }

}
