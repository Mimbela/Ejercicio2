using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fecha fecha1 = new Fecha();
            Console.WriteLine("FECHA 1");
            fecha1.PrintFecha();

            Fecha fecha2 = new Fecha(29, 3, 1985);
            Console.WriteLine("FECHA 2");
            fecha2.PrintFecha();


            fecha1.ModificarFecha(15, 10, 2016);
            Console.WriteLine("FECHA 1 Modificada");
            fecha1.PrintFecha();

            Console.WriteLine("FECHA 1 Mes en palabra");
            fecha1.PrintFechaMesPalabra();

            Console.WriteLine("FECHA 2 Mes en palabra");
            fecha2.PrintFechaMesPalabra();



            Console.Read();
        }
    }
}

//EJERCICIO 2
//Define la clase Fecha, de acuerdo con las siguientes especificaciones:
//Atributos:
//• día
//• mes
//• año
//Constructores:
//• Que inicialice con una fecha fija que tú definas
//• Que reciba como parámetro los valores para inicializar la fecha
//Métodos públicos:
//• Que permita modificar el valor de la fecha
//• Que muestre en la pantalla la fecha usando el formato dia / mes / año
//• Que muestre en la pantalla la fecha poniendo el mes con palabras.
//Realiza después una aplicación para probar tu clase, debe al menos crear 2 objetos de tipo Fecha, utilizando cada uno de los constructores y después mostrar las fechas correspondientes en la pantalla, modificar la primera y volver a imprimir los meses en letra de las dos.
