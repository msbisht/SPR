﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SPR.Controllers
{
    public class AirTreatmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
