using DataAccessLayer.Concrete;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TraversalProject.CQRS.Queries.GuideQueries;
using TraversalProject.CQRS.Results.GuideResult;

namespace TraversalProject.CQRS.Handlers.GuideHandlers
{
    public class GetAllGuideQueryHandler : IRequestHandler<GetAllGuideQuery , List<GetAllGuideQueryResult>> 
                                            // YUKARDIDA MEADİATR KULLANILDI VE DEDİKKİ DEPENDENCY INJECTION YAZMAMAK ICIN CONTRROLERDA
                                            // IREQUESTHANDLERIN< ( İSTEK ATILACAK KISIM , LİST<RESPONSE GELECEK KISIM>
                                            // YANİ İLK PARAMETRE İSTEĞİ KARŞILIYOR İKİNCİSİ İSE LİSTE OLARAK VERİYİ RESPONS'UNU KARSILIYOR
                                            // ALTTAKİ HANDLE METODU ISE YAZMAZSAK IMPLEMENTE HATASI VERIYOR CTRL + . DEYİNCE OTOMATIK GELİYOR
    {
        private readonly Context _context;

        public GetAllGuideQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllGuideQueryResult>> Handle(GetAllGuideQuery request, CancellationToken cancellationToken)
        {
            return await _context.Guides.Select(x => new GetAllGuideQueryResult
            {
                GuideId = x.GuideId,
                Name = x.Name,
                Description = x.Description,
                Image = x.Image
            }).AsNoTracking().ToListAsync();
        }
    }
}
