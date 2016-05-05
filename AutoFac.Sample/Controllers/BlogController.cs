using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoFac.Sample.Models;

namespace AutoFac.Sample.Controllers
{
    public class BlogController : ApiController
    {

        private IPostRepository _repository;
        
        public BlogController(IPostRepository repository)
        {
            _repository = repository;
        }
        
        public IEnumerable<Post> Recent(int retrievalCount)
       {
           return _repository.ListRecentPosts(retrievalCount);
       }
    
       [HttpPost]
       public void Add(Post post)
       {
           _repository.Add(post);
       }    
    }
}
