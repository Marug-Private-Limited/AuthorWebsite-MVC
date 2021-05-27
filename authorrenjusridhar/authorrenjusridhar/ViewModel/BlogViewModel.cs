using authorrenjusridhar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace authorrenjusridhar.ViewModel
{
    public class BlogViewModel
    {
        public IEnumerable<author_blog> Blog { get; set; }
        public IEnumerable<author_blogcomments> Comments { get; set; }
    }
}