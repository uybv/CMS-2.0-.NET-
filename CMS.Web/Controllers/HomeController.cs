using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository.Pattern.Repositories;
using Repository.Pattern.UnitOfWork;
using CMS.Entities.Models;
using CMS.Repository;
using WebMarkupMin.Mvc.ActionFilters;


namespace CMS.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly IUnitOfWorkAsync _unitOfWorkAsync;

        public HomeController(IUnitOfWorkAsync unitOfWorkAsync)
        {
            _unitOfWorkAsync = unitOfWorkAsync;
        }

        [CompressContent]
        [MinifyHtml]
        public ActionResult Index()
        {
            IRepositoryAsync<Role> repo = _unitOfWorkAsync.RepositoryAsync<Role>();
            var data = repo.GetByStatus(Entities.Status.Enable).ToList();
            return View();
        }

        [CompressContent]
        [MinifyHtml]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [CompressContent]
        [MinifyHtml]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}