using System;
namespace BasesDeDatos
{
    public class TemaProgramacion
    {
        public void LlamarQuestionario1()
        {
            string[] tema = {"Un archivo se expresa en bytes. Verdadero",
                "Un sistema de informacion se corresponde de datos, harware y software",
                "Monotorizacion, Recuperacion, Administracion son funciones del SGBD",
                "Es Redis una base de datos? si!",
                "Un archivo se caracteriza por un nombre y una ruta. Si!",
                "Los sistemas de informacion ayudan a recuperar informacion relevante. Verdadero",
                "Son sistemas de DB relacional: MySQL, MariaDB, SQLite / No relacionales: MongoDB",
                "El objetivo de un sistema de informacion es producir informacion valida para la posterior toma de decisiones. Verdadero",
                "Ventajas de un SGBD: Integridad, Seguridad, Eficiencia - Desventajas: Rapidez",
                "Es un SGBD es seguro? Si"};

            for (int i = 0; i < tema.Length; i++)
            {
                Random r = new Random();
                int index = r.Next(tema.Length);
                Console.WriteLine($"Pregunta: {tema[index]}");
                break;
            }
            Console.WriteLine("-------------");
            Console.WriteLine("got it? (y/n)");
            string respuesta = Console.ReadLine();
            Console.WriteLine("-------------");


            if (respuesta == "y")
            {
                LlamarQuestionario1();
            }
            else if(respuesta =="n")
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
               

            }
        }
    }
}