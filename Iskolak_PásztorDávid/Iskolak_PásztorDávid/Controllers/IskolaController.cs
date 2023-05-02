﻿using Iskolak_PásztorDávid.Models;
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
        
        [HttpGet("getVersenyzo/{id}")]

        public IActionResult getVersenyzo( int id )
        {
            using (var context = new euroskillsContext())
            {
                try
                {
                    return Ok(context.Versenyzos.Where(f=>f.Id==id).ToList());
                }
                catch (Exception ex)
                {
                    return StatusCode(400, ex.Message);
                }
            }
        }
    }
}
