using System;
namespace BasesDeDatos
{
    public class TemaEntornoDeDesarrollos
    {
        public void llamarQuestionario1()
        {
            string[] tema = {"¿Qué lenguaje es directamente ejecutable por la computadora? // Maquina",
                "La elaboración de documentación es una pérdida de tiempo // Falso",
                "Al desarrollar una aplicación podemos prescindir de // Manual de identidad",
                "Cuál de las siguientes fases NO forman parte del desarrollo de una aplicación //Marketing (Forman parte: Analisis, pruebas y diseno)",
                "Los lenguajes de programación pueden ser (marca la incorrecta) // ULTRA BAJO NIVEL (Correctas: Bajo nivel o maquina, Nivel medio o ensamblador, ALto nivel)",
                "El software es la parte intangible o soporte lógico de un sistema informático ¿Verdadero o Falso? // Verdadero",
                "¿Qué es la criptografía? // Ciencia o Arte cuyo objetivo es hacer que un mensaje sea ininteligible a los receptores no autorizados",
                "De todos los tipos de software, ________ es el encargado de gestionar los recursos hardware de un computador // El sistema operativo",
                "Entre los roles del proceso de desarrollo de software están (selecciona la incorrecta) // Recolector de basura",
                "Con lenguajes interpretados son fases (marca la incorrecta) // Enlazado",
                "GUI es: // Acrónimo del inglés graphical user interface (interfaz gráfica de usuario)",
                "Lo más conveniente es que las pruebas de software se realicen sólo sobre el sistema completo, ya que no detectaríamos los errores en cada trozo de manera individual ¿Verdadero o Falso? // Falso",
                "Son tipos de software (marca la incorrecta) // ALU (Respuesta correcta: Sistema operativo, sofware de programacion, aplicaciones)",
                "Con lenguajes compilados son fases (marca la incorrecta) // TRADUCCION (La respuesta correcta es: Codigo fuente, compilacion, programa objeto)",
                "Cuando hablamos de POO ¿a qué nos referimos? // Programacion orientada a onjetos",
                "Java es un lenguaje (selecciona la incorrecta) // Compilado (La correcta es: Interpretado, Orientado a objetos, permite multihilos)",
                "Código objeto es el resultado de compilar el código fuente. Puede ser código máquina o bytecode // Verdadero",
                "En programación, a un conjunto de conceptos, estructuras, funciones y componentes, se le conoce como: // Framework",
                "Código ejecutable es el resultado de compilar y enlazar el código con el IDE // Falso"};

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
                llamarQuestionario1();
            }
            else if(respuesta =="n")
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
               

            }
        }
        public void llamarQuestionario2()
        {
            string[] tema = {"",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                ""};

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
                llamarQuestionario2();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void llamarQuestionario3()
        {
            string[] tema = {"",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                ""};

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
                llamarQuestionario3();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void llamarQuestionario4()
        {
            string[] tema = {"",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                ""};

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
                llamarQuestionario4();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void llamarQuestionario5()
        {
            string[] tema = {"",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                ""};

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
                llamarQuestionario5();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void llamarQuestionario6()
        {
            string[] tema = {"",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                ""};

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
                llamarQuestionario6();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
    }
}