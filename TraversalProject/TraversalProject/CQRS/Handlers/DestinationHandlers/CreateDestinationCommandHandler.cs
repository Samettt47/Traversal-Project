﻿using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.CQRS.Commands.DestinationCommands;

namespace TraversalProject.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly Context _context;

        public CreateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateDestinationCommand command)
        {
            _context.Destinations.Add(new Destination {
            
                City = command.City,
                Price = command.Price,
                DayNight = command.DayNight,
                Status = true,
                Capasity = command.Capasity

            });
            _context.SaveChanges();

        }
    }
}
