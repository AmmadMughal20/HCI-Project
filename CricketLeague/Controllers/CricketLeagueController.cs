using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CricketLeague.Controllers
{
    public class CricketLeagueController : Controller
    {
        // GET: CricketLeague
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult UpcomingMatches()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult HomeAfterSignIn()
        {
            return View();
        }

        public ActionResult UpcomingMatchesAfterSignIn()
        {
            return View();
        }

        public ActionResult AboutUsAfterSignIn()
        {
            return View();
        }

        public ActionResult ContactUsAfterSignIn()
        {
            return View();
        }

        public ActionResult TeamAdding()
        {
            return View();
        }

        public ActionResult HomeAfterTeamAdding()
        {
            return View();
        }

        public ActionResult MyTeam()
        {
            return View();
        }

        public ActionResult UpcomingMatchesAfterTeamUpload()
        {
            return View();
        }
        
        public ActionResult AboutUsAfterTeamUpload()
        {
            return View();
        }

        public ActionResult ContactUsAfterTeamUpload()
        {
            return View();
        }


    }
}