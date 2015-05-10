using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdvisorDAL.Models
{
    public class Hotel
    {
        public Hotel() {
            Comments = new List<Comment>();
        }

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="Hotel name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Hotel address is required.")]
        public string Address { get; set; }
        public string Description { get; set; }

        public virtual List<Comment> Comments{ get; set; }
    }
}
