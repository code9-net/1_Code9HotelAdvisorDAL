using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAdvisorDAL.DataContext;
using HotelAdvisorDAL.Models;

namespace HotelAdvisorDAL.Managers
{
    public class CommentManager
    {
        public void CreateComment(Comment comment)
        {
            using (var context = new HotelAdvisorContext())
            {
                context.Comments.Add(comment);
                context.SaveChanges();
            }
        }

        public Comment FindCommentById(int id)
        {
            Comment comment;
            using (var context = new HotelAdvisorContext())
            {
                comment = context.Comments.Find(id);
            }
            return comment;
        }
    }
}
