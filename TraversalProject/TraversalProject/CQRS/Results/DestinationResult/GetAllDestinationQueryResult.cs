using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.CQRS.Results.DestinationResult
{
    public class GetAllDestinationQueryResult
    {
        // üye olmayan kullanıcının görebileceği propertyler 
        public int Id { get; set; }
        public string city { get; set; }
        public double price { get; set; }
        public int capacisty { get; set; }
        public string daynight { get; set; }

    }
}
