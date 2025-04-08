using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BostadzPortalenWebAPI.Controllers
{
    //Author: Johan Nelin
    public class RealEstateAgencyController : Controller
    {



        // GET: RealEstateAgencyController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RealEstateAgencyController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RealEstateAgencyController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RealEstateAgencyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RealEstateAgencyController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RealEstateAgencyController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RealEstateAgencyController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RealEstateAgencyController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
