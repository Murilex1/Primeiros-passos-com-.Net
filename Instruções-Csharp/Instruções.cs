using System;

    namespace Instrucoes
    {
        class Program
        {
            // Declaração de Variaveis e Consantes
                static void Declaracoes()
                {
                        int a;
                        int b = 2, c =3;
                     
                       // Constante não se pode mudar o valor
                        const int d =4;
                        
                        //Variavel pode ter valor alterado
                        a = 1;
                       
                        Console.WriteLine(a+ b +c +d);
                }
                //Instruções de "if = se" e "else = senão"
                
                static void InstrucaoIf(string[] args)
                {
                    if (args.Length == 0)
                    {
                        Console.WriteLine("Nenhum argumento");
                    }
                    else if(args.Length == 1)
                    {
                        Console.WriteLine("Um argumento");
                    }
                    else
                    {
                        Console.WriteLine($"{args.Length}argumentos");
                    }
                }
                
                //Instrução Switch
                static void InstrucaoSwitch(string[] args)
                {
                    int numeroDeArgumentos = args.Length;
                    switch(numeroDeArgumentos)
                    {
                        case 0:
                            Console.WriteLine("Nenhum argumento");
                            break;
                            //Break para chegar nessa condição e sair do Switch
                        case 1:
                            Console.WriteLie("Um argumento");
                            break;
                        default:
                            Console.WriteLine($"{numeroDeArgumentos}argumentos");
                            break;
                    }
                }

               //Instrução While = Enquanto,  é uma instrução de repetição
                static void InstrucaoWhile(string[] args)
                {
                    int i = 0;
                    while (i < args.Length)
                    {
                        Console.WriteLine(args{i});
                        i++;
                        // i = i + 1;
                        i--;
                        // i = i -1;
                        
                    }
                }
                //Instrução Do, ele vai executar pelo menos 1 vez
                static void InstrucaoDo(string [] args)
                {
                    string texto;
                    do
                    {
                        texto = Console.ReadLine();
                        Console.WriteLine(texto);
                    } while(!string.IsNullOrEmpty(texto));
                    //
                }

               //Instrução For, a mesma coisa do While
                static void InstrucaoFor(string[]args)
                {
                    for(int i = 0; i < args.Length; i++)
                    {
                        Console.WriteLine(args{i});
                    }
                    
                }
                
                // Instrução Foreach = pra cada(...)
                static void InstrucaoForeach(string[] args)
                {
                    foreach(string s in args)
                    {
                        Console.WriteLine(s);
                    }
                }

                //Instrução Break Funciona com While e For.
                static void InstrucaoBreak(string[] args)
                {
                    while (true)
                    {
                        string s = Console.ReaLine();
                        if(string.IsNullOrEmpty(s))
                        {
                            break;
                        }
                        Console.WriteLine(s);
                    }
                }

                //Instrução Continue
                static void InstrucaoContinue(string[] args)
                {
                    for(int i = 0; i < args.Length; i++)
                    {
                        if (args[i].StartsWith("/"))
                           {
                            continue;
                           }
                           
                            Console.WriteLine(args[i]);
                    }
                }
                
                //Instrução Return
                static void InstrucaoReturn(string[] args)
                {
                    int Somar(int a,int b)
                    {
                        return a + b;
                    }
                    Console.WriteLine(Somar(1, 2));
                    Console.WriteLine(Somar(3, 4));
                    Console.WriteLine(Somar(5, 6));
                    return;
                }

                //Instrução Try Catch Finally Throw,  tem haver com excessões
                static void Instrucao TryCatchFinallyThrow(string[] args)
                {
                    double Dividir(double x, double y)
                    {
                        if (y == 0)
                           //Throw new, lançar nova exceção
                            throw new DivideByZeroException();
                        
                        return x / y;
                    }

                    try
                    {
                        if(args.Length != 2)
                        {
                            throw new InvalidOperationException ("informe 2 numeros");
                        }

                        double x = double.Parse(args[0]);
                        double y = double.Parse(args[1]);
                        Console.WriteLine(Dividir(x, y));
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"erro genérico: {e.Message}");
                    }
                    finally
                    {
                    Console.WriteLine("Até Breve");
                    }
                }

                //Instrução using
                satic void InstrucaoUsing(string[] args)
                {
                  using (System.IO.TextWriter w;
                    w = System.IO.File.CreateText("teste.txt"))
                    {
                        w.WriteLine("Line 1");
                        w.WriteLine("Line 2");
                        w.WriteLine("Line 3");
                    }
                }

                // Array unidimensional

                int [] a = new int [10];
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = i * i;
                }
                for (int i = 0; i <a.Length; i++)
                {
                    Console.WriteLine($"a [{i}] = [a {i}]");
                }

                //Array multidimensional

                int[,] a2 = new int [10, 5];
                int [,,] a3 = new int [10, 5, 2];

                //Iniciador deArray

                int [] a = new int [] {1, 2, 3};
                int[] a = {1, 2, 3};
               
                int[] t = new int [3];
                t[0] = 1;
                t[1] = 2;
                t[2] = 3;
                int [] a = t;

                // ===== ANOTAÇÕES SOBRE INSTRUÇÕES C#======
        }
    }
