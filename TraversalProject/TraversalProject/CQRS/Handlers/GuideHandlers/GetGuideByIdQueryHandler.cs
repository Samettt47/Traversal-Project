﻿using DataAccessLayer.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TraversalProject.CQRS.Queries.GuideQueries;
using TraversalProject.CQRS.Results.GuideResult;

namespace TraversalProject.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIdQueryHandler : IRequestHandler<GetGuideByIdQuery, GetGuideByIdQueryResult>
    {

        private readonly Context _context;

        public GetGuideByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIdQueryResult> Handle(GetGuideByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.Id);
            return new GetGuideByIdQueryResult
            {
                GuideId = values.GuideId,
                Name = values.Name,
                Description = values.Description
        };
        }
    }
}
