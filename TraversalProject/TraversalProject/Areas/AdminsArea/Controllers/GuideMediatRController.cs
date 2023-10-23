using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.CQRS.Commands.GuideCommands;
using TraversalProject.CQRS.Queries.GuideQueries;

namespace TraversalProject.Areas.AdminsArea.Controllers
{
    [Area("AdminsArea")]
    [AllowAnonymous]
    public class GuideMediatRController : Controller
    {
        private readonly IMediator _mediator;

        public GuideMediatRController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllGuideQuery()); // istek burada ki getallGuideQuery'e gideceği için burada send ile istek gönderidk? 
            return View(values);
        }
       
        [HttpGet]
        public async Task<IActionResult> GetGuide(int id)
        {
            var values = await _mediator.Send(new GetGuideByIdQuery(id));
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> GetGuide(UpdateGuideCommand command) // update işlemi 
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

       [HttpGet]
       public IActionResult AddGuide()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddGuide(CreeateGuideCommand command)
        {
            await _mediator.Send(command); // BU OTOMATIK OLARAK EKLEYEECEK HERHANGI BIR NEW ISLEMINE GEREK YOK
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteGuide(int id)
        {
            await _mediator.Send(new RemoveGuideCommand(id));
            return RedirectToAction("Index");
        }
    }
}
