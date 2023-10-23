using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Areas.AdminsArea.Models
{
    public class RoleAssignViewModel
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public bool RoleExist { get; set; } // BBU KULLANICI BU ROLU İÇERİYOR MU / BU KULLANICI BU ROLDE VAR MI ? 
    }
}
