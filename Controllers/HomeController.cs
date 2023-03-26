using ANS_SHOP.Models;
using System.Data.Entity;
using System.Web.Mvc;

namespace ANS_SHOP.Controllers
{
    
    public class HomeController : Controller
    {
        public int GameIndex=0;
        public int gamesCount;
        public GameContext db = new GameContext(); 
        public DbSet<Game> games;
        public ActionResult Index()
        {
            games = db.Games;
            ViewBag.Games = games;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GameInformation(int id)
        {
            ViewBag.Message = id;
            games = db.Games;
            ViewBag.Games = games;
            return View();
        }

    }
}