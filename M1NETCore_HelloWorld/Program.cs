using M1NETCore_HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace M1NETCore_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreCurso = ".NET Core Web con C#";
            int edad = 30;
            double monto = 550.42;

            var listado = new List<Persona>();

            var per1 = new Persona();
            per1.nombre = "Ivan Ramos";
            per1.dni = "00998877";
            per1.telefono = "417-2209";

            var per2 = new Persona()
            {
                nombre = "Luis Aguero",
                dni = "11335577",
                telefono = "323-0092"
            };

            var per3 = new Persona("44559922", "Jose Reyes", "554-0494");

            listado.Add(per1);
            listado.Add(per2);
            listado.Add(per3);

            Console.WriteLine("La cantidad de personas es: " + listado.Count);

            foreach (var item in listado)
            {
                Console.WriteLine(item.dni + " " + item.nombre + " " +item.telefono);
            }

            var busqueda = listado.Where(luis => luis.dni == "11335577").FirstOrDefault();

            Console.WriteLine("La persona encontrada es: " + busqueda.nombre);

            Console.WriteLine("Hello World! " + nombreCurso);
        }
    }
}
