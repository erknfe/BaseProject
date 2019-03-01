using System.Web.Mvc;
using Test.Data.ORM;

namespace Test.UI.Controllers
{
    public class BaseController : Controller
    {
        public DatabaseContext Repository = new DatabaseContext();
    }
}