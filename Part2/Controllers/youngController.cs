using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Part2.Controllers
{
    public class youngController : Controller
    {
        // GET: youngController
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        // GET: youngController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: youngController/Create
        public ActionResult Create()
        {
            return View();
        }

       
    }
}
