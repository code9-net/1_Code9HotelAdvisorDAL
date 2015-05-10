using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAdvisorDAL.Models;
using HotelAdvisorDAL.DataContext;
using System.Data.Entity;
using HotelAdvisorDAL.Migrations;
using HotelAdvisorDAL.Managers;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<HotelAdvisorContext, Configuration>()); 
            //CreateHotel();

           // User u = new User{Email="jelena@code9.com", Password="Code9Pass" };
           // UserManager um = new UserManager();
            //um.CreateUser(u);

            //User u1 = new User { Email = "jelenaM@code9.com", Password = "Code9Pass" };
            //um.CreateUser(u1);

            //User user = um.FindUserById(1);
            //Console.WriteLine("User id:{0}, email: {1}", user.Id, user.Email);
            //Console.ReadKey();

            //var c1 = new Comment{Text = "Odlican hotel!", Rating = 4, UserId = 1, HotelId=1};
            //var c2 = new Comment{Text = "Dobar bazen!", Rating = 2, UserId = 1, HotelId=2};
            //var c3 = new Comment{Text = "Odlican hotel!", Rating = 5, UserId = 2, HotelId=1};
            //CommentManager cm = new CommentManager();
            //cm.CreateComment(c1);
            //cm.CreateComment(c2);
            //cm.CreateComment(c3);

            HotelManager hm = new HotelManager();
            decimal r = hm.FindHotelAverageRating(1);
            Console.WriteLine("rating " + r);
            Console.ReadKey();
        }

        private static void CreateHotel()
        {
            Console.WriteLine("Please enter hotel name:");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter hotel address:");
            var address = Console.ReadLine();

            var hotel = new Hotel { Name = name, Address = address };

            using (var context = new HotelAdvisorContext())
            {
                context.Hotels.Add(hotel);
                context.SaveChanges();

                Console.WriteLine("Hotels in our database:");

                var query = from h in context.Hotels
                            orderby h.Name
                            select h;

                foreach (var h in query)
                {
                    Console.WriteLine(string.Format("Hotel id: {0}, name: {1}, address:{2}", h.Id, h.Name, h.Address));
                }

                Console.WriteLine("Press any key to exit application.");
                Console.ReadKey();
            }
        }
    }
}
