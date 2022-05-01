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
            string[] tema = {"Cuál de los siguientes no es un entorno de desarrollo online // XCode",
                "El JRE (Java Runtime Enviroment) // Es el software utilizado por los usuarios",
                "El IDE Netbeans está escrito en lenguaje // Java",
                "Las aplicaciones para iOS ... // Se pueden desarrollar de forma gratuita",
                "ablando de desarrollo ¿Qué significa el acrónimo RAD? // Rapid Application Development",
                "Cuando hablamos de la depuración de un programa nos referimos a // al proceso de identificación y corrección de erroes",
                "El concepto/herramienta de punto de interrupción o breakpoint pertenece a la fase de // Depuracion",
                "Para qué es necesario el JDK // Para el desarrollo de apliaciones Java",
                "¿Cuál de los siguientes elementos NO forma parte de un IDE? // EJECUTOR (Si froman parte: Editor, depurador, compilador)",
                "Qué resultado nos da el comando jar -tvf archivo.jar // Nos permite ver el contenido del fichero archivo.jar",
                "La Java Virtual Machine (JVM) // es capaz de ejecutar el mismo programa java sea cual sea la máquina anfitriona",
                "El resultado de ejecutar el comando 'javac -version' nos indica // que ya está instalado el JDK",
                "Xcode es la herramienta para realizar aplicaciones para dispositivos: // Apple",
                "La herramienta que extrae los textos y comentarios del código fuente en Java y los transforma en páginas web es // javadoc",
                "Cuando hablamos de JAR nos referimos a ? // Java ARchive. Tipo de archivo que permite ejecutar aplicaciones escritas en lenguaje Java",
                "JDT // Java Development Toolkit",
                "Qué significan las siglas EPL? // Eclipse public license",
                "¿Qué conseguimos al ejecutar el comando jar cf HolaMundo.jar HolaMundo.class? // Crea el fichero HolaMundo.jar a partir de la clase HolaMundo.class",
                "El IDE Xcode tiene versiones para qué sistemas operativos // MacOs",
                "Para ejecutar un programa Java, es necesario tener el JDK // Falso"
            };

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
            string[] tema = {"Marca la afirmación correcta // Las pruebas de caja blanca conocen y tienen en cuenta el código. Mientras que las de caja negra lo desconocen y sólo prueban la interfaz.",
                "¿Qué es MD5? // Es un algoritmo de reducción criptográfico que sirve para saber si una información ha sido modificada",
                "¿Qué es una RTF? // Revision Tecnica Formal",
                "¿Cuál de las siguientes no es una métrica de calidad del software? // Tiempo de entrega o Lead Time (Lo son: Número de errores por línea de código, Número de revisiones realizadas a un módulo, Rendimiento o Throughput)",
                "Sahi es una herramienta para // Testear aplicaciones web",
                "¿Cuál de los siguientes elementos no suele formar parte de un caso de pruebas? // IDE utilizado",
                "Habitualmente se encargan de hacer las pruebas // Personal independiente del equipo de desarrollo",
                "Es importante que el diseño de las pruebas sea lo suficientemente complejo para que nos aporte información de interés, pero no tanto como para que el coste de detección de los errores sea muy alto // True",
                "La documentación de las pruebas // Es importantísima para el correcto desarrollo de las mismas",
                "Es preferible repetir las mismas pruebas a realizar pruebas diferentes // False",
                "¿Por qué se caracteriza una prueba de clases de equivalencia de datos? // Por el uso de clases de entrada válidos y no válidos",
                "¿Qué es un caso de prueba? // Conjunto de entradas, condiciones y salidas esperadas diseñadas para un objetivo concreto",
                "El objetivo de las pruebas de software es // Detectar errores, analizar el rendimiento, comprobar la apariencia y el cumplimiento de determinadas características",
                "¿Qué significan las siglas SQA? // Software Quality Assurance",
                "Es una prueba de caja negra // De Interfaces",
                "Las pruebas de valores límite // Son imprescindibles durante el desarrollo y testeo del software",
                "¿Cuál de los siguientes aspectos no forma parte de un plan de pruebas? // Recogida de requisitos del software",
                "El hecho de que un software supere todas las pruebas realizadas sobre él nos indica que está libre de errores // False",
                "Es una prueba de caja blanca // De cubrimiento",
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