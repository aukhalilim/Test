using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFac.Sample.Models
{
    public interface IPostRepository
    {
        void Add(Post post);
        IList<Post> ListRecentPosts(int retrievalCount);
    }

   public class Post
   {
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public string Url { get; set; }
    }
}
