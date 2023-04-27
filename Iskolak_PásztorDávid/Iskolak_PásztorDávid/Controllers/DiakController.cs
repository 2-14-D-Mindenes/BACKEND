using Iskolak_PásztorDávid.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Iskolak_PásztorDávid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiakController : ControllerBase
    {
        [HttpPost]

        public IActionResult Post(Diakok diakok)
        {
            using (var context = new iskolakContext())
            {
                try
                {
                    context.Diakoks.Add(diakok);
                    context.SaveChanges();
                    
                    return Ok("A diák adatainak tárolása megtörtént.");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }
    }
}
