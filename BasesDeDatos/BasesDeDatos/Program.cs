using System.Collections.Generic;
using System;

namespace BasesDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para seleccionar un tema:
            //Des-comentar el tema que se quier usar.

            //Ahora mismo solo puedo usar un tema a la vez, la pregunta es como puedo cambiar de usar un solo tema, o dos a la vez
            //o tres.. o todos los temas a la vez?
            int opc = 0;
            int submenu = 0;
            do
            {
                Console.WriteLine("°-----------------------------°");
                Console.WriteLine("°         1. Bases de datos   °");
                Console.WriteLine("°         2. Programacion     °");
                Console.WriteLine("°-----------------------------°");
                Console.WriteLine("Que unidad quiere estudiar");
                opc =Convert.ToInt32(Console.ReadLine());
               
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("°-----------------------------°");
                        Console.WriteLine("°         1. tema1            °");
                        Console.WriteLine("°         2. tema2            °");
                        Console.WriteLine("°         3. tema3            °");
                        Console.WriteLine("°         4. tema4            °");
                        Console.WriteLine("°         5. tema5            °");
                        Console.WriteLine("°         6. tema6            °");
                        Console.WriteLine("°         7. tema7            °");
                        Console.WriteLine("°         8. tema8            °");
                        Console.WriteLine("°         9. tema9            °");
                        Console.WriteLine("°         10. tema10          °");
                        Console.WriteLine("°         11. tema11          °");
                        Console.WriteLine("°         12. tema12          °");
                        Console.WriteLine("°         13. tema13          °");
                        Console.WriteLine("°         14. tema14          °");
                        Console.WriteLine("°         15. Salir           °");
                        Console.WriteLine("°-----------------------------°");
                        Console.WriteLine("ingresa el tema a estudiar");
                        submenu = Convert.ToInt32(Console.ReadLine());  
                        switch (submenu)
                        {
                            case 1:
                                Temario Tema1 = new Temario();
                                Tema1.LlamarQuestionario1();
                                break;
                            case 2:
                                
                                break;
                            default:
                                Console.WriteLine(" la opcion no es valida");
                                break;     
                        }
   
                        break;
                    case 2:
                        Temario Tema2 = new Temario();
                        Tema2.LlamarQuestionario2();
                        break;
                    case 3:
                        Temario Tema3 = new Temario();
                        Tema3.LlamarQuestionario3();
                        break;
                    case 4:
                        Temario Tema4 = new Temario();
                        Tema4.LlamarQuestionario4();
                        break;
                    case 5:
                        Temario Tema5 = new Temario();
                        Tema5.LlamarQuestionario5();
                        break;
                    case 6:
                        Temario Tema6 = new Temario();
                        Tema6.LlamarQuestionario6();
                        break;
                    case 7:
                        Temario Tema7 = new Temario();
                        Tema7.LlamarQuestionario7();
                        break;
                    case 8:
                        Temario Tema8 = new Temario();
                        Tema8.LlamarQuestionario8();
                        break;
                    case 9:
                        Temario Tema9 = new Temario();
                        Tema9.LlamarQuestionario9();
                        break;
                    case 10:
                        Temario Tema10 = new Temario();
                        Tema10.LlamarQuestionario10();
                        break;
                    case 11:
                        Temario Tema11 = new Temario();
                        Tema11.LlamarQuestionario11();
                        break;
                    case 12:
                        Temario Tema12 = new Temario();
                        Tema12.LlamarQuestionario12();
                        break;
                    case 13:
                        Temario Tema13 = new Temario();
                        Tema13.LlamarQuestionario13();
                        break;
                    case 14:
                        Temario Tema14 = new Temario();
                        Tema14.LlamarQuestionario14();
                        break;
                    case 15:
                        Console.WriteLine("finalizo el estudio");
                        break;
                    default:
                        break;
                }

            } while (opc!=15);
           
           

            

            

            //Temario Tema3 = new Temario();
            //Tema3.LlamarQuestionario3();

            //Temario Tema4 = new Temario();
            //Tema4.LlamarQuestionario4();

            //Temario Temma5 = new Temario();
            //Temma5.LlamarQuestionario5();

            //Temario Tema6 = new Temario();
            //Tema6.LlamarQuestionario6();

            //Temario Tema7 = new Temario();
            //Tema7.LlamarQuestionario7();

            //Temario Tema8 = new Temario();
            //Tema8.LlamarQuestionario8();

            //Temario Tema9 = new Temario();
            //Tema9.LlamarQuestionario9();

            //Temario Tema10 = new Temario();
            //Tema10.LlamarQuestionario10();

            //Temario Tema11 = new Temario();
            //Tema11.LlamarQuestionario11();

            //Temario Tema12 = new Temario();
            //Tema12.LlamarQuestionario12();

            //Temario Tema13 = new Temario();
            //Tema13.LlamarQuestionario13();

            //Temario Tema14 = new Temario();
            //Tema14.LlamarQuestionario14();

        }
    }
}

