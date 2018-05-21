using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Fecha
    {
        public int dia;
        public int mes;
        public int año;

        //constructor sin parámetros
        public Fecha()
        {
            DateTime hoy = DateTime.Now;

            dia = hoy.Day;
            mes = hoy.Month;
            año = hoy.Year;

        }
        //constructor con parámetros

        public Fecha(int d, int m, int a)
        {
            dia = d;
            mes = m;
            año = a;
        }

        public void ModificarFecha(int d, int m, int a)
        {
            dia = d;
            mes = m;
            año = a;
        }

        public void PrintFecha()
        {
            Console.WriteLine("{0}/{1}/{2}", dia, mes, año);
        }

        public void PrintFechaMesPalabra()
        {
            string[] meses = new string[] { "", "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE" };
            Console.WriteLine("{0}/{1}/{2}", dia, meses[mes], año);
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
