using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using blog.Models;


namespace blog.Controllers
{
    public class adminController : Controller
    {

        // GET: admin
        public BlogDataEntities1 db = new BlogDataEntities1();
        public ActionResult Statis()
        {
            List<Blog> ListBlog = new List<Blog>();
            
            ListBlog = db.Blog.OrderByDescending(s => s.TotalView).ToList();

            return View(ListBlog);
        }
       
        public ActionResult index()
        {
            List<Account> ListAccount = new List<Account>();
            ListAccount = db.Account.ToList();
            return View(ListAccount);
        }
        public ActionResult post()
        {

            List<blog.Models.Action> ListAction = new List<blog.Models.Action>();
            ListAction = db.Action.ToList();
            
            return View(ListAction);
        }
       
    }
}