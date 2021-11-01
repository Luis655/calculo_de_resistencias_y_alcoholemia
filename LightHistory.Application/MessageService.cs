using System.Net.Mime;
using System;
using LightHistory.Infrastructure;
using LightHistory.Domain.DatosResistencia;
using LightHistory.Domain.Alcoholemia;



namespace LightHistory.Application
{
    public class MessageService
    {
        public string enviardatosresis(Resistencia resistencia)
        {
        var repo = new mensagedatosresyalc();
        var repo2 = repo.mensajeresistencia(resistencia);
        return repo2;
        }






        public string enviardatosalco(Alcoholemia alcoholemia)
        {
            string mensajealcohol="";
            string mensaje="";
        var repo = new mensagedatosresyalc();
        var repo2 = repo.mensajealcoholemia(alcoholemia);

        if (repo2 >= 0.86)
        {
            mensajealcohol = "En este momento NO ESTA CALIFICADO para conducir ya que su nivel de"
            + $" alcohol es de {repo2}, SUPERIOR AL PERMITIDO POR LA LEY";
        }
        else
        {
            mensajealcohol = "En este momento SI ESTA CALIFICADO para conducir ya que su nivel de"
            + $" alcohol es de {repo2}, DEBAJO DEL LIMITE IMPUESTO POR LA LEY";
        }

        mensaje ="puedes calcular la alcoholemia omitiendo la cantidad en ml de tu bebida, la api tomara la medida"
        + " estandar de la bebida que hayas elegido en ml, tambien puedes poner la cantidad de bebidas y"
        +" la cantidad en ml de la bebida seleccionada o puedes poner directamente la cantidad total" 
        + " que hayas consumido.";

        return $"{mensaje} " 
        + "/**********************************/"
        + $" {mensajealcohol}";


         
        }
        
    }
}

