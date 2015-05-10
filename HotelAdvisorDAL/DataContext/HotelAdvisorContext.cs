using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAdvisorDAL.Models;

namespace HotelAdvisorDAL.DataContext
{
    public class HotelAdvisorContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
