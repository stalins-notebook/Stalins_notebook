﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace Stalins_notebook.Models
{
    public class Pair
    {
        public int idgroup { get; set; }
        public int idcontact { get; set; }
    }
}