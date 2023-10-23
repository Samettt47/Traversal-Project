using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.CQRS.Results.DestinationResult
{
    public class GetDestinationByIDQueryResult
    {
        // Bunlar bizim güncelleyeceğimiz verilere ait değerler 
        public int Destinationid { get; set; }
        public string City { get; set; }
        public string Daynight { get; set; }
        public double Price { get; set; }
    }
}
