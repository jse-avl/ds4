﻿using System;

namespace Laboratorio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            // Ejemplo utilizando las variables de instancia de clase
            client.FirstName = "Jose";
            client.LastName = "Avila";
            client.Age = 21;
            client.ID = 1;

            Console.WriteLine(client.GetFullName());
        }
    }

    public class Client
    {
        // Declarando variables de instancia en la clase
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ushort Age { get; set; }

        public string GetFullName()
        {
            // Utilizando variables de instancia dentro de métodos de la clase
            return FirstName + " " + LastName;
        }
    }
}