using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAdvisorDAL.Models;
using HotelAdvisorDAL.DataContext;

namespace HotelAdvisorDAL.Managers
{
    public class HotelManager
    {
        public void CreateHotel(Hotel hotel)
        {
            using (var context = new HotelAdvisorContext())
            {
                context.Hotels.Add(hotel);
                context.SaveChanges();
            }
        }

        public Hotel FindHotelById(int id)
        {
            Hotel hotel;
            using (var context = new HotelAdvisorContext())
            {
                hotel = context.Hotels.Find(id);
            }
            return hotel;
        }

        public decimal FindHotelAverageRating(int id)
        {
            decimal averageRating;
            
            using (var context = new HotelAdvisorContext())
            {
                context.Hotels.Include("Comments");
                var hotel = context.Hotels.Find(id);
                averageRating = hotel.Comments.Count == 0 ? 0 : hotel.Comments.Average(c => c.Rating);
            }
            return averageRating;
        }
    }
}
