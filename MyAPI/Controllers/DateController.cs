using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyAPI.DTO.Account;
using MyAPI.Models;
using MyAPI.Services;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DateController : ControllerBase
    {
        public DateController()
        {
        }

        [HttpGet]
        public async Task<ActionResult<DateTime>> GetDate()
        {
            return Ok(await Task.FromResult(DateTime.UtcNow));
        }
    }
}
