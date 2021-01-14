
using System.Collections.Generic;
using DuwaysRabbitBus.Checkout.Domain.Models;
using DuwaysRabbitBus.Checkout.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using DuwaysRabbitBus.Checkout.Application.Models;

namespace DuwaysRabbitBus.Checkout.Api.Controllers
{

    /**
     * Checkout api controller
     * 
     */ 
    [Route("api/[controller]")]
    [ApiController]
    public class CheckoutController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public CheckoutController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        // GET api/checkout
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountService.GetAccounts());
        }

        [HttpPost]
        public IActionResult Post([FromBody] AccountOrder accountTransfer)
        {
            _accountService.Order(accountTransfer);
            return Ok(accountTransfer);
        }
    }
}
