using ASpNetCore.MVC.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASpNetCore.MVC.Controllers
{
    public class TechnologyController : Controller
    {
        private ITechnologyCore _technologyCore;
        public TechnologyController(ITechnologyCore technologyCore)
        {
            _technologyCore = technologyCore;   
        }
        // GET: TechnologyController
        public ActionResult Index()
        {
            return View(_technologyCore.GetList());
        }

        // GET: TechnologyController/Details/5
        public ActionResult Details(int id)
        {
            return View(_technologyCore.GetById(id));
        }

        // GET: TechnologyController/Create
        public ActionResult Create()
        {
            return View();
        }
        // GET: TechnologyController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_technologyCore.GetById(id));
        }

    }
}
