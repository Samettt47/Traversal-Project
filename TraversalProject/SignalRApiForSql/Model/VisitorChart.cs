﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRApiForSql.Model
{
    public class VisitorChart
    {    
        public VisitorChart()
        {
            Counts = new List<int>();
        }

        public string VisitDate { get; set; }

        public List<int> Counts { get; set; } // bu tarihte ilgili şehrim kaç kişi tarafından ziyaret edildi.
      
    }
}
