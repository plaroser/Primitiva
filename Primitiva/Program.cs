using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int[] numeros = new int[6];
            String salida="";
            //Proceso
            numeros = rellenarValores(numeros);
            foreach(int valor in numeros)
            {
                salida += valor + " ";
            }
            //Salida
           Console.WriteLine("........╔══█▀■▄▄▄▄▄▄▄▄▄■▀█══╗......\n........║....█.........█....║......\n........╚╗..█...........█..╔╝......\n.........╚═█.............█═╝.......\n............▀■▄......▄■▀...........\n...............▀█...█▀.............\n................▄█.█▄..............\n........╔═════▀▀▀▀▀▀▀▀════╗........\n........║....PRIMITIVA....║........\n........║.................║........\n........╚═════════════════╝........\n");
            Console.WriteLine("La combinacion ganadora de hoy es:");
            Console.WriteLine(salida);


            


        }
        static int[] rellenarValores(int[] numeroARellenar)
        {
            //Declaracion de variables
            Boolean coincide;
            Random rnd = new Random();
            for (int i = 0; i < numeroARellenar.Length; i++)
            {
                //Rellenar todo el array
                coincide=false;
                //Bucle mientras que sea igual a algun valor anterior
                do
                {
                    //Posicion del array es un numero aleatorio
                    numeroARellenar[i] = rnd.Next(0, 60);
                    //Comprobar que lor valores anteriores no hay ninguno igual
                    for(int j = 0; j < i||coincide; j++)
                    {
                        //En el caso que encuentra uno igual da true y se termina el bucle
                        if (numeroARellenar[i] == numeroARellenar[j])
                        {
                            coincide=true;
                        }
                    }
                } while (coincide);
            }
            //Devuelve el array relleno
            return numeroARellenar;
        }

    }
}
