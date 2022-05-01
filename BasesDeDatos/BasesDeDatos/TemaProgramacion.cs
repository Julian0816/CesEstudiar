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
            string[] tema = {"Un método o función... // No existe limitación a los parámetros de entrada.",
                "Los parámetros de entrada no son siempre opcionales. // Falso",
                "Los métodos y funciones no pueden llamarse a si mismos en su código. // Falso",
                "Existe una limitación en el número de comandos return que una función puede usar. // Falso",
                "El uso de métodos y funciones hace que el programa sea más fácil de leer e interpretar. // Verdadero",
                "Indicar la visibilidad de los métodos y funciones es algo opcional. // Verdadero",
                "Un método llamado ej1 que tiene un parámetro de entrada de tipo float se le puede llamar? // Siempre y cuando le demos un valor al parámetro de entrada.",
                "No hay limitación al número de llamadas a una función en un programa. // Verdadero",
                "Un método tipificado? // Debe retornar siempre un valor del tipo del método.",
                "Decimos que un método está tipificado cuando al terminar devuelve algún valor del tipo declarado. // Verdadero"};

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
            string[] tema = {"Cuando hacemos una captura de requisitos... // Debemos tratar de buscar el diseño más eficiente.",
                "El análisis de requisitos // Consiste en la localización de las necesidades de nuestro proyecto.",
                "Existen dos tipologías de errores que se pueden producir al programar. // Falso",
                "Es mejor añadir parámetros siempre a usar valores fijos cuando programamos. // Verdadero",
                "Una mala captura de requisitos puede suponer repetir trabajo. // Verdadero",
                "La metodología de diseño de 4 reglas puede resumirse en... // Datos, inicialización, desarrollo y repetición.",
                "Un análisis de requisitos siempre debería... // Cubrir al menos el 50% del tiempo de desarrollo o más.",
                "Los errores tipo semánticos no permiten ejecutar nuestro programa. // Falso",
                "Al realizar una captura de requisitos es conveniente que... // Creemos cuanto más documentación, mejor.",
                "Una captura de requisitos la realizamos simplemente preguntándonos qué necesitamos y cómo vamos a conseguirlo. // Verdadero"};

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
            string[] tema = {"El tamaño de un array es fijo y no cambiará aunque borremos datos. // Verdadero",
                "Que puedes decir de la siguiente línea de código: miArray[miArray.Lenght] = 5; Que la asignación dará error, ya que el índice indicado no existe.",
                "Los arrays no son nativos de C#. Se necesita una librería como el System para poderlos usar. // Falso",
                "Las estructuras tipo array son en realidad una tabla con una sola dimensión o fila. // Verdadero",
                "Un array es una colección de datos de diversos tipos // Falso",
                "Los arrays no pueden ser de tipo bool. // Falso",
                "En las búsquedas es mejor usar la estructura For. // Falso",
                "El tipo de datos String representa una cadena de caracteres. Es también una colección de datos. // Verdadero",
                "Los arrays se declaran con la sintaxis... // TipoArray[] nombreArray;",
                "Para asignar un valor dentro de un array necesitas... // El valor a asignar y un índice válido.",
                "Para poder usar un array hay que definir su tamaño. // Verdadero"};

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
            string[] tema = {"La instancia única nos asegura que no habrá más de una copia de una clase por área de trabajo. // Verdadero",
                "¿La instancia única requiere de usar qué método específico del sistema? // Awake",
                "La instancia única nos asegura que no habrá más de dos copias de una clase por área de trabajo. // Falso",
                "Podemos crear tantas copias de un objeto como queramos. // Verdadero",
                "Un objeto sólo puede tener un componente asociado.  // Falso",
                "El this es un puntero al objeto que lleva el script que lo ejecuta. // Verdadero",
                "La herencia permite que la clase hija herede métodos y atributos de la clase padre. // Verdadero",
                "¿Qué puedes decir de la siguiente línea de código: GameObject miGO = GameObject.Find(??);? // Es correcta y buscará un objeto sin nombre, por lo que siempre devolverá null.",
                "Los punteros no borran los objetos a los que apuntaban cuando pasan a apuntar a null. // Verdadero",
                "Con la palabra reservada extends... // Podemos aplicar polimorfismo a nuestras clases."};

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
            string[] tema = {"Las matrices deben ser siempre rectangulares. // False",
                "¿Cual de los siguientes pares de valores enteros no es válido como índices de una matriz? // El par (0,-1)",
                "public String[,] matrizStr = new String[3,3]; MatrizStr[1,1] = 'manzana'; MatrizStr[0,0] = 'uva'; MatrizStr[2,2] = 'pera'; //¿Que valor tiene la posición [0,1]? // (Cadena vacía).",
                "No siempre es necesario conocer todos los índices para acceder a un elemento de una matriz. // Felse",
                "String[,] miMatriz; miMatriz[0,0] = ?10?; //¿Que representa este código? // El código es incorrecto, la matriz no tiene tamaño.",
                "Las matrices no son más que arrays de dos dimensiones. // True",
                "Las matrices o tableros son elementos nativos de los lenguajes de programación, no necesitan importar librerías. // True",
                "int[,] miMatriz = new Int[3,3]; //¿Que representa este código? // Declaro una matriz de números enteros de dimensiones 3 por 3.",
                "int[,] miMatriz = new float[3,3]; //¿Que representa este código? // El código es incorrecto, incompatibilidad de tipos.",
                "Las matrices creadas como arrays de arryas... // Deben inicializarse cada columna de manera individual."};

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