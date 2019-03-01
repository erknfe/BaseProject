using System.Linq;
using System.Web.Mvc;
using Test.Data.DTO;
using Test.Data.POCO;
using Test.Validation.Entity;

namespace Test.UI.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var data = Repository.Class1s.Select(s => new Class1DTO
            {
                Name = s.Name,
                Description = s.Description
            });

            return View(data);
        }

        [HttpPost]
        public ActionResult AddClass1(Class1 model)
        {
            var validator = new Class1Rules { Repository = Repository };
            var validatorResult = validator.ValidateSave(model);

            if (validatorResult.Success)
            {
                Repository.Class1s.Add(model);
                Repository.SaveChanges();

                return Json(new
                {
                    Success = true
                }, JsonRequestBehavior.AllowGet);
            }

            return Json(new
            {
                Success = false,
                Message = validatorResult.Message
            });
        }
    }
}