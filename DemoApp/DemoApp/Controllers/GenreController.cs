using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoApp.Models;

namespace DemoApp.Controllers
{
    public class GenreController : RavenController
    {
        //
        // GET: /Genre/

        public ActionResult Index()
        {
            var model = this.RavenSession.Query<Genre>().ToList();
            return View(model);
        }

    }
}
