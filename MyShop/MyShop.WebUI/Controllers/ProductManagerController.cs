﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyShop.Core.Models;

namespace MyShop.WebUI.Controllers
{
    public class ProductManagerController : Controller
    {
       
        // GET: ProductManager
        public ActionResult Index()
        {
            return View();
        }
    }
}