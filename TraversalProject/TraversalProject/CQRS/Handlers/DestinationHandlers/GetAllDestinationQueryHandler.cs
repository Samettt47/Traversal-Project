using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.CQRS.Queries.DestinationQueries;
using TraversalProject.CQRS.Results.DestinationResult;

namespace TraversalProject.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {
        private readonly Context _context;

        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetAllDestinationQueryResult> Handle() // bir sonraki derste Handle adında hazır bir mediator kullanacaz
                                                                                        // burada oluşturulan CRUD işleminin metodu olarak Adını Handle atadıgı ıcın
                                                                                        // adını böyle yapmak uygun 
        {
            var values = _context.Destinations.Select(x => new GetAllDestinationQueryResult
            {
                Id = x.DestinationId,
                city = x.City,
                capacisty = x.Capasity,
                daynight = x.DayNight,
                price = x.Price


            }).AsNoTracking().ToList(); // BUNUN ILE VERİTABANINDA KI EĞER GÜNCELLEME ISLEMI VS YAPARSAK BU LISTELEME UZERINDEN
                                        // GÜNCELELENECKE VERİLER TUMM VERİTABANI ENTİTYDEKI PROPLARI KARSILAMAYACAGI ICIN
                                        // GERİ KALAN PROPLAR(SUTUN VERILERI ) DEGISMEYECEK

            return values;
        }

    }
}
