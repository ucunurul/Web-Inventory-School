﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace InventorySchool.Controllers
{
    public class ClassroomController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create() {
            return View();
        }

        public IActionResult Delete() {
            return View();
        }

        public IActionResult Details() {
            return View();
        }

        public IActionResult Edit() {
            return View();
        }

    }
}
