using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdvisorDAL.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="User email is required.")]
        public string Email { get; set; }
        [Required(ErrorMessage="User password is required.")]
        public string Password { get; set; }

        public virtual List<Comment> Comments { get; set; }
    }
}
