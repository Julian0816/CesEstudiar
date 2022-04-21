﻿using System.Collections.Generic;
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
                    case 1:
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
                        Console.WriteLine("°         15. Salir                                           °");
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
                    
                    case 2:
                        Console.WriteLine("°----------------------------------------------------------------------------°");
                        Console.WriteLine("°         1. tema1: Introducción a la programación                           °");
                        Console.WriteLine("°         2. tema2: Estructuras de control de flujo: condicion               °");
                        Console.WriteLine("°         3. tema3: Estructuras de control de flujo: cíclicas                °");
                        Console.WriteLine("°         4. tema4: Métodos y funciones                                      °");
                        Console.WriteLine("°         5. tema5: Diseño en programación                                   °");
                        Console.WriteLine("°         6. tema6: Estructura de datos complejas: arrays                    °");
                        Console.WriteLine("°         7. tema7: Programación orientada a objetos                         °");
                        Console.WriteLine("°         8. tema8: Estructuras de datos complejas: matrices                 °");
                        Console.WriteLine("°         9. tema9: Esctructuras de datos complejas: colecciones             °");
                        Console.WriteLine("°         10. tema10: formularios y otros elementos de interfaz de usuario   °");
                        Console.WriteLine("°         11. tema11: Estructuras de datos complejas: agrupadores            °");
                        Console.WriteLine("°         12. tema12: Eventos y listeners                                    °");
                        Console.WriteLine("°         13. tema13: Colisiones                                             °");
                        Console.WriteLine("°         14. tema14: Corrutinas                                             °");
                        Console.WriteLine("°         15. tema15: Entrada y salida de datos                              °");
                        Console.WriteLine("°         15. tema16: Informatica grafica                                    °");
                        Console.WriteLine("°         30. Salir                                                          °");
                        Console.WriteLine("°----------------------------------------------------------------------------°");
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
                        Console.WriteLine("°--------------------------°");
                        Console.WriteLine("°         1. tema1:        °");
                        Console.WriteLine("°         2. tema2:        °");
                        Console.WriteLine("°         3. tema3:        °");
                        Console.WriteLine("°         4. tema4:        °");
                        Console.WriteLine("°         5. tema5:        °");
                        Console.WriteLine("°         6. tema6:        °");
                        Console.WriteLine("°         7. tema7:        °");
                        Console.WriteLine("°         8. tema8:        °");
                        Console.WriteLine("°         9. tema9:        °");
                        Console.WriteLine("°         10. tema10:      °");
                        Console.WriteLine("°         11. tema11:      °");
                        Console.WriteLine("°         12. tema12:      °");
                        Console.WriteLine("°         13. tema13:      °");
                        Console.WriteLine("°         14. tema14:      °");
                        Console.WriteLine("°         30. Salir        °");
                        Console.WriteLine("°--------------------------°");
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
                        Console.WriteLine("°--------------------------°");
                        Console.WriteLine("°         1. tema1:        °");
                        Console.WriteLine("°         2. tema2:        °");
                        Console.WriteLine("°         3. tema3:        °");
                        Console.WriteLine("°         4. tema4:        °");
                        Console.WriteLine("°         5. tema5:        °");
                        Console.WriteLine("°         6. tema6:        °");
                        Console.WriteLine("°         7. tema7:        °");
                        Console.WriteLine("°         8. tema8:        °");
                        Console.WriteLine("°         9. tema9:        °");
                        Console.WriteLine("°         10. tema10:      °");
                        Console.WriteLine("°         11. tema11:      °");
                        Console.WriteLine("°         12. tema12:      °");
                        Console.WriteLine("°         13. tema13:      °");
                        Console.WriteLine("°         14. tema14:      °");
                        Console.WriteLine("°         30. Salir        °");
                        Console.WriteLine("°--------------------------°");
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
                    case 5:
                        Console.WriteLine("°--------------------------°");
                        Console.WriteLine("°         1. tema1:        °");
                        Console.WriteLine("°         2. tema2:        °");
                        Console.WriteLine("°         3. tema3:        °");
                        Console.WriteLine("°         4. tema4:        °");
                        Console.WriteLine("°         5. tema5:        °");
                        Console.WriteLine("°         6. tema6:        °");
                        Console.WriteLine("°         7. tema7:        °");
                        Console.WriteLine("°         8. tema8:        °");
                        Console.WriteLine("°         9. tema9:        °");
                        Console.WriteLine("°         10. tema10:      °");
                        Console.WriteLine("°         11. tema11:      °");
                        Console.WriteLine("°         12. tema12:      °");
                        Console.WriteLine("°         13. tema13:      °");
                        Console.WriteLine("°         14. tema14:      °");
                        Console.WriteLine("°         30. Salir        °");
                        Console.WriteLine("°--------------------------°");
                        Console.WriteLine("Ingresa el numero del tema que quieres estudiar");
                        submenu5 = Convert.ToInt32(Console.ReadLine());
                        switch (submenu5)
                        {
                            case 1:
                                TemaSistemasInformaticos Tema1 = new TemaSistemasInformaticos();
                                Tema1.LlamarQuestionario1();
                                break;
                            default:
                                break;
                        } 
                        break;
                    case 6:
                        Console.WriteLine("°--------------------------°");
                        Console.WriteLine("°         1. tema1:        °");
                        Console.WriteLine("°         2. tema2:        °");
                        Console.WriteLine("°         3. tema3:        °");
                        Console.WriteLine("°         4. tema4:        °");
                        Console.WriteLine("°         5. tema5:        °");
                        Console.WriteLine("°         6. tema6:        °");
                        Console.WriteLine("°         7. tema7:        °");
                        Console.WriteLine("°         8. tema8:        °");
                        Console.WriteLine("°         9. tema9:        °");
                        Console.WriteLine("°         10. tema10:      °");
                        Console.WriteLine("°         11. tema11:      °");
                        Console.WriteLine("°         12. tema12:      °");
                        Console.WriteLine("°         13. tema13:      °");
                        Console.WriteLine("°         14. tema14:      °");
                        Console.WriteLine("°         30. Salir        °");
                        Console.WriteLine("°--------------------------°");
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

