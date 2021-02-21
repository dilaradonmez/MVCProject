using BLL.Repository.Concrete;
using DataAccess.Context;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APİ.Controllers
{
    public class HomeController : ApiController
    {
        ProjectDbContext db = new ProjectDbContext();
        BaseRepository<Product> productRepository = new BaseRepository<Product>();
       
        //public IHttpActionResult GetAllProduct()
        //{
        //    return Ok(productRepository.GetAll());
        //}

        public List<Product> GetProduct()
        {
            return db.Products.ToList();
        }

    }
}
