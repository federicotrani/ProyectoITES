using System;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
          int variableEntera=18;
          char variableCaracter='a';
          string variableCadena = "Hola";
          bool variableLogica = true;
          float variableFlotante = 12.25f;
          string mensaje;

          string opcion;

          Console.Clear();

          Console.WriteLine("Mostrar variable Entera: {0}", variableEntera);
          Console.WriteLine("Mostrar variable Cadena: {0}", variableCadena);

          if( variableEntera<=18 ){
            Console.WriteLine("La variable es menor o igual");
          }else{

            Console.WriteLine("La variable es mayor");
            if(variableEntera==18){
              Console.WriteLine("La variable es igual");
            }
          }

          
          System.Console.WriteLine("R- Si desea restar");
          System.Console.WriteLine("S- Si desea sumar");
          System.Console.WriteLine("D- Si desea dividir");
          System.Console.WriteLine("M- Si desea multiplicar");
          System.Console.WriteLine("X- Finalizar Programa");

          opcion = Console.ReadLine();

          switch(opcion){
            case "S":            
              System.Console.WriteLine("SUMA");

              break;
            case "R":
              System.Console.WriteLine("RESTA");
              break;
            case "D":
              System.Console.WriteLine("DIVISION");
              break;
            case "M":
              System.Console.WriteLine("MULTIPLICACION");
              break;
            default:
              System.Console.WriteLine("NO es un numero valido");
              break;
          }

          mensaje = variableEntera>=18? "Es mayor de edad" : "Es menor de edad";

          System.Console.WriteLine(mensaje);

          // limpiamos la pantalla 
          // mostramos un comentario
          // Console.WriteLine("Hola ITES");

          Console.WriteLine("presione una tecla para finalizar...");
          Console.ReadKey();
        }
    }
}
