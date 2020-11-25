using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VeiculosAPI.Entities;

namespace VeiculosAPI.Controllers{
    [ApiController]
    [Route("[controller]")]
    public class MotoController : ControllerBase{
        [HttpGet("{id}")]
        public virtual ActionResult<Moto> GetOne(long id){
            try{
                var moto = MotoDAO.GetMotos(id);
                return Ok(moto);
            }catch (Exception e){
                Console.WriteLine("Erro!" + e.Message);
                // return StatusCode(StatusCodes.Status500InternalServerError, "");
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // [HttpPost]
        // public ActionResult<Moto> Post(){

        // }

        // [HttpPut]
        // public ActionResult<Moto> Put(){

        // }

        // [HttpDelete]
        // public ActionResult<Moto> Delete(){

        // }
    }
}