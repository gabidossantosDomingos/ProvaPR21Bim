using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ProvaPR21Bim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exercicios;

            Console.WriteLine("Digite um exercicio:");
           

            Console.WriteLine("-MENU-");
            Console.WriteLine("1- ex.1");
            Console.WriteLine("2- ex.2");
            Console.WriteLine("3- ex.3");
            Console.WriteLine("4- ex.4");
            Console.WriteLine("5- ex.5");
            Console.WriteLine("6- ex.6");
            Console.WriteLine("7- ex.7");
            exercicios = int.Parse(Console.ReadLine());

            switch (exercicios)

            {
                case 1:
            int nume;

            Console.WriteLine("Digite um número inteiro");
            nume = int.Parse(Console.ReadLine());


            if (nume < 0)
            {

                Console.WriteLine("O número na forma positiva é" + nume);
            }

            else
            {
                Console.WriteLine("o número é" + nume);
            }

            Console.ReadKey();
                    break;





                case 2:
                    int num;
                    Console.WriteLine("Digite um número:");
                    num = int.Parse(Console.ReadLine());

                    if (num % 3 == 0 && num % 5 == 0 && num % 4 == 0 && num % 7 == 0)
                    {
                        Console.WriteLine("O número é multiplo de 3, 5,4 e 7");
                    }



                    else if (num % 3 == 0)
                    {
                        Console.WriteLine("O número é divisivel por 3:");
                    }

                    else if (num % 5 == 0)
                    {

                        Console.WriteLine("O número é divisivel por 5:");
                    }

                    else if (num % 4 == 0)
                    {
                        Console.WriteLine("O número é divisivel por 4:");
                    }

                    else if (num % 7 == 0)
                    {
                        Console.WriteLine("O número é divisivel por 7:");
                    }

                    else
                    {
                        Console.WriteLine("a impossibilidade de divisão");
                    }
                    Console.ReadKey();
                    break;





                case 3:
                    int n1, n2, n3;

                    Console.WriteLine("Digite um número inteiro:");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite outro número inteiro:");
                    n2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite outro número inteiro:");
                    n3 = int.Parse(Console.ReadLine());


                    if (n1 > n2 && n1 > n3 && n2 > n3)
                    {
                        Console.WriteLine("Essa é a oredem" + n3 + n2 + n1);
                    }


                    if (n1 > n2 && n1 > n3 && n3 > n2)
                    {
                        Console.WriteLine("Essa é a oredem" + n2 + n3 + n1);
                    }


                    else if (n2 > n1 && n2 > n3 && n1 > n3)
                    {
                        Console.WriteLine("Essa é a oredem" + n3 + n1 + n2);

                    }
                    else if (n2 > n1 && n2 > n3 && n3 > n1)
                    {
                        Console.WriteLine("Essa é a oredem" + n1 + n3 + n2);
                    }

                    else if (n3 > n1 && n3 > n2 && n1 > n2)
                    {
                        Console.WriteLine("Essa é a oredem: " + n3 + n1 + n2);
                    }

                    else if (n3 > n1 && n3 > n2 && n2 > n1)
                    {
                        Console.WriteLine("Essa é a oredem: ");
                        Console.WriteLine(+n1);
                        Console.WriteLine(+n2);
                        Console.WriteLine(+n3);
                    }

                    Console.ReadLine();
                    break;






                case 4:
                    int g, dS;

            Console.WriteLine("Digite um número de 1 a 7: ");


            Console.WriteLine("----MENU----");
            Console.WriteLine("1 - domingo");
            Console.WriteLine("2 - segunda");
            Console.WriteLine("3 = terça");
            Console.WriteLine("4- quarta");
            Console.WriteLine("5- quinta");
            Console.WriteLine("6- sexta");
            Console.WriteLine("7- sabado");
            g = int.Parse(Console.ReadLine());


            switch (g)
            {

                case 1:
                    Console.WriteLine("Aos domingos você gosta de Assistir filmes");
                    break;


                case 2:
                    Console.WriteLine("suas matéria desse dia são: Matematica, geografia e portugues");
                    break;


                case 3:
                    Console.WriteLine("suas matéria desse dia são: Filosofia, biologia e historia");
                    break;

                case 4:
                    Console.WriteLine("suas matéria desse dia são: sociologia, fisica e inglês");
                    break;

                case 5:
                    Console.WriteLine("suas matéria desse dia são: português, matemática e programaçaõ");
                    break;

                case 6:
                    Console.WriteLine("suas matéria desse dia são: Quimica, BDS e Redes de Computadores");
                    break;

                case 7:
                    Console.WriteLine("Aos sabados você gosta de fazer piquinique ");
                    break;




                default:
                    Console.WriteLine("Essa opçãoé inválida");
                    break;



            }
            Console.ReadKey();
                    break;




                //case 5:
                //    int v=1, k1, maiorN,menorN, MinValue;

                //    Console.WriteLine("Digite um número inteiro:");
                //    k1 = int.Parse(Console.ReadLine());
                   


                //    for (; v != 0;)
                //    {
                //        if 
                //        maiorN > MinValue;
                //        maiorN < int.MaxValue;

                //    }

                //    if (k1 == 1)
                //    Console.WriteLine("Digite um número inteiro:");


                //    break;





                //case 6:
                //    int l, divisores;

                //    Console.WriteLine("Digite um úmero inteiro:");
                //    l = int.Parse(Console.ReadLine());  

                //    if (divisores == l % 2 == 0)
                       



                    break;


                case 7:
                    int d=1,f, nPar, mA;

                    Console.WriteLine("digite um número inteiro: ");
                    f = int.Parse(Console.ReadLine());

                    for (;d !=0 ;d ++)
                    {
                        if (f % 2 == 0)
                        {
                            mA =  +  2;
                            
                           
                        }

                        else
                        {
                            Console.WriteLine("e não foi possível calcular a média");
                        }
                    }
                    break;




                   // 6  28 496




        }
        }
    }
}
