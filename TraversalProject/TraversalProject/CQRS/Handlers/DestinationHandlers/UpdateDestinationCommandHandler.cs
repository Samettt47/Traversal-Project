﻿using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.CQRS.Commands.DestinationCommands;

namespace TraversalProject.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;

        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateDestinationCommand command )
        {
            var values = _context.Destinations.Find(command.Destinationid);
            values.City = command.City;
            values.DayNight = command.Daynight;
            values.Price = command.Price;
            _context.SaveChanges();
        }
        
    }
}
