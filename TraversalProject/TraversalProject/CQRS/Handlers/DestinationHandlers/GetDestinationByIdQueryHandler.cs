using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.CQRS.Queries.DestinationQueries;
using TraversalProject.CQRS.Results.DestinationResult;

namespace TraversalProject.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIdQueryHandler(Context context)
        {
            _context = context;
        }
        // BURADA ID YE GORE GETIRME ISLEMI YAPACAGIMIZ ICIN METOD TURU ILGILI PROPERTYLERI YAZDIMIZ SINIFA AIT ENTİTY OLDU
        // PARAMETRE ICIN ISE OLUŞTUDUGUMUZ GetDestinationByIdQuery BU SINIFTA KI DESTİNATİON'DAN ID Y KARSILAYACAK SINIFI ALDIK
        public GetDestinationByIDQueryResult Handle(GetDestinationByIdQuery query)
        {
            var values = _context.Destinations.Find(query.Id);

            return new GetDestinationByIDQueryResult
            {
                Destinationid = values.DestinationId,
                Daynight = values.DayNight,
                City = values.City,
                Price = values.Price
            };
        }

    }
}
