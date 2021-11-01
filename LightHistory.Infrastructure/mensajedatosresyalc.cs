using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Runtime.Versioning;
using System;
using LightHistory.Domain.DatosResistencia;
using LightHistory.Domain.Alcoholemia;

namespace LightHistory.Infrastructure
{
    public class mensagedatosresyalc
    {

        
            
        
        public string mensajeresistencia(Resistencia resistencia)
        {
           
            string mensajebanda4 ="banda 4 correcto";
            string mensajebanda1 ="banda 1 correcto";
            string mensajebanda3 ="banda 3 correcto";
            string mensajebanda2 ="banda 2 correcto";
            double valorbanda1 =0;
            double valorbanda2 =0;
            double valorbanda3 =0;
            double valorbanda4 =0;
            double count =0;
            double valorresistencia=0;
            double total =0;
            string total2 ="";
            string valor1="";
            string valor2="";
            string valor3="";
            double valor4=0;
            double valor5=0;
            if(resistencia.banda1 == "negro" || resistencia.banda1 == "cafe" || resistencia.banda1 == "rojo" ||
                    resistencia.banda1 == "naranja" || resistencia.banda1 == "amarillo" || resistencia.banda1 == "verde"||
                    resistencia.banda1 == "azul" || resistencia.banda1 == "violeta" || resistencia.banda1 == "gris"||
                    resistencia.banda1 == "blanco"
                )
                {   
                    {   
                    switch (resistencia.banda1)
                    {
                        case "negro":
                        valorbanda2=0;
                            break;
                            case "cafe":
                            valorbanda1=1;
                            break;
                            case "rojo":
                            valorbanda1=2;
                            break;
                            case "naranja":
                            valorbanda1=3;
                            break;
                            case "amarillo":
                            valorbanda1=4;
                            break;
                            case "verde":
                            valorbanda1=5;
                            break;
                            case "azul":
                            valorbanda1=6;
                            break;
                            case "violeta":
                            valorbanda1=7;
                            break;
                            case "gris":
                            valorbanda1=8;
                            break;
                            case "blanco":
                            valorbanda1=9;
                            break;
                        default:
                        //mensajebanda1 = "error en el color de la banda 1";
                            break;
                    }
                }
                }
                else
                {
                    mensajebanda1 = "error en la banda 1";
                }

                if(resistencia.banda2 == "negro" || resistencia.banda2 == "cafe" || resistencia.banda2 == "rojo" ||
                    resistencia.banda2 == "naranja" || resistencia.banda2 == "amarillo" || resistencia.banda2 == "verde"||
                    resistencia.banda2 == "azul" || resistencia.banda2 == "violeta" || resistencia.banda2 == "gris"||
                    resistencia.banda2 == "blanco"
                )
                {   
                    switch (resistencia.banda2)
                    {
                        case "negro":
                        valorbanda2=0;
                            break;
                            case "cafe":
                            valorbanda2=1;
                            break;
                            case "rojo":
                            valorbanda2=2;
                            break;
                            case "naranja":
                            valorbanda2=3;
                            break;
                            case "amarillo":
                            valorbanda2=4;
                            break;
                            case "verde":
                            valorbanda2=5;
                            break;
                            case "azul":
                            valorbanda2=6;
                            break;
                            case "violeta":
                            valorbanda2=7;
                            break;
                            case "gris":
                            valorbanda2=8;
                            break;
                            case "blanco":
                            valorbanda2=9;
                            break;
                        default:
                        //mensajebanda2 = "error en el color de la banda 2";
                            break;
                    }
                }
                else
                {
                    mensajebanda2 = "error en la banda 2";
                }

            if(resistencia.banda3 == "negro" || resistencia.banda3 == "cafe" || resistencia.banda3 == "rojo" ||
                    resistencia.banda3 == "naranja" || resistencia.banda3 == "amarillo" || resistencia.banda3 == "verde"||
                    resistencia.banda3 == "azul"
                )
                {   
                    switch (resistencia.banda3)
                    {
                        case "negro":
                        valorbanda3=1;
                            break;
                            case "cafe":
                            valorbanda3=10;
                            break;
                            case "rojo":
                            valorbanda3=100;
                            break;
                            case "naranja":
                            valorbanda3=1000;
                            break;
                            case "amarillo":
                            valorbanda3=10000;
                            break;
                            case "verde":
                            valorbanda3=100000;
                            break;
                            case "azul":
                            valorbanda3=1000000;
                            break;
                        default:
                        //mensajebanda3="error en el color de la banda 3";
                            break;
                    }
                }
                else
                {
                    mensajebanda3 = "error en la banda 3";
                }

                 if(resistencia.banda4 == "dorado" || resistencia.banda4 == "plata")
                      {
                            switch (resistencia.banda4)
                            {
                                case "dorado":
                                valorbanda4 = .05;
                                    break;
                                    case "plata":
                                    valorbanda4 = .10;
                                    break;
                                default:
                            // valorbanda4 = 0;
                                    break;
                            }
                            
                        }
                        else
                        {
                            mensajebanda4= "error en el color de la banda 4";
                        }

                    valor1 = Convert.ToString(valorbanda1);
                    valor2 = Convert.ToString(valorbanda2);
                    valor3 = $"{valorbanda1}"+$"{valorbanda2}";
                    count = Convert.ToDouble(valor3);
                    valorresistencia =count * valorbanda3;
                    total = valorresistencia * valorbanda4;
                    valor4 = valorresistencia+total;
                    valor5 =valorresistencia-total;

                    if (mensajebanda1!="banda 1 correcto" || mensajebanda2!="banda 2 correcto" || mensajebanda3!="banda 3 correcto" 
                    || mensajebanda4!="banda 4 correcto")
                    {
                        return $"{mensajebanda1} " + $"{mensajebanda2} " + $"{mensajebanda3} " + $"{mensajebanda4} ";
                    }else
                    {
                        total2 = $"el valor tolal en ohms es de {valorresistencia} Ω y su resistencia es de {total} Ω, entonces el total es de"+ 
                        $" +- {total}, entonces el valor real de la resistencia es igual a {valor4} Ω o {valor5} Ω";
                        return total2; 
                    }
                    
                
        }
        








        public double mensajealcoholemia(Alcoholemia alcoholemia)
        {
           double alcoholtotalml=0;
           double alcoholconsumido=0;
           double alcoholensangre=0;
           double masaetanol=0;
           double volumensangre=0;
           double alcoholemiafinal=1;

        

            
            switch (alcoholemia.nombrebebida)
            {
                    case "cerveza":

                        if (alcoholemia.numerodebebidas!="")
                        {
                            if(alcoholemia.mldelabebidatotal != "")
                            {
                                alcoholtotalml = Convert.ToDouble(alcoholemia.numerodebebidas)*Convert.ToDouble(alcoholemia.mldelabebidatotal);

                                alcoholconsumido = alcoholtotalml*0.05;
                                alcoholensangre = alcoholconsumido * 0.15;
                                masaetanol = 0.789 * alcoholensangre;
                                volumensangre = 0.08 * Convert.ToDouble(alcoholemia.pesosujeto);
                                alcoholemiafinal = masaetanol/volumensangre;
                            }
                            else
                            {
                                alcoholtotalml =Convert.ToDouble(alcoholemia.numerodebebidas)*330;
                                alcoholconsumido = alcoholtotalml*0.05;
                                alcoholensangre = alcoholconsumido * 0.15;
                                masaetanol = 0.789 * alcoholensangre;
                                volumensangre = 0.08 * Convert.ToDouble(alcoholemia.pesosujeto);
                                alcoholemiafinal = masaetanol/volumensangre;
                            }
                            
                            
                        }
                        else
                        {
                            alcoholtotalml = Convert.ToDouble(alcoholemia.mldelabebidatotal);
                            alcoholconsumido = alcoholtotalml*0.05;
                            alcoholensangre = alcoholconsumido * 0.15;
                            masaetanol = 0.789 * alcoholensangre;
                            volumensangre = 0.08 * Convert.ToDouble(alcoholemia.pesosujeto);
                            alcoholemiafinal = masaetanol/volumensangre;
                        }
                    

                    break;




                    case "vino" or "cava":
                        if (alcoholemia.numerodebebidas!="")
                        {
                            if(alcoholemia.mldelabebidatotal != "")
                            {
                                alcoholtotalml = Convert.ToDouble(alcoholemia.numerodebebidas)*Convert.ToDouble(alcoholemia.mldelabebidatotal);

                                alcoholconsumido = alcoholtotalml*0.12;
                                alcoholensangre = alcoholconsumido * 0.15;
                                masaetanol = 0.789 * alcoholensangre;
                                volumensangre = 0.08 * Convert.ToDouble(alcoholemia.pesosujeto);
                                alcoholemiafinal = masaetanol/volumensangre;
                            }
                            else
                            {
                                alcoholtotalml =Convert.ToDouble(alcoholemia.numerodebebidas)*100;
                                alcoholconsumido = alcoholtotalml*0.12;
                                alcoholensangre = alcoholconsumido * 0.15;
                                masaetanol = 0.789 * alcoholensangre;
                                volumensangre = 0.08 * Convert.ToDouble(alcoholemia.pesosujeto);
                                alcoholemiafinal = masaetanol/volumensangre;
                            }
                            
                            
                        }
                        else
                        {
                            alcoholtotalml = Convert.ToDouble(alcoholemia.mldelabebidatotal);
                            alcoholconsumido = alcoholtotalml*0.12;
                            alcoholensangre = alcoholconsumido * 0.15;
                            masaetanol = 0.789 * alcoholensangre;
                            volumensangre = 0.08 * Convert.ToDouble(alcoholemia.pesosujeto);
                            alcoholemiafinal = masaetanol/volumensangre;
                        }


                    break;
                    case "vermu":
                        if (alcoholemia.numerodebebidas!="")
                        {
                            if(alcoholemia.mldelabebidatotal != "")
                            {
                                alcoholtotalml = Convert.ToDouble(alcoholemia.numerodebebidas)*Convert.ToDouble(alcoholemia.mldelabebidatotal);

                                alcoholconsumido = alcoholtotalml*0.17;
                                alcoholensangre = alcoholconsumido * 0.15;
                                masaetanol = 0.789 * alcoholensangre;
                                volumensangre = 0.08 * Convert.ToDouble(alcoholemia.pesosujeto);
                                alcoholemiafinal = masaetanol/volumensangre;
                            }
                            else
                            {
                                alcoholtotalml =Convert.ToDouble(alcoholemia.numerodebebidas)*70;
                                alcoholconsumido = alcoholtotalml*0.17;
                                alcoholensangre = alcoholconsumido * 0.15;
                                masaetanol = 0.789 * alcoholensangre;
                                volumensangre = 0.08 * Convert.ToDouble(alcoholemia.pesosujeto);
                                alcoholemiafinal = masaetanol/volumensangre;
                            }
                            
                            
                        }
                        else
                        {
                            alcoholtotalml = Convert.ToDouble(alcoholemia.mldelabebidatotal);
                            alcoholconsumido = alcoholtotalml*0.17;
                            alcoholensangre = alcoholconsumido * 0.15;
                            masaetanol = 0.789 * alcoholensangre;
                            volumensangre = 0.08 * Convert.ToDouble(alcoholemia.pesosujeto);
                            alcoholemiafinal = masaetanol/volumensangre;
                        }

                    break;
                    case "licor":
                        if (alcoholemia.numerodebebidas!="")
                        {
                            if(alcoholemia.mldelabebidatotal != "")
                            {
                                alcoholtotalml = Convert.ToDouble(alcoholemia.numerodebebidas)*Convert.ToDouble(alcoholemia.mldelabebidatotal);

                                alcoholconsumido = alcoholtotalml*0.23;
                                alcoholensangre = alcoholconsumido * 0.15;
                                masaetanol = 0.789 * alcoholensangre;
                                volumensangre = 0.08 * Convert.ToDouble(alcoholemia.pesosujeto);
                                alcoholemiafinal = masaetanol/volumensangre;
                            }
                            else
                            {
                                alcoholtotalml =Convert.ToDouble(alcoholemia.numerodebebidas)*45;
                                alcoholconsumido = alcoholtotalml*0.23;
                                alcoholensangre = alcoholconsumido * 0.15;
                                masaetanol = 0.789 * alcoholensangre;
                                volumensangre = 0.08 * Convert.ToDouble(alcoholemia.pesosujeto);
                                alcoholemiafinal = masaetanol/volumensangre;
                            }
                            
                            
                        }
                        else
                        {
                            alcoholtotalml = Convert.ToDouble(alcoholemia.mldelabebidatotal);
                            alcoholconsumido = alcoholtotalml*0.23;
                            alcoholensangre = alcoholconsumido * 0.15;
                            masaetanol = 0.789 * alcoholensangre;
                            volumensangre = 0.08 * Convert.ToDouble(alcoholemia.pesosujeto);
                            alcoholemiafinal = masaetanol/volumensangre;
                        }

                    break;
                    case "brandy":
                        if (alcoholemia.numerodebebidas!="")
                        {
                            if(alcoholemia.mldelabebidatotal != "")
                            {
                                alcoholtotalml = Convert.ToDouble(alcoholemia.numerodebebidas)*Convert.ToDouble(alcoholemia.mldelabebidatotal);

                                alcoholconsumido = alcoholtotalml*0.38;
                                alcoholensangre = alcoholconsumido * 0.15;
                                masaetanol = 0.789 * alcoholensangre;
                                volumensangre = 0.08 * Convert.ToDouble(alcoholemia.pesosujeto);
                                alcoholemiafinal = masaetanol/volumensangre;
                            }
                            else
                            {
                                alcoholtotalml =Convert.ToDouble(alcoholemia.numerodebebidas)*45;
                                alcoholconsumido = alcoholtotalml*0.38;
                                alcoholensangre = alcoholconsumido * 0.15;
                                masaetanol = 0.789 * alcoholensangre;
                                volumensangre = 0.08 * Convert.ToDouble(alcoholemia.pesosujeto);
                                alcoholemiafinal = masaetanol/volumensangre;
                            }
                            
                            
                        }
                        else
                        {
                            alcoholtotalml = Convert.ToDouble(alcoholemia.mldelabebidatotal);
                            alcoholconsumido = alcoholtotalml*0.38;
                            alcoholensangre = alcoholconsumido * 0.15;
                            masaetanol = 0.789 * alcoholensangre;
                            volumensangre = 0.08 * Convert.ToDouble(alcoholemia.pesosujeto);
                            alcoholemiafinal = masaetanol/volumensangre;
                        }
                    break;

                    case "convinado":
                        if (alcoholemia.numerodebebidas!="")
                        {
                            if(alcoholemia.mldelabebidatotal != "")
                            {
                                alcoholtotalml = Convert.ToDouble(alcoholemia.numerodebebidas)*Convert.ToDouble(alcoholemia.mldelabebidatotal);

                                alcoholconsumido = alcoholtotalml*0.38;
                                alcoholensangre = alcoholconsumido * 0.15;
                                masaetanol = 0.789 * alcoholensangre;
                                volumensangre = 0.08 * Convert.ToDouble(alcoholemia.pesosujeto);
                                alcoholemiafinal = masaetanol/volumensangre;
                            }
                            else
                            {
                                alcoholtotalml =Convert.ToDouble(alcoholemia.numerodebebidas)*50;
                                alcoholconsumido = alcoholtotalml*0.38;
                                alcoholensangre = alcoholconsumido * 0.15;
                                masaetanol = 0.789 * alcoholensangre;
                                volumensangre = 0.08 * Convert.ToDouble(alcoholemia.pesosujeto);
                                alcoholemiafinal = masaetanol/volumensangre;
                            }
                            
                            
                        }
                        else
                        {
                            alcoholtotalml = Convert.ToDouble(alcoholemia.mldelabebidatotal);
                            alcoholconsumido = alcoholtotalml*0.38;
                            alcoholensangre = alcoholconsumido * 0.15;
                            masaetanol = 0.789 * alcoholensangre;
                            volumensangre = 0.08 * Convert.ToDouble(alcoholemia.pesosujeto);
                            alcoholemiafinal = masaetanol/volumensangre;
                        }
                    break;
                    
            }
            
            

            return alcoholemiafinal;
        }

    }
}

