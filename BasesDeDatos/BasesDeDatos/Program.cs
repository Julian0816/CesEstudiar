using System.Collections.Generic;
using System;

namespace BasesDeDatos
{
    class Program
    {
        private static void Main(string[] args) {
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
                    //Bases de Datos - Completo
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
                                Temario tema1 = new Temario();
                                tema1.llamarQuestionario1();
                                break;
                            case 2:
                                Temario tema2 = new Temario();
                                tema2.llamarQuestionario2();
                                break;
                            case 3:
                                Temario tema3 = new Temario();
                                tema3.llamarQuestionario3();
                                break;
                            case 4:
                                Temario tema4 = new Temario();
                                tema4.llamarQuestionario4();
                                break;
                            case 5:
                                Temario tema5 = new Temario();
                                tema5.llamarQuestionario5();
                                break;
                            case 6:
                                Temario tema6 = new Temario();
                                tema6.llamarQuestionario6();
                                break;
                            case 7:
                                Temario tema7 = new Temario();
                                tema7.llamarQuestionario7();
                                break;
                            case 8:
                                Temario tema8 = new Temario();
                                tema8.llamarQuestionario8();
                                break;
                            case 9:
                                Temario tema9 = new Temario();
                                tema9.llamarQuestionario9();
                                break;
                            case 10:
                                Temario tema10 = new Temario();
                                tema10.llamarQuestionario10();
                                break;
                            case 11:
                                Temario tema11 = new Temario();
                                tema11.llamarQuestionario11();
                                break;
                            case 12:
                                Temario tema12 = new Temario();
                                tema12.llamarQuestionario12();
                                break;
                            case 13:
                                Temario tema13 = new Temario();
                                tema13.llamarQuestionario13();
                                break;
                            case 14:
                                Temario tema14 = new Temario();
                                tema14.llamarQuestionario14();
                                break;
                            case 15:
                                Console.WriteLine("finalizo el estudio");
                                break;
                            default:
                                break;
                        }
                        break;
                    
                    //Programacion - Incompleto
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
                                TemaProgramacion tema1 = new TemaProgramacion();
                                tema1.llamarQuestionario1();
                                break;
                            case 2:
                                TemaProgramacion tema2 = new TemaProgramacion();
                                tema2.llamarQuestionario2();
                                break;
                            case 3:
                                TemaProgramacion tema3 = new TemaProgramacion();
                                tema3.llamarQuestionario3();
                                break;
                            case 4:
                                TemaProgramacion tema4 = new TemaProgramacion();
                                tema4.llamarQuestionario4();
                                break;
                            case 5:
                                TemaProgramacion tema5 = new TemaProgramacion();
                                tema5.llamarQuestionario5();
                                break;
                            case 6:
                                TemaProgramacion tema6 = new TemaProgramacion();
                                tema6.llamarQuestionario6();
                                break;
                            default:
                                break;
                        }
                        break;
                    
                    //Lenguaje de Marcas - Completo
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
                                TemaLenguajeDeMarcas tema1 = new TemaLenguajeDeMarcas();
                                tema1.llamarQuestionario1();
                                break;
                            case 2:
                                TemaLenguajeDeMarcas tema2 = new TemaLenguajeDeMarcas();
                                tema2.llamarQuestionario2();
                                break;
                            case 3:
                                TemaLenguajeDeMarcas tema3 = new TemaLenguajeDeMarcas();
                                tema3.llamarQuestionario3();
                                break;
                            case 4:
                                TemaLenguajeDeMarcas tema4 = new TemaLenguajeDeMarcas();
                                tema4.llamarQuestionario4();
                                break;
                            case 5:
                                TemaLenguajeDeMarcas tema5 = new TemaLenguajeDeMarcas();
                                tema5.llamarQuestionario5();
                                break;
                            case 6:
                                TemaLenguajeDeMarcas tema6 = new TemaLenguajeDeMarcas();
                                tema6.llamarQuestionario6();
                                break;
                            case 7:
                                TemaLenguajeDeMarcas tema7 = new TemaLenguajeDeMarcas();
                                tema7.llamarQuestionario7();
                                break;
                            case 8:
                                TemaLenguajeDeMarcas tema8 = new TemaLenguajeDeMarcas();
                                tema8.llamarQuestionario8();
                                break;
                            case 9:
                                TemaLenguajeDeMarcas tema9 = new TemaLenguajeDeMarcas();
                                tema9.llamarQuestionario9();
                                break;
                            case 10:
                                TemaLenguajeDeMarcas tema10 = new TemaLenguajeDeMarcas();
                                tema10.llamarQuestionario10();
                                break;
                            default:
                                break;
                        }
                        break;
                    
                    //Entornos de Desarrollo - Completo
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
                                TemaEntornoDeDesarrollos tema1 = new TemaEntornoDeDesarrollos();
                                tema1.llamarQuestionario1();
                                break;
                            case 2:
                                TemaEntornoDeDesarrollos tema2 = new TemaEntornoDeDesarrollos();
                                tema2.llamarQuestionario2();
                                break;
                            case 3:
                                TemaEntornoDeDesarrollos tema3 = new TemaEntornoDeDesarrollos();
                                tema3.llamarQuestionario3();
                                break;
                            case 4:
                                TemaEntornoDeDesarrollos tema4 = new TemaEntornoDeDesarrollos();
                                tema4.llamarQuestionario4();
                                break;
                            case 5:
                                TemaEntornoDeDesarrollos tema5 = new TemaEntornoDeDesarrollos();
                                tema5.llamarQuestionario5();
                                break;
                            case 6:
                                TemaEntornoDeDesarrollos tema6 = new TemaEntornoDeDesarrollos();
                                tema6.llamarQuestionario6();
                                break;
                            default:
                                break;
                        }
                        break;
                    
                    //Sistemas Informaticos - Completo
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
                                TemaSistemasInformaticos tema1 = new TemaSistemasInformaticos();
                                tema1.llamarQuestionario1();
                                break;
                            case 2:
                                TemaSistemasInformaticos tema2 = new TemaSistemasInformaticos();
                                tema2.llamarQuestionario2();
                                break;
                            case 3:
                                TemaSistemasInformaticos tema3 = new TemaSistemasInformaticos();
                                tema3.llamarQuestionario3();
                                break;
                            case 4:
                                TemaSistemasInformaticos tema4 = new TemaSistemasInformaticos();
                                tema4.llamarQuestionario4();
                                break;
                            case 5:
                                TemaSistemasInformaticos tema5 = new TemaSistemasInformaticos();
                                tema5.llamarQuestionario5();
                                break;
                            case 6:
                                TemaSistemasInformaticos tema6 = new TemaSistemasInformaticos();
                                tema6.llamarQuestionario6();
                                break;
                            case 7:
                                TemaSistemasInformaticos tema7 = new TemaSistemasInformaticos();
                                tema7.llamarQuestionario7();
                                break;
                            case 8:
                                TemaSistemasInformaticos tema8 = new TemaSistemasInformaticos();
                                tema8.llamarQuestionario8();
                                break;
                            case 9:
                                TemaSistemasInformaticos tema9 = new TemaSistemasInformaticos();
                                tema9.llamarQuestionario9();
                                break;
                            case 10:
                                TemaSistemasInformaticos tema10 = new TemaSistemasInformaticos();
                                tema10.llamarQuestionario10();
                                break;
                            case 11:
                                TemaSistemasInformaticos tema11 = new TemaSistemasInformaticos();
                                tema11.llamarQuestionario11();
                                break;
                            case 12:
                                TemaSistemasInformaticos tema12 = new TemaSistemasInformaticos();
                                tema12.llamarQuestionario12();
                                break;
                            case 13:
                                TemaSistemasInformaticos tema13 = new TemaSistemasInformaticos();
                                tema13.llamarQuestionario13();
                                break;
                            case 14:
                                TemaSistemasInformaticos tema14 = new TemaSistemasInformaticos();
                                tema14.llamarQuestionario14();
                                break;
                            case 15:
                                TemaSistemasInformaticos tema15 = new TemaSistemasInformaticos();
                                tema15.llamarQuestionario15();
                                break;
                            case 16:
                                TemaSistemasInformaticos tema16 = new TemaSistemasInformaticos();
                                tema16.llamarQuestionario16();
                                break;
                            case 17:
                                TemaSistemasInformaticos tema17 = new TemaSistemasInformaticos();
                                tema17.llamarQuestionario17();
                                break;
                            case 18:
                                TemaSistemasInformaticos tema18 = new TemaSistemasInformaticos();
                                tema18.llamarQuestionario18();
                                break;
                            case 19:
                                TemaSistemasInformaticos tema19 = new TemaSistemasInformaticos();
                                tema19.llamarQuestionario19();
                                break;
                            case 20:
                                TemaSistemasInformaticos tema20 = new TemaSistemasInformaticos();
                                tema20.llamarQuestionario20();
                                break;
                            case 21:
                                TemaSistemasInformaticos tema21 = new TemaSistemasInformaticos();
                                tema21.llamarQuestionario21();
                                break;
                            default:
                                break;
                        } 
                        break;
                    
                    //FOL - Completo
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
                                TemaFol tema1 = new TemaFol();
                                tema1.llamarQuestionario1();
                                break;
                            case 2:
                                TemaFol tema2 = new TemaFol();
                                tema2.llamarQuestionario2();
                                break;
                            case 3:
                                TemaFol tema3 = new TemaFol();
                                tema3.llamarQuestionario3();
                                break;
                            case 4:
                                TemaFol tema4 = new TemaFol();
                                tema4.llamarQuestionario4();
                                break;
                            case 5:
                                TemaFol tema5 = new TemaFol();
                                tema5.llamarQuestionario5();
                                break;
                            case 6:
                                TemaFol tema6 = new TemaFol();
                                tema6.llamarQuestionario6();
                                break;
                            case 7:
                                TemaFol tema7 = new TemaFol();
                                tema7.llamarQuestionario7();
                                break;
                            case 8:
                                TemaFol tema8 = new TemaFol();
                                tema8.llamarQuestionario8();
                                break;
                            case 9:
                                TemaFol tema9 = new TemaFol();
                                tema9.llamarQuestionario9();
                                break;
                            case 10:
                                TemaFol tema10 = new TemaFol();
                                tema10.llamarQuestionario10();
                                break;
                            case 11:
                                TemaFol tema11 = new TemaFol();
                                tema11.llamarQuestionario11();
                                break;
                            case 12:
                                TemaFol tema12 = new TemaFol();
                                tema12.llamarQuestionario12();
                                break;
                            case 13:
                                TemaFol tema13 = new TemaFol();
                                tema13.llamarQuestionario13();
                                break;
                            case 14:
                                TemaFol tema14 = new TemaFol();
                                tema14.llamarQuestionario14();
                                break;
                            case 15:
                                TemaFol tema15 = new TemaFol();
                                tema15.llamarQuestionario15();
                                break;
                            case 16:
                                TemaFol tema16 = new TemaFol();
                                tema16.llamarQuestionario16();
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

