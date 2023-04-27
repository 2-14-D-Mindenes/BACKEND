using Iskolak_PásztorDávid.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Iskolak_PásztorDávid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IskolaLogokController : ControllerBase
    {
        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            using (var context = new iskolakContext())
            {
                try
                {
                    Iskolalogok logok = new Iskolalogok();
                    logok.Id = id;
                    context.Iskolalogoks.Remove(logok);
                    context.SaveChanges();
                    return StatusCode(200, "A logó adatainak törlése megtörtént.");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }
    }
}
