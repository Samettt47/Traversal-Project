﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Models.ViewComponents.MemberDashboard
{
    public class _MemberStatistic : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
