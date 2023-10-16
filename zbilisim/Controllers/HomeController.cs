using Microsoft.AspNetCore.Mvc;
using zbilisim.Core.Services;
using zbilisim.Model.Entities;

namespace zbilisim.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICoreService<FormTable> _formDb;

        public HomeController(ICoreService<FormTable> formDb)
        {
            _formDb= formDb;    
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        //public IActionResult SendForm()
        //{
        //    return View();
        //}

        [HttpPost]
        public IActionResult SendForm(FormTable  formTable)
        {
            if (formTable.NameSurname != null && formTable.Message!=null)
            {
                return _formDb.Add(formTable) ?  RedirectToAction("Index") : RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

    }
}
