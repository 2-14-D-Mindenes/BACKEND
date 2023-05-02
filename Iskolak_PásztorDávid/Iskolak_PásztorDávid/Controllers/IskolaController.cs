using Iskolak_PásztorDávid.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Iskolak_PásztorDávid.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class IskolaController : ControllerBase
    {
        [HttpGet("Get")]

        public IActionResult Get()
        {
            using (var context = new iskolakContext())
            {
                try
                {
                    return Ok(context.Iskolaks.ToList());   
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }
    }
}
