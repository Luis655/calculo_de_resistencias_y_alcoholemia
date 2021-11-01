using System;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using LightHistory.Application;
using LightHistory.Domain.DatosResistencia;
using System.Threading.Tasks;
using LightHistory.Domain.Alcoholemia;


namespace LightHistory.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class ResisyalcoController : ControllerBase
    {




        [HttpPost]
        [Route("Resistencia")]
        public async Task<IActionResult> Postresistencia([FromBody] Resistencia resistencia)
        {
            var res = new MessageService();
            var repo = res.enviardatosresis(resistencia);

            

            return Ok(repo);
        }
        //datos
            //https://localhost:5001/api/Resisyalco/Resistencia
            //{"banda1":"negro", "banda2":"azul", "banda3":"naranja", "banda4":"plata"}

        
        [HttpPost]
        [Route("{alcohol}")]
        public async Task<IActionResult> Postalcoholemia([FromBody] Alcoholemia alcoholemia)
        {
            var alco = new MessageService();
            var alcoho =  alco.enviardatosalco(alcoholemia);

            return Ok(alcoho);

        }

        //https://localhost:5001/api/Resisyalco/alcohol
        //caso 1
       // {"nombrebebida":"cerveza", "numerodebebidas":"3", "mldelabebidatotal":"380", "edadsujeto":"34", "pesosujeto":"80"}
       //caso 2
       // {"nombrebebida":"cerveza", "numerodebebidas":"", "mldelabebidatotal":"380", "edadsujeto":"34", "pesosujeto":"80"}
       //caso 3
       // {"nombrebebida":"cerveza", "numerodebebidas":"3", "mldelabebidatotal":"", "edadsujeto":"34", "pesosujeto":"80"}


        




    }
}







