﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stalins_notebook.Controllers
{
    public class ShowItemController : Controller
    {
        public ActionResult Contact()
        {
            return PartialView();
        }
        public ActionResult Group()
        {
            return PartialView();
        }
    }
}