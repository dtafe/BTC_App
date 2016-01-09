using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BtcClaims.Web.Controllers
{
    public class FaucetController : Controller
    {
        // GET: Faucet
        public ActionResult Index()
        {
            return View();
        }
    }
}