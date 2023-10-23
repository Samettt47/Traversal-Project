using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Areas.AdminsArea.Models
{
    public class VisitorViewModel
    {
        public int VisitorID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Mail { get; set; }

    }
}
