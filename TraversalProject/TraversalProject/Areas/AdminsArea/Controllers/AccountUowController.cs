using BusinessLayer.Abstract.AbstractUow;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.Models;

namespace TraversalProject.Areas.AdminsArea.Controllers
{
    [AllowAnonymous]
    [Area("AdminsArea")]
    public class AccountUowController : Controller
    {
       
        private readonly IAccountService _accountService;

        public AccountUowController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        public IActionResult RedirectIndex()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AccountViewModel accountViewModel)
        {
            var valueSender = _accountService.TGetById(accountViewModel.SenderId);
            var valueReceiver = _accountService.TGetById(accountViewModel.ReceiverId);
            
            //senderid , recieverid , amount
            valueSender.Balance -= accountViewModel.Amount;
            valueReceiver.Balance += accountViewModel.Amount;

            List<Account> modifiedAccounts = new List<Account>()
            {
                valueSender,
                valueReceiver
            };  // MODİFİEDACCOUNT OBJESININ ALTINDA VALUESENDER OLACAK BUNUN ALTINDA DA ID BALANCE VE NAME BILGISI TUTULACAK
                // BU ARAY BITINCE VALUERECEİVER İN ALTINDA  ID , BALANCE , NAME TUTULMUŞ OLACAK.
            _accountService.TMultiUpdate(modifiedAccounts);



            return RedirectToAction("RedirectIndex");
        }
    }
}
