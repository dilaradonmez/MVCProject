using BLL.Repository.Concrete;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ProductController : Controller
    {
        BaseRepository<Product> productRepository = new BaseRepository<Product>();
        public ActionResult Index()
        {
            return View(productRepository.GetAll());
        }

    }
}