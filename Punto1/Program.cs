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
                int numJugadores = int.Parse(Console.ReadLine());

                
        }
    }
}
