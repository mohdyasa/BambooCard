using BambooCard.Common.Exceptions;
using BambooCard.Services.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class AccountController : ControllerBase
    {
        private readonly IAccountService service;

        public AccountController(IAccountService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAccounts()
        {
            try
            {
                return Ok(await service.GetAccounts());
            }

            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError,"Something went wrong");
            }
        }
    }
}
