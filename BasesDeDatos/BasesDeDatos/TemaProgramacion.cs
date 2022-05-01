using System;
namespace BasesDeDatos
{
    public class TemaProgramacion
    {
        public void llamarQuestionario1()
        {
            string[] tema = {"En la programacion, la secuencia de la instrucciones - define el flujo del programa",
                "Una asignacion es una intruccion que le da un valor numerico a una variable - Falso",
                "Que podemos concluir de esta instruccion? MiVar = 5 - Se trata de una asignacion",
                "El tipo de datos string representa una cadena de caracteres - Verdadero",
                "Un metodo o funcion... - No existe limitacion a los parametros de entrada",
                "Cual de la siguientes afirmaciones se aplica a las variables globales - Son variables por al menos todo el script donde son declaradas",
                "Un parametro de entrada solo es visible en el metodo que lo define - Verdadero",
                "El predicado logico siguiente </br>(! Verdadero && varBool) vale... Siempre falso",
                "Que es un float en programacion? - Un tipo de tados simple",
                "En programacion no se permite mezclar variables de distinto tipos de datos - Verdadero"};

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
            string[] tema = {"If (puntos !=10) { MuertePlayer(); } // Si puntos es distinto de 10 ejecuta MuertePlayer().",
                "La estructura Switch... // Es equivalente a una gran cantidad de ifs anidados con predicados de igualdad.",
                "No podemos anidar más de tres instrucciones If. // Falso",
                "No debe usarse la sentencia Switch si puede evitarse. // Falso",
                "If (puntos >10) { DesbloqueaTrofeo(); } // Este código debloquea un trofeo si la variable puntos vale más que 10.",
                "No es necesario usar el caso Default si no lo necesitamos al codificar un Swith. // Verdadero",
                "La sentencia Switch es equivalente a anidar una sentencia de comparación if para cada caso. // Verdadero",
                "Los ifs se representan en los diagramas de flujo UML con un rombo. // Verdadero",
                "Los ifs consecutivos sin anidar se ejecutan unos detrás de otros. // Verdadero",
                "Un if else if no pude concatenarse de nuevo con otro elseif. // Falso"};

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
            string[] tema = {"El predicado lógico de un While es el siguiente:<br/>(! Verdadero && varBool) vale... // Siempre Verdadero.",
                "Un Do While siempre ejecuta su código al menos una vez. // Verdadero",
                "Para usar un While necesitas? // asegurarte de que el código que cicla alguna vez niega la condición.",
                "Un While repite ciclo cuando su condición (predicado lógico) es verdadero. // Verdadero",
                "El predicado lógico de un For es el siguiente:<br/>(! Verdadero || varBool) vale... // Depende del valor de la variable varBool.",
                "La estructura For? // necesita una inicialización, una condición de terminación, y un modo de incremento.",
                "Un For repite ciclo cuando su condición (predicado lógico) es falso. // Falso",
                "Un For termina siempre. Su cantidad de ciclos está limitado. // Falso",
                "La estructura de control While es ciclica y siempre se ejecuta al menos una vez. // Falso",
                "La estructura de control For es cíclica y no sabemos cuando terminará de ciclar. // Falso"};

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
        public void llamarQuestionario7()
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
                llamarQuestionario7();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void llamarQuestionario8()
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
                llamarQuestionario8();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void llamarQuestionario9()
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
                llamarQuestionario9();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void llamarQuestionario10()
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
                llamarQuestionario10();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
    }
}