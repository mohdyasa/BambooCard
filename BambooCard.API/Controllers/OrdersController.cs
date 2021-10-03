using BambooCard.Common.Exceptions;
using BambooCard.Common.OrderViewModel;
using BambooCard.Services.Order;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BambooCard.API.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService service;
        private readonly ILogger<OrdersController> logger;

        public OrdersController(IOrderService service, ILogger<OrdersController> logger)
        {
            this.service = service;
            this.logger = logger;
        }

        [HttpGet("{requestId}")]
        public async Task<IActionResult> GetOrders([FromQuery] int requestId)
        {
            logger.LogInformation($"Started Processing RequestId: {requestId} ");

            return Ok(await service.GetOrders(requestId));
        }

        [HttpPost("checkout")]
        public async Task<IActionResult> CheckOut([FromBody] OrderViewModel model)
        {
            try
            {
                logger.LogInformation($"Started Processing RequestId: {model.RequestId} ");

                return Ok(service.CreateOrder(model));
            }
            catch (DuplicateKeyException ex)
            {
                logger.LogError($"Error Processing RequestId: {model.RequestId}", ex);
                return Conflict(ex.Message);
            }
            catch (Exception ex)
            {
                logger.LogError($"Error Processing RequestId: {model.RequestId}", ex);
                return StatusCode((int)HttpStatusCode.InternalServerError, "Something went wrong");
            }
        }

    }
}
