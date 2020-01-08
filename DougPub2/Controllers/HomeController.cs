using DougPub2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DougPub2.Controllers {
    public class HomeController : Controller {
        ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            // Get most popular albums
            var items = GetTopSellingItems(4);

            return View(items);
        }
        private List<Item> GetTopSellingItems(int count)
        {
            // Group the order details by album and return
            // the albums with the highest count
            return db.Items
                .OrderByDescending(a => a.OrderDetails.Count())
                .Take(count)
                .ToList();
        }


        public ActionResult About() {
            ViewBag.Message = "Our food is as good as the root beer.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
