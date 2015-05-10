using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAdvisorDAL.DataContext;
using HotelAdvisorDAL.Models;


namespace HotelAdvisorDAL.Managers
{
    public class UserManager
    {
        public void CreateUser(User user)
        {
            using (var context = new HotelAdvisorContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public User FindUserById(int id)
        {
            User user;
            using (var context = new HotelAdvisorContext())
            {
                user = context.Users.Find(id);
            }
            return user;
        }
    }
}
