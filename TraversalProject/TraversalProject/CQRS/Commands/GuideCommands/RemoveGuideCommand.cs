using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.CQRS.Commands.GuideCommands
{
    public class RemoveGuideCommand : IRequest
    {
        public RemoveGuideCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
