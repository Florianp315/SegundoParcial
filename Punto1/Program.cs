﻿using System;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrollar el juego “Adivina el número” en un programa de C#. El juego es muy sencillo, consiste en adivinar un número ℕ aleatorio que el sistema escoge de un determinado rango y lo guarda en memoria sin ser revelado.

            //Declaracion de Variable
            int numeroAdivinar;
            int numeroIntentos;
            int numJugadores;
            int numeroIngresado;
            int min, max;
            string respuesta;


            Random random= new Random();
            bool jugarOtravez = true;

                //Introduccion

                while (jugarOtravez) 
            {
                Console.WriteLine("Bienvenido(a) al juego adivina el numero!!");

                Console.WriteLine("Ingresa el numero de jugadores (Valido entre 2 y 4):");
                numJugadores = int.Parse(Console.ReadLine());

                // Determinar los rangos de numero segun la cantidad de jugadores

                if (numJugadores == 2)
                {
                    min = 0; max = 50;

                }

                else if (numJugadores == 3)
                {
                    min = 0; max = 100;
                }

                else if(numJugadores == 4)
                {
                    min = 0; max=200;
                }

                else
                {
                    Console.WriteLine("no esta permitido este numero de jugadores ");

                }

                numeroAdivinar = random.Next(min, max);
                numeroIntentos = 0;


                Console.WriteLine("Numero Aleatorio generado ¡Adivinen!");

                // Turno de cada jugador

                for (int numerojugador = 1; numerojugador <= numJugadores; numerojugador++)
                {
                    Console.Write("jugador {numeroJugador}, ingrese su numero");
                    numeroIngresado = int.Parse(Console.ReadLine());

                    if (numeroIngresado > numeroAdivinar)
                    {
                        Console.WriteLine("MENOR");
                    }

                    else if (numeroIngresado < numeroAdivinar)
                        {
                        Console.Write("MAYOR");
                        }
                    else
                    {
                        Console.WriteLine("¡ADIVINASTE EL NUMERO, HAS GANADO!");
                    }

                    numeroIntentos++;
               
                
                
                }

                if (numeroIntentos == numJugadores)
                {
                    Console.WriteLine("Lo siento, Nadie adivino el numero. el numero era: {numeroAdivinar}");
                }
                Console.Write("¿Quieres volver a jugar? (s/n):");
            }
    }
}
