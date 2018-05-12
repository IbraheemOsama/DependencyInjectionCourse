using System.Web.Mvc;
using AutofacWebMvcFive.Filters;
using AutofacWebMvcFive.Repositories;

namespace AutofacWebMvcFive.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IDataRepository _dataRepository;

        public HomeController(IUserRepository userRepository, IDataRepository dataRepository)
        {
            _userRepository = userRepository;
            _dataRepository = dataRepository;
        }

        [LogActionFilter]
        public ActionResult Index()
        {
            var data = _dataRepository.GetData();
            var users = _userRepository.GetUsers();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}