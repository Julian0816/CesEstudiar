using System;
namespace BasesDeDatos
{
    public class TemaSistemasInformaticos
    {
        public void LlamarQuestionario1()
        {
            string[] tema = {"Cuando nos referimos a dispositivos de entrada. // Teclado, raton, pantalla tactil, tableta dijitalizadora, USB ",
                "¿Cuál de las siguientes afirmaciones es INCORRECTA! en relación a los tres elementos básicos de la unidad central de procesamiento (CPU)? // Unidad aritmético lógica (ALU), Registro de datos, Buses de E/S (LA CORRECTA ES: Unidad aritmético lógica (ALU), Registro de datos, Unidad de Control)",
                "¿Cuando hablamos de código máquina?? // Las instrucciones están formadas por cadenas de 0 y 1",
                "Señala la respuesta INCORRECTA sobre el tipo de software llamado Freeware // Es un tipo de software libre (lA CORRECTA ES: No es un tipo software libre)",
                "Cuando hablamos de memoria RAM, nos referimos a? // Cada celda es una unidad de información llamado bit",
                "Señala la respuesta INCORRECTA sobre la división del software de Sistema // Sistema operativo, Software de programación, Software de apliación (LA CORRECTA ES: Sistema operativo, Programas unitarios, controladores de dispositivo)",
                "¿Cuál de los siguientes aspectos NO ES CORRECTO cuando hablamos de memoria principal (RAM)? // Es un tipo de memoria la cual sólo se puede escribir una vez en ella",
                "¿Cuál es el sistema habitual de representación de la numeración para las personas? // Decimal",
                "¿El tipo de memoria SDRAM y DRAM a que tipo de memoria pertenece? // RAM",
                "¿Cuando hablamos de Northbride, nos referimos a?? // Hace de puente de enlace entre el microprocesador y la memoria además de las tarjetas gráficas o de vídeo AGP o PCI-Express, así como las comunicaciones con el puente sur."};

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
        public void LlamarQuestionario2()
        {
            string[] tema = {"Los sistemas de archivos multiusuario (SOMU) // Permiten proveer servicio y procesamiento a múltiples usuarios simultáneamente",
                "¿Qué tipo de sistema de archivos utiliza UNIX/LINUX? // EXT",
                "¿Cuál es el sistema habitual de representación de la numeración para las personas? // Decimal",
                "¿Cuando hablamos del sistema operativo? // Su núcleo kernel está basado en LINUX",
                "¿Cuando nos referimos a tipo de sistema de archivos exFAT? RESPONDE LA RESPUESTA INCORRECTA. Es compatible sólo con sistemas operativos Windows",
                "¿Cuando hablamos de sistema de archivos FAT32? // Tiene un límite de 4GB por archivo",
                "Cuál de los siguientes tipos sistema de archivos NO ES CORRECTO! cuando hablamos sistema de archivos MS-DOS y Windows? // FAT, FAT32, HFS+, APFS, EXT4 (EL CORRECTO ES: FAT, FAT32, NTFS, exFAT,) ",
                "¿Cuál es la cantidad de memoria RAM que puede gestionar un sistema operativo de 32 bits? // 4GB",
                "¿Cuáles son los recursos que maneja un sistema operativo? // Información, periféricos de E/S, memoria, procesador",
                "SENALA LA RESPUESTA INCORRECTA!: ¿Cuando hablamos del sistema operativo UBUNTU, nos referimos? // A un sistema operativo diseñado por Microsoft, el cual es de código cerrado (LA CORRECTA ES: A un sistema operativo diseñado por LINUX, el cual es de código abierto y gratuito)"};

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
                LlamarQuestionario2();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void LlamarQuestionario3()
        {
            string[] tema = {"¿Cuál es el estándar para Ethernet? // IEEE 802.3",
                "En las especifiaciones de un cable de par trenzado, ¿cuál es la máxima velocidad teórica? // 40 Gbps",
                "¿Cuál es el estándar para WiFi? // IEEE 802.11",
                "¿Cuántos pares y cuantos hilos contiene el cable par trenzado? // 4 pares y 8 hilos",
                "¿Una de las desventajas de un cable de par trenzado es? // Distancia",
                "¿Cuándo hablamos de medios de transmisión no guiados nos estamos refiriendo a? // Medios inalámbricos",
                "¿Cómo se denomina un cable de par trenzado apantallado? // STP",
                "¿Cuál es el componente más utilizado en las instalaciones de red? // Par trenzado",
                "¿El cable coaxial sigue siendo el standard actual en las instalaciones actuales? // Falso",
                "¿El cable de par trenzado es el más extendido actualmente en las redes de datos? // Verdadero"};

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
                LlamarQuestionario3();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void LlamarQuestionario4()
        {
            string[] tema = {"¿El software base (software de sistema) es el conjunto de programas preinstalados en un ordenador? // Verdadero",
                "Para matar un proceso a través de comandos de texto, ¿qúe comando usarías? // Taskkill",
                "¿El comando /PID:, especifica el PID del proceso que debe terminarse? // Verdadero",
                "¿Cuáles son los estados de los procesos? Señala la correcta? // Activo, preparado, bloqueado",
                "Cuando hablamos de windows update: ¿Es un tipo de?, SENALA LA INCORRECTA... // Migracion (LA CORRECTA ES: Actualizacion)",
                "¿Que versión es la más reciente de Debian?, // 11",
                "¿Cómo se llama la aplicación que nos abre el monitor de recursos? // Resmon",
                "¿Qué tipo de actualizaciones existen? // Versión, seguridad y controladores",
                "Para llevar a cabo el control de los recursos del SO a través de comandos de texto en modo ventana, ¿qué modo usarías? // CLI",
                "¿La BIOS es un software de base? // Verdadero"};

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
                LlamarQuestionario4();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void LlamarQuestionario5()
        {
            string[] tema = {"¿Cuál fue el primer modelo de ordenadores interconectados? // Centralizado",
                "¿Cómo se denomina un sistema operativo multiusuario? // SOMU",
                "¿Cuál es la definición correcta de una instalación desatendida? // Se realiza una configuración previa y a partir de ella el sistema operativo se instala automáticamente sin necesidad de interactuar por parte del usuario",
                "¿El modelo centralizado permite la transferencia de archivos a otros ordenadores? // Verdadero",
                "¿Un sistema operativo es el software básico del un ordenador? // Verdadero",
                "En entornos científicos, ¿qué modelo se usa? // Centalizado",
                "¿Señala la respuesta correcta: los sistemas de archivos multiusuario (SOMU)?? // Permite proveer servicio y procesamiento a múltiples usuarios simultáneamente",
                "Las entidades financieras, ¿qué modelo usan? // Distribuido",
                "¿Cuándo un ordenador puede ejecutar varios programa a la vez se le denomina? // Multiprogramación",
                "¿Un sistema distribuido es aquel que utiliza los recursos de un solo ordenador? // Falso"};

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
                LlamarQuestionario5();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void LlamarQuestionario6()
        {
            string[] tema = {"¿Son software de sistema los siguientes?, señala al respuesta incorrecta. // BIOS, loaders y compiladores",
                "¿El software base (software de sistema) es el conjunto de programas preinstalados en un ordenador? // Verdadero",
                "¿Cómo se denomina a un kit de desarrollo para una aplicación nativa? // Sdk",
                "¿Una aplicación web es necesario instalarla en el dispositivo móvil para ejecutarla? // Falso",
                "¿Una aplicación nativa para su ejecución haría falta conexión a internet? // Falso",
                "¿Cómo se llaman los dispositivos móviles anteriores a los smartphones? // Feature phones",
                "¿Una app calculadora que viene preinstalada en el sistema operativo del terminal se le denomina? // Aplicacion nativa",
                "¿Qué otro nombre reciben las aplicaciones? // App",
                "¿Una aplicación web se le denomina web responsiva? // Verdadero",
                "¿En que se divide el software de sistema?, SENALA LA RESPUESTA INCORRECTA. // Sistema operativo, software de programación, software de apliación (lA CORRECTA ES: Sistema operativo, programas unitarios, controladores de dispositivo)"};

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
                LlamarQuestionario6();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void LlamarQuestionario7()
        {
            string[] tema = {"¿Se puede virtualizar dentro de un S.O. MacOs un sistema operativo Windows? // Verdadero",
                "¿Una máquina virtual de sistema es aquella que emula a un ordenador parcialmente? // Falso",
                "¿Cuál es el programa más conocido de virtualización para MacOs? // Parallels",
                "¿Qué programas son los más conocidos y populares para crear máquinas virtuales? // VirtualBox y VMWare",
                "¿Cómo se llama el programa propio de microsoft para virtualizar máquinas? // HyperV",
                "¿Una máquina virtual tiene su propio disco duro, memoria, tarjeta gráfica, etc., aunque todos ellos son virtuales? // Verdadero",
                "¿Qué dos tipos de máquinas virtuales existen? // Sistema y Proceso",
                "¿Qué función principal realiza una máquina virtual? // Emulacion",
                "¿Se puede crear una máquina virtual dentro de otra máquina virtual? // Verdadero",
                "¿Debemos tener en BIOS activada la opción VT para poder virtualizar? // Verdadero"};

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
                LlamarQuestionario7();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void LlamarQuestionario8()
        {
            string[] tema = {"Si queremos instalar Windows 10 y nuestro ordenador tiene instalado 16 GB de RAM ¿Qúe arquitectura escogeremos? // x64",
                "Si tenemos Windows 7 y queremos borrarlo completamente e instalar Linux ¿Cómo se llama este proceso?, SENALA LA RESPUESTA INCORRECTA // Actualizacion (LA CORRECTA ES: Migracion)",
                "¿La partición extendida sirve para contener múltiples unidades lógicas en su interior? // Verdadero",
                "¿Cúal es el límite máximo de particiones primarias? // 4",
                "¿Cúal es el límite máximo de particiones lógicas? // 23",
                "¿Windows 10 se caracteríza por ser un entorno? // GUI",
                "Cuando vayamos a usar archivos de más de 2GB de tamaño en Windows ¿Qúe sistema de archivos escogeremos?, SENALA LA RESPUESTA INCORRECTA // FAT32 (LA CORRECTA ES: NTFS)",
                "¿Se puede crear un instalador de Windows 10 en una unidad de almacenamiento CD?, señala la respuesta incorrecta // Sí, no hay ninguna restricción de capacidad",
                "¿En la instalación de Windows 10 se puede de manera manual formatear la unidad de almacenamiento dónde vayamos a instalar el sistema operativo? // Verdadero",
                "Si tenemos Windows 7 y queremos tener Windows 10 ¿Cómo se llama este proceso? // Actualizar"};

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
                LlamarQuestionario8();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void LlamarQuestionario9()
        {
            string[] tema = {"Cuando hablamos de windows update, ¿es un tipo de? SENALA LA INCORRECTA. // Migracion (LA CORRECTA ES: Actualizacion)",
                "¿En que tres cuentas se ejecutan los servicios? // Servicio local, servicio de red y sistema.",
                "Para llevar a cabo el control de los recursos del SO a través de comandos de texto en modo ventana ¿Qué modo usarías? // CLI",
                "¿Los servicios se pueden arrancar o parar de forma manual? // Verdadero",
                "¿Cómo se llama el monitor de recursos? // Resmon",
                "¿Los servicios son programas que corren en primer plano en el SO? // Falso",
                "¿Cuáles son los estados de los procesos? // Activo, preparado, bloqueado",
                "Para matar un proceso a través de comandos de texto ¿Qúe comando usarías? // taskkill",
                "¿Podemos instalar o desistalar las aplicaciones que vienen por defecto en Windows? // Verdadero",
                "Si utilizamos el administrador de tareas para comprobar el estado de los procesos, ¿Qúe modo utilizariamos? // GUI"};

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
                LlamarQuestionario9();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void LlamarQuestionario10()
        {
            string[] tema = {"¿Cuál es la herramienta para reparar el arranque de Windows a través del modo CLI CMD? // Bootrec.exe",
                "Hablando de la jerarquía de almacenamiento, ¿cuánto más rápida es la memoria a su vez es más barata? // Falso",
                "¿Cuántos bytes dispone el sector de arranque MBR? // 512",
                "¿El master boot record (MRB) tiene relación con la secuencia de arranque del SO? // Verdadero",
                "¿Cúal es el nivel de memoria cache más rápida? SENALA LA RESPUESTA INCORRECTA // Caché L3 (LA CORRECTA ES: Caché L1)",
                "¿Cómo se llama el archivo encargado de cargar el S.O. en Bootmgr? // winload.exe",
                "¿Cómo se llama el gestor de arranque incorporado en Linux que a su vez es compatible con Windows? // GNU GRUB",
                "Cuando hablamos del la memoria cache. SENALA LA RESPUESTA INCORRECTA. // Es de gran capacidad pero muy lento en velocidad (LA RESPUESTA CORRECTA ES: Es de capacidad reducida, pero muy rápido en velocidad)",
                "¿El comando bootrec.exe /FixBoot permite reparar el arranque de Windows? // Verdadero",
                "¿Cúal es la aplicación más común del spooling? SENALA LA RESPUESTA INCORRECTA. // Servicios de red (LA CORRECTA ES: Servicios de impresión)"};

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
                LlamarQuestionario10();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void LlamarQuestionario11()
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
                LlamarQuestionario8();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void LlamarQuestionario12()
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
                LlamarQuestionario9();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void LlamarQuestionario13()
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
                LlamarQuestionario10();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void LlamarQuestionario14()
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
                LlamarQuestionario8();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void LlamarQuestionario15()
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
                LlamarQuestionario9();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void LlamarQuestionario16()
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
                LlamarQuestionario10();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void LlamarQuestionario17()
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
                LlamarQuestionario8();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void LlamarQuestionario18()
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
                LlamarQuestionario9();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void LlamarQuestionario19()
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
                LlamarQuestionario10();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void LlamarQuestionario20()
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
                LlamarQuestionario9();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
        public void LlamarQuestionario21()
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
                LlamarQuestionario10();
            }
            else
            {
                Console.WriteLine("Vuelve a revisar los apuntes");
            }
        }
    }
}