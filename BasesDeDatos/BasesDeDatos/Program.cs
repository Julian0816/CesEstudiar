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
            int submenu2 = 0;
            int submenu3 = 0;
            int submenu4 = 0;
            int submenu5 = 0;
            int submenu6 = 0;
            do
            {
                Console.WriteLine("°---------------------------------------°");
                Console.WriteLine("°         1. Bases de datos             °");
                Console.WriteLine("°         2. Programacion               °");
                Console.WriteLine("°         3. Lenguaje de Marcas         °");
                Console.WriteLine("°         4. Entornos de Desarrolos     °");
                Console.WriteLine("°         5. Sistemsa Informaticos      °");
                Console.WriteLine("°         6. FOL                        °");
                Console.WriteLine("°---------------------------------------°");
                Console.WriteLine("Que modulo quieres estudiar");
                opc =Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    //Completo
                    case 1:
                        //Bases de Datos
                        Console.WriteLine("°-------------------------------------------------------------°");
                        Console.WriteLine("°         1. tema1: Sistema de informacion                    °");
                        Console.WriteLine("°         2. tema2: Sistema gestor de base de datos           °");
                        Console.WriteLine("°         3. tema3: Tipos de bases de datos                   °");
                        Console.WriteLine("°         4. tema4: Arquitectura de una aplicacion            °");
                        Console.WriteLine("°         5. tema5: Modelo entidad-relacion                   °");
                        Console.WriteLine("°         6. tema6: Modelo relacional                         °");
                        Console.WriteLine("°         7. tema7: Creacion de tablas SQL                    °");
                        Console.WriteLine("°         8. tema8: Modificar informacion                     °");
                        Console.WriteLine("°         9. tema9: Consulta de registros                     °");
                        Console.WriteLine("°         10. tema10: MySQL                                   °");
                        Console.WriteLine("°         11. tema11: PostgreSQL                              °");
                        Console.WriteLine("°         12. tema12: Herencia                                °");
                        Console.WriteLine("°         13. tema13: Recuperacion de fallos                  °");
                        Console.WriteLine("°         14. tema14: Copias de seguridad de restauracion     °");
                        Console.WriteLine("°         30. Salir                                           °");
                        Console.WriteLine("°-------------------------------------------------------------°");
                        Console.WriteLine("Ingresa el numero del tema que quieres estudiar");
                        submenu = Convert.ToInt32(Console.ReadLine());
                        switch (submenu)
                        {
                            case 1:
                                Temario Tema1 = new Temario();
                                Tema1.LlamarQuestionario1();
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
                        break;
                    
                    //Incompleto
                    case 2:
                        //Programacion
                        Console.WriteLine("°------------------------------------------------------------------------°");
                        Console.WriteLine("°     1. tema1: Introducción a la programación                           °");
                        Console.WriteLine("°     2. tema2: Estructuras de control de flujo: condicion               °");
                        Console.WriteLine("°     3. tema3: Estructuras de control de flujo: cíclicas                °");
                        Console.WriteLine("°     4. tema4: Métodos y funciones                                      °");
                        Console.WriteLine("°     5. tema5: Diseño en programación                                   °");
                        Console.WriteLine("°     6. tema6: Estructura de datos complejas: arrays                    °");
                        Console.WriteLine("°     7. tema7: Programación orientada a objetos                         °");
                        Console.WriteLine("°     8. tema8: Estructuras de datos complejas: matrices                 °");
                        Console.WriteLine("°     9. tema9: Esctructuras de datos complejas: colecciones             °");
                        Console.WriteLine("°     10. tema10: formularios y otros elementos de interfaz de usuario   °");
                        Console.WriteLine("°     11. tema11: Estructuras de datos complejas: agrupadores            °");
                        Console.WriteLine("°     12. tema12: Eventos y listeners                                    °");
                        Console.WriteLine("°     13. tema13: Colisiones                                             °");
                        Console.WriteLine("°     14. tema14: Corrutinas                                             °");
                        Console.WriteLine("°     15. tema15: Entrada y salida de datos                              °");
                        Console.WriteLine("°     16. tema16: Informatica grafica                                    °");
                        Console.WriteLine("°     30. Salir                                                          °");
                        Console.WriteLine("°------------------------------------------------------------------------°");
                        Console.WriteLine("Ingresa el numero del tema que quieres estudiar");
                        submenu2 = Convert.ToInt32(Console.ReadLine());
                        switch (submenu2)
                        {
                            case 1:
                                TemaProgramacion Tema1 = new TemaProgramacion();
                                Tema1.LlamarQuestionario1();
                                break;
                            default:
                                break;
                        }
                        break;
                    
                    case 3:
                        //Lenguaje de Marcas
                        Console.WriteLine("°------------------------------------------------------------------------------°");
                        Console.WriteLine("° 1. tema1: Introducción a los lenguajes de marcas HTML                        °");
                        Console.WriteLine("° 2. tema2: Lenguaje de muestra de contenidos e informacion web parte II html  °");
                        Console.WriteLine("° 3. tema3: Lenguaje de muestra de contenidos e informacion web parte II html  °");
                        Console.WriteLine("° 4. tema4: Lenguaje de estilos CSS                                            °");
                        Console.WriteLine("° 5. tema5: Plantillas de información web y estilos                            °");
                        Console.WriteLine("° 6. tema6: Introducción a POO Javascript en webs                              °");
                        Console.WriteLine("° 7. tema7: Scripts en webs Javascript                                         °");
                        Console.WriteLine("° 8. tema8: Lenguaje de almacenamiento xml                                     °");
                        Console.WriteLine("° 9. tema9: Lenguaje de almacenamiento xml                                     °");
                        Console.WriteLine("° 10. tema10: Introducción a SGE Crm Microsoft Dynamics                        °");
                        Console.WriteLine("° 30. Salir                                                                    °");
                        Console.WriteLine("°------------------------------------------------------------------------------°");
                        Console.WriteLine("Ingresa el numero del tema que quieres estudiar");
                        submenu3 = Convert.ToInt32(Console.ReadLine());
                        switch (submenu3)
                        {
                            case 1:
                                TemaLenguajeDeMarcas Tema1 = new TemaLenguajeDeMarcas();
                                Tema1.LlamarQuestionario1();
                                break;
                            default:
                                break;
                        }
                        break;
                    
                    case 4:
                        //Entornos de desarrollos
                        Console.WriteLine("°--------------------------------------------------------------------°");
                        Console.WriteLine("°         1. tema1: Elementos del desarrolo software                 °");
                        Console.WriteLine("°         2. tema2: Entornos integrados de desarrollo                °");
                        Console.WriteLine("°         3. tema3: Diseno y realizacion de pruebas                  °");
                        Console.WriteLine("°         4. tema4: Optimizacion y documentacion                     °");
                        Console.WriteLine("°         5. tema5: Elaboracion de diagramas de clase                °");
                        Console.WriteLine("°         6. tema6: Elaboracion de diagramas de comportamiento       °");
                        Console.WriteLine("°         30. Salir                                                  °");
                        Console.WriteLine("°--------------------------------------------------------------------°");
                        Console.WriteLine("Ingresa el numero del tema que quieres estudiar");
                        submenu4 = Convert.ToInt32(Console.ReadLine());
                        switch (submenu4)
                        {
                            case 1:
                                TemaEntornoDeDesarrollos Tema1 = new TemaEntornoDeDesarrollos();
                                Tema1.LlamarQuestionario1();
                                break;
                            default:
                                break;
                        }
                        break;
                    
                    //Completo
                    case 5:
                        //Sistemas informaticos
                        Console.WriteLine("°---------------------------------------------------------------------------------°");
                        Console.WriteLine("° 1. tema1: Elementos, estructura y funciones generales de un sistema operativo I °");
                        Console.WriteLine("° 2. tema2: Sistemas de comunicaciones y redes                                    °");
                        Console.WriteLine("° 3. tema3: Explotación de sistemas microinformáticos                             °");
                        Console.WriteLine("° 4. tema4: Sistemas de comunicaciones y redes                                    °");
                        Console.WriteLine("° 5. tema5: Instalación de sistemas operativos libres y propietarios I            °");
                        Console.WriteLine("° 6. tema6: Instalación de sistemas operativos libres y propietarios II           °");
                        Console.WriteLine("° 7. tema7: Instalación de sistemas operativos iv                                 °");
                        Console.WriteLine("° 8. tema8: Instalación de sistemas operativos v                                  °");
                        Console.WriteLine("° 9. tema9: Instalación de sistemas operativos vi                                 °");
                        Console.WriteLine("° 10. tema10: Instalación de sistemas operativos vii                              °");
                        Console.WriteLine("° 11. tema11: Instalación de sistemas operativos viiii                            °");
                        Console.WriteLine("° 12. tema12: Gestión de la información i                                         °");
                        Console.WriteLine("° 13. tema13: Gestión de la información ii                                        °");
                        Console.WriteLine("° 14. tema14: Gestión de la información iii                                       °");
                        Console.WriteLine("° 15. tema15: Configuración de sistemas operativos i                              °");
                        Console.WriteLine("° 16. tema16: Configuración de sistemas operativos ii                             °");
                        Console.WriteLine("° 17. tema17: Configuración de sistemas operativos iii                            °");
                        Console.WriteLine("° 18. tema18: Conexión de sistemas en red i                                       °");
                        Console.WriteLine("° 19. tema19: Conexión de sistemas en red ii                                      °");
                        Console.WriteLine("° 20. tema20: Conexión de sistemas en red iii                                     °");
                        Console.WriteLine("° 21. tema21: Gestión de recursos de una red iv                                   °");
                        Console.WriteLine("° 30. Salir                                                                       °");
                        Console.WriteLine("°---------------------------------------------------------------------------------°");
                        Console.WriteLine("Ingresa el numero del tema que quieres estudiar");
                        submenu5 = Convert.ToInt32(Console.ReadLine());
                        switch (submenu5)
                        {
                            case 1:
                                TemaSistemasInformaticos Tema1 = new TemaSistemasInformaticos();
                                Tema1.LlamarQuestionario1();
                                break;
                            case 2:
                                TemaSistemasInformaticos Tema2 = new TemaSistemasInformaticos();
                                Tema2.LlamarQuestionario2();
                                break;
                            case 3:
                                TemaSistemasInformaticos Tema3 = new TemaSistemasInformaticos();
                                Tema3.LlamarQuestionario3();
                                break;
                            case 4:
                                TemaSistemasInformaticos Tema4 = new TemaSistemasInformaticos();
                                Tema4.LlamarQuestionario4();
                                break;
                            case 5:
                                TemaSistemasInformaticos Tema5 = new TemaSistemasInformaticos();
                                Tema5.LlamarQuestionario5();
                                break;
                            case 6:
                                TemaSistemasInformaticos Tema6 = new TemaSistemasInformaticos();
                                Tema6.LlamarQuestionario6();
                                break;
                            case 7:
                                TemaSistemasInformaticos Tema7 = new TemaSistemasInformaticos();
                                Tema7.LlamarQuestionario7();
                                break;
                            case 8:
                                TemaSistemasInformaticos Tema8 = new TemaSistemasInformaticos();
                                Tema8.LlamarQuestionario8();
                                break;
                            case 9:
                                TemaSistemasInformaticos Tema9 = new TemaSistemasInformaticos();
                                Tema9.LlamarQuestionario9();
                                break;
                            case 10:
                                TemaSistemasInformaticos Tema10 = new TemaSistemasInformaticos();
                                Tema10.LlamarQuestionario10();
                                break;
                            case 11:
                                TemaSistemasInformaticos Tema11 = new TemaSistemasInformaticos();
                                Tema11.LlamarQuestionario11();
                                break;
                            case 12:
                                TemaSistemasInformaticos Tema12 = new TemaSistemasInformaticos();
                                Tema12.LlamarQuestionario12();
                                break;
                            case 13:
                                TemaSistemasInformaticos Tema13 = new TemaSistemasInformaticos();
                                Tema13.LlamarQuestionario13();
                                break;
                            case 14:
                                TemaSistemasInformaticos Tema14 = new TemaSistemasInformaticos();
                                Tema14.LlamarQuestionario14();
                                break;
                            case 15:
                                TemaSistemasInformaticos Tema15 = new TemaSistemasInformaticos();
                                Tema15.LlamarQuestionario15();
                                break;
                            case 16:
                                TemaSistemasInformaticos Tema16 = new TemaSistemasInformaticos();
                                Tema16.LlamarQuestionario16();
                                break;
                            case 17:
                                TemaSistemasInformaticos Tema17 = new TemaSistemasInformaticos();
                                Tema17.LlamarQuestionario17();
                                break;
                            case 18:
                                TemaSistemasInformaticos Tema18 = new TemaSistemasInformaticos();
                                Tema18.LlamarQuestionario18();
                                break;
                            case 19:
                                TemaSistemasInformaticos Tema19 = new TemaSistemasInformaticos();
                                Tema19.LlamarQuestionario19();
                                break;
                            case 20:
                                TemaSistemasInformaticos Tema20 = new TemaSistemasInformaticos();
                                Tema20.LlamarQuestionario20();
                                break;
                            case 21:
                                TemaSistemasInformaticos Tema21 = new TemaSistemasInformaticos();
                                Tema21.LlamarQuestionario21();
                                break;
                            default:
                                break;
                        } 
                        break;
                    
                    case 6:
                        //FOL
                        Console.WriteLine("°------------------------------------------------------------------------------------------°");
                        Console.WriteLine("° 1. tema1: El derecho del trabajo                                                         °");
                        Console.WriteLine("° 2. tema2: Contratos de trabajo                                                           °");
                        Console.WriteLine("° 3. tema3: Modalidades contractuales                                                      °");
                        Console.WriteLine("° 4. tema4: Tiempo de trabajo                                                              °");
                        Console.WriteLine("° 5. tema5: Modificación, suspensión y extinción del contrato de trabajo: causas y efectos °");
                        Console.WriteLine("° 6. tema6: Retribuciones salariales                                                       °");
                        Console.WriteLine("° 7. tema7: Representación de los trabajadores: unitaria y sindical                        °");
                        Console.WriteLine("° 8. tema8: Seguridad Social                                                               °");
                        Console.WriteLine("° 9. tema9: Seguridad y salud en el trabajo: conceptos básicos                             °");
                        Console.WriteLine("° 10. tema10: Riesgos profesionales: riesgos generales y riesgos específicos               °");
                        Console.WriteLine("° 11. tema11: Aplicación de medidas de prevención y protección en la empresa               °");
                        Console.WriteLine("° 12. tema12: Planificación de la prevención de riesgos en la empresa                      °");
                        Console.WriteLine("° 13. tema13: Primeros auxilios                                                            °");
                        Console.WriteLine("° 14. tema14: Orientación profesional y búsqueda activa de empleo                          °");
                        Console.WriteLine("° 15. tema15: Grupos y equipos de trabajo                                                  °");
                        Console.WriteLine("° 16. tema16: Gestión del conflicto                                                        °");
                        Console.WriteLine("° 30. Salir                                                                                °");
                        Console.WriteLine("°------------------------------------------------------------------------------------------°");
                        Console.WriteLine("Ingresa el numero del tema que quieres estudiar");
                        submenu6 = Convert.ToInt32(Console.ReadLine());
                        switch (submenu6)
                        {
                            case 1:
                                TemaFOL Tema1 = new TemaFOL();
                                Tema1.LlamarQuestionario1();
                                break;
                            default:
                                break;
                        } 
                        break;
                }
                
            } while (opc!=30);
        }
    }
}

