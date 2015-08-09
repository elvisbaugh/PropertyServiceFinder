using MVCPropertyService.Models;
using MVCPropertyService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVCPropertyService.Controllers
{
    public class EmailingController : Controller
    {
       

        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> GetEmailForm(GalleryDetails model)
        {
          if (ModelState.IsValid)
          {
            EmailServices sendMail = new EmailServices();

            await sendMail.SendEmail(model.DisplayEmailForm);


            return RedirectToAction("Portland", "PropertyLocation");
          }
          else
          {
            return View(model);
          }
        }

    }
}
