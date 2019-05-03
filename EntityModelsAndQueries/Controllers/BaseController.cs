using EntityModelsAndQueries.Models;
using System.Web.Mvc;

namespace EntityModelsAndQueries.Controllers
{
    public class BaseController : Controller
    {
        public readonly ApplicationDbContext DbContext;
        public BaseController()
        {
            DbContext = new ApplicationDbContext();
        }
    }
}