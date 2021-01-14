
using System.Collections.Generic;
using DuwaysRabbitBus.Ordering.Application.Interfaces;
using DuwaysRabbitBus.Ordering.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DuwaysRabbitBus.Ordering.Api.Controllers
{
    /**
     * Ordering api controller
     */ 
    [Route("api/[controller]")]
    [ApiController]
    public class OrderingController : ControllerBase
    {

        private readonly IOrderingService _orderingService;

        public OrderingController(IOrderingService orderingService)
        {
      _orderingService = orderingService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<OrderingLog>> Get()
        {
            return Ok(_orderingService.GetTransferLogs());
        }
 
    }
}
