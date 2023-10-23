using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.CQRS.Commands.GuideCommands
{
    public class CreeateGuideCommand : IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        
       
    }
}
