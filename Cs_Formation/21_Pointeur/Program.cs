﻿using System;

namespace _21_Pointeur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Les pointeurs");

            // TODO Faire une fonction diviser. qui retourne le quotient et le rest.
            // * Déclaration du pointeur
            // & adresse de la variable du pointeur



            //FonctionDivision(int a, int b)
            FonctionDivision(5 / 3);

        }


        public int FonctionDivision(int &a, int &b)
        {
            int a = 0;
            int b= 0;
            int result = 0;

            *result = a / b;

            return result;
        }


      
    }
}
