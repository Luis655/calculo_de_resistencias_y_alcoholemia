using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
//UNIVERSIDAD TECNOLOGICA METROPOLITANA
//DESARROLLO DE SOFTWARE MULTIPLATAFORMA--DSM--TIC
//PARCIAL 2
//PRACTICA 2 Y 3 RESISTENCIA Y ALCOHOLEMIA
//LUIS ALBERTO MACIAS HAU
//MTRO.JOEL IVAN CHUC UC
//APLICACIONES WEB ORIENTADA A SERVICIOS

//PRACTICA 1 RESISTENCIAS
//https://localhost:5001/api/Resisyalco/Resistencia
        //{"banda1":"negro", "banda2":"azul", "banda3":"naranja", "banda4":"plata"}

//PRACTICA 2 ALCOHOLEMIA
//https://localhost:5001/api/Resisyalco/alcohol
        //caso 1
       // {"nombrebebida":"cerveza", "numerodebebidas":"3", "mldelabebidatotal":"380", "edadsujeto":"34", "pesosujeto":"80"}
       //caso 2
       // {"nombrebebida":"cerveza", "numerodebebidas":"", "mldelabebidatotal":"380", "edadsujeto":"34", "pesosujeto":"80"}
       //caso 3
       // {"nombrebebida":"cerveza", "numerodebebidas":"3", "mldelabebidatotal":"", "edadsujeto":"34", "pesosujeto":"80"}

namespace LightHistory.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
