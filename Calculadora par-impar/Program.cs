/*Fazer um programa que aceite so numeros pares e os primos de so de bloqueio 
 * os pares serviram par contas e os primos para segunrança
 */


// Programa 
using System;
namespace ConsoleApp2
{
    class program
    {

        static void s(float x, float y) // SOMA
        {
            float s2;
            s2 = x + y;
            Console.Clear();
            Console.WriteLine("Soma: {0} + {1} = {2}", x, y, s2);


        }
        static void d(float x, float y) // DIVISAO
        {
            float s2;
            s2 = x / y;
            Console.Clear();
            Console.WriteLine("Divisao: {0} : {1} = {2}", x, y, s2);

        }
        static void m(float x, float y) // MULTIPLICAÇAO
        {
            float s2;
            s2 = x * y;
            Console.Clear();
            Console.WriteLine("Multiplicaçao: {0} x {1} = {2}", x, y, s2);

        }
        static void sub(float x, float y) // SUBTRAÇAO
        {
            float s2;
            s2 = x - y;
            Console.Clear();
            Console.WriteLine("Subtraçao: {0} - {1} = {2}", x, y, s2);

        }
        static void par(float x, float y)
        {
            int a;
            do
            {

                Console.WriteLine("Modo par");

                Console.WriteLine("Insira a operaçao que quer >");
                Console.WriteLine("Numeros: {0} e {1}", x, y);
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtraçao");
                Console.WriteLine("3 - Multiplicaçao");
                Console.WriteLine("4 - Divisao");
                Console.WriteLine("5 - Novos numeros");
                Console.WriteLine("6 . Modo impar");
                Console.WriteLine("0 - Sair");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.Clear();
                        s(x, y); // soma
                        Console.Beep();
                        break;
                    case 2:
                        Console.Clear();
                        sub(x, y); // subtraçao
                        Console.Beep();
                        break;
                    case 3:
                        Console.Clear();
                        m(x, y);
                        Console.Beep();
                        break;
                    case 4:
                        Console.Clear();
                        d(x, y);
                        Console.Beep();
                        break;
                    case 5:
                        Console.Clear();
                        do
                        {
                            Console.Write("Insira um numero:  ");
                            x = Convert.ToSingle(Console.ReadLine());
                            Console.Write("Insira outro numero:  ");
                            y = Convert.ToSingle(Console.ReadLine());
                            Console.Clear();
                            if (x % 2 != 0 && y % 2 != 0)
                            {
                                Console.WriteLine("Os dois numeros nao sao par.");
                            }
                            else if (x % 2 != 0)
                            {
                                Console.WriteLine("O numero {0} não é par", x);
                            }
                            else if (y % 2 != 0)
                            {
                                Console.WriteLine("O numero {0} não é par", y);
                            }
                        } while (x % 2 != 0 || y % 2 != 0);
                        break;
                    case 6:
                        Console.Clear();
                        do
                        {
                            Console.Write("Insira um numero:  ");
                            x = Convert.ToSingle(Console.ReadLine());
                            Console.Write("Insira outro numero:  ");
                            y = Convert.ToSingle(Console.ReadLine());
                            Console.Clear();
                            if (x % 2 == 0 && y % 2 == 0)
                            {
                                Console.WriteLine("Os dois numeros nao sao impar.");
                            }
                            else if (x % 2 == 0)
                            {
                                Console.WriteLine("O numero {0} nao é impar", x);
                            }
                            else if (y % 2 == 0)
                            {
                                Console.WriteLine("O numero {0} nao é impar", y);
                            }
                        } while (x % 2 == 0 || y % 2 == 0);
                        impar(x, y);
                        Console.Clear();
                        break;
                    default:
                        break;
                }

                Console.Clear();

            } while (a != 0);
        }
        static void impar(float x, float y)
        {
            int a;
            do
            {
                Console.WriteLine("Modo impar");
                Console.WriteLine("Insira a operaçao que quer >");
                Console.WriteLine("Numeros: {0} e {1}", x, y);
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtraçao");
                Console.WriteLine("3 - Multiplicaçao");
                Console.WriteLine("4 - Divisao");
                Console.WriteLine("5 - Novos numeros");
                Console.WriteLine("6 - Modo par");
                Console.WriteLine("0 - Sair");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.Clear();
                        s(x, y); // soma
                        Console.Beep();
                        break;
                    case 2:
                        Console.Clear();
                        sub(x, y); // subtraçao
                        Console.Beep();
                        break;
                    case 3:
                        Console.Clear();
                        m(x, y);
                        Console.Beep();
                        break;
                    case 4:
                        Console.Clear();
                        d(x, y);
                        Console.Beep();
                        break;
                    case 5:
                        Console.Clear();
                        do
                        {
                            Console.Write("Insira um numero:  ");
                            x = Convert.ToSingle(Console.ReadLine());
                            Console.Write("Insira outro numero:  ");
                            y = Convert.ToSingle(Console.ReadLine());
                            Console.Clear();
                            if (x % 2 == 0 && y % 2 == 0)
                            {
                                Console.WriteLine("Os dois numeros nao sao impar.");
                            }
                            else if (x % 2 == 0)
                            {
                                Console.WriteLine("O numero {0} nao é impar", x);
                            }
                            else if (y % 2 == 0)
                            {
                                Console.WriteLine("O numero {0} nao é impar", y);
                            }
                        } while (x % 2 == 0 || y % 2 == 0);
                        break;
                    case 6:
                        Console.Clear();
                        do
                        {
                            Console.Write("Insira um numero:  ");
                            x = Convert.ToSingle(Console.ReadLine());
                            Console.Write("Insira outro numero:  ");
                            y = Convert.ToSingle(Console.ReadLine());
                            Console.Clear();
                            if (x % 2 != 0 && y % 2 != 0)
                            {
                                Console.WriteLine("Os dois numeros nao sao par.");
                            }
                            else if (x % 2 != 0)
                            {
                                Console.WriteLine("O numero {0} não é par", x);
                            }
                            else if (y % 2 != 0)
                            {
                                Console.WriteLine("O numero {0} não é par", y);
                            }
                        } while (x % 2 != 0 || y % 2 != 0);
                        par(x, y);

                        break;
                    default:
                        break;

                }

                Console.Clear();
            } while (a != 0);
        }
        static void Main(string[] args)
        {
            int bloq;
            int op;
            string s = "Codigo invalido";
            string s1 = "Calculadora desbloqueada";
            do
            {
                Console.Write("Insira o codigo de desbloqueio:  ");
                bloq = Convert.ToInt32(Console.ReadLine());
                if (bloq == 12)
                {
                    Console.WriteLine(s1);
                    Console.Clear();
                    do
                    {
                        Console.WriteLine("Escolha o modo de calculo");
                        Console.WriteLine("Insira 1 para calcular numeros pares > ");
                        Console.WriteLine("Insira 2 para calcular numeros impares > ");
                        op = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        float n1;
                        float n2;

                        switch (op)
                        {
                            case 1: // par
                                do
                                {

                                    Console.Write("Insira um numero:  ");
                                    n1 = Convert.ToSingle(Console.ReadLine());
                                    Console.Write("Insira outro numero:  ");
                                    n2 = Convert.ToSingle(Console.ReadLine());
                                    Console.Clear();
                                    if (n1 % 2 != 0 && n2 % 2 != 0)
                                    {
                                        Console.WriteLine("Os dois numeros nao sao par.");
                                    }
                                    else if (n1 % 2 != 0)
                                    {
                                        Console.WriteLine("O numero {0} não é par", n1);
                                    }
                                    else if (n2 % 2 != 0)
                                    {
                                        Console.WriteLine("O numero {0} não é par", n2);
                                    }

                                    else
                                    {
                                        par(n1, n2);
                                    }
                                } while (n1 % 2 != 0 || n2 % 2 != 0);
                                break;

                            case 2: // impar
                                do
                                {
                                    Console.Write("Insira um numero:  ");
                                    n1 = Convert.ToSingle(Console.ReadLine());
                                    Console.Write("Insira outro numero:  ");
                                    n2 = Convert.ToSingle(Console.ReadLine());
                                    do
                                    {
                                        Console.Write("Insira um numero:  ");
                                        n1 = Convert.ToSingle(Console.ReadLine());
                                        Console.Write("Insira outro numero:  ");
                                        n2 = Convert.ToSingle(Console.ReadLine());
                                        Console.Clear();
                                        if (n1 % 2 == 0 && n2 % 2 == 0)
                                        {
                                            Console.WriteLine("Os dois numeros nao sao impar.");
                                        }
                                        else if (n1 % 2 == 0)
                                        {
                                            Console.WriteLine("O numero {0} não é impar", n1);
                                        }
                                        else if (n1 % 2 != 0)
                                        {
                                            Console.WriteLine("O numero {0} não é impar", n1);
                                        }
                                        else if (n2 % 2 != 0)
                                        {
                                            Console.WriteLine("O numero {0} não é impar", n2);
                                        }

                                        else
                                        {
                                            impar(n1, n2);
                                        }
                                    } while (n1 % 2 == 0 || n2 % 2 == 0);
                                } while (op != 2);
                                break;
                            default:
                                break;
                        }
                    } while (op > 2);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(s);
                }
            } while (bloq != 12);
        }

    }
}