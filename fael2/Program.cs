using System;
using System.Collections.Generic;
namespace fael
{
    class Program
    {
        List<jovem> lista = new List<jovem>();
        static void Main(string[] args)


        {
            float a; float b; float c; float d; float total; float homenst; float homensn; float mulhert; float mulhern;
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            total = 50;
            homensn = 0;
            homenst = 0;
            mulhern = 0;
            homenst = 0;

            List<jovem> lista = new List<jovem>()
            {
                new jovem { nome = "Dafne", genero = "mulher", status = "trabalha" },
                new jovem { nome = "Barbara", genero = "mulher", status = "trabalha" },
                new jovem { nome = "Lais", genero = "mulher", status = "trabalha" },
                new jovem { nome = "Nathalia", genero = "mulher", status = "trabalha" },
                new jovem { nome = "leonor", genero = "mulher", status = "trabalha" },
                new jovem { nome = "thalia", genero = "mulher", status = "trabalha" },
                new jovem { nome = "brena", genero = "mulher", status = "trabalha" },
                new jovem { nome = "vitoria", genero = "mulher", status = "trabalha" },
                //não trabalha
                new jovem { nome = "juliana", genero = "mulher", status = "desempregada" },
                new jovem { nome = "daiane", genero = "mulher", status = "desempregada" },
                new jovem { nome = "camila", genero = "mulher", status = "desempregada" },
                new jovem { nome = "bia", genero = "mulher", status = "desempregada" },
                new jovem { nome = "joana", genero = "mulher", status = "desempregada" },
                new jovem { nome = "maria", genero = "mulher", status = "desempregada" },
                new jovem { nome = "karme", genero = "mulher", status = "desempregada" },
                new jovem { nome = "heloisa", genero = "mulher", status = "desempregada" },
                new jovem { nome = "talissa", genero = "mulher", status = "desempregada" },
                new jovem { nome = "gleisse", genero = "mulher", status = "desempregada" },
                new jovem { nome = "patricia", genero = "mulher", status = "desempregada" },
                new jovem { nome = "vanessa", genero = "mulher", status = "desempregada" },
                new jovem { nome = "luiza", genero = "mulher", status = "desempregada" },
                //homens que trabalha
                 new jovem { nome = "caio", genero = "homem", status = "trabalha" },
                 new jovem { nome = "bruno", genero = "homem", status = "trabalha" },
                 new jovem { nome = "elismar", genero = "homem", status = "trabalha" },
                 new jovem { nome = "patricio", genero = "homem", status = "trabalha" },
                 new jovem { nome = "heitor", genero = "homem", status = "trabalha" },
                 new jovem { nome = "vinicius", genero = "homem", status = "trabalha" },
                 new jovem { nome = "matheus", genero = "homem", status = "trabalha" },
                 new jovem { nome = "eduardo", genero = "homem", status = "trabalha" },
                 new jovem { nome = "rodrigo", genero = "homem", status = "trabalha" },
                 new jovem { nome = "marcos", genero = "homem", status = "trabalha" },
                 new jovem { nome = "paulo", genero = "homem", status = "trabalha" },
                 new jovem { nome = "joão", genero = "homem", status = "trabalha" },
                 new jovem { nome = "jonas", genero = "homem", status = "trabalha" },
                 new jovem { nome = "elias", genero = "homem", status = "trabalha" },
                 new jovem { nome = "abrão", genero = "homem", status = "trabalha" },
                 new jovem { nome = "josué", genero = "homem", status = "trabalha" },
                 new jovem { nome = "malaquias", genero = "homem", status = "trabalha" },
                 new jovem { nome = "moabe", genero = "homem", status = "trabalha" },
                 new jovem { nome = "julio", genero = "homem", status = "trabalha" },
                 new jovem { nome = "jesus", genero = "homem", status = "trabalha" },
                 //homens que não trabalha
                 new jovem { nome = "judas", genero = "homem", status = "desempregado" },
                 new jovem { nome = "manuel", genero = "homem", status = "desempregado" },
                 new jovem { nome = "stalen", genero = "homem", status = "desempregado" },
                 new jovem { nome = "alexandre", genero = "homem", status = "desempregado" },
                 new jovem { nome = "luiz", genero = "homem", status = "desempregado" },
                 new jovem { nome = "bial", genero = "homem", status = "desempregado" },
                 new jovem { nome = "rafael", genero = "homem", status = "desempregado" },
                 new jovem { nome = "dora", genero = "homem", status = "desempregado" },
                 new jovem { nome = "castro", genero = "homem", status = "desempregado" },


            };
            Console.WriteLine("Pesquisa Nacional por Amostra de Domicílios Contínua \n");
            Console.WriteLine("Aperte Enter para continuar\n");
            Console.ReadKey();
            Console.WriteLine("\n Lista de todos participantes da pesquisa");
            lista.ForEach(delegate (jovem j)
            {
                Console.WriteLine(String.Format("nome = {0} genero = {1} status = {2}", j.nome, j.genero, j.status));
            });
            Console.WriteLine("\n Precione enter para saber a porcentagem de jovens que trabalha e não trabalha...\n");
            Console.ReadKey();
            lista.ForEach(delegate (jovem j)
            {

                if (j.genero == "homem" && j.status == "desempregado")
                {
                    a += 1;


                }
                if (j.genero == "homem" && j.status == "trabalha")
                {
                    b += 1;


                }
                if (j.genero == "mulher" && j.status == "trabalha")
                {
                    c += 1;
                }
                if (j.genero == "mulher" && j.status == "desempregada")
                {
                    d += 1;
                }


            });
            homensn = (100 / total) * a;
            homenst = (100 / total) * b;
            mulhert = (100 / total) * c;
            mulhern = (100 / total) * d;

            Console.WriteLine("\n Dos entrevistados na pesquisa os jovens homens que não trabalha são {0}% \n", homensn);
            Console.WriteLine("\n Dos entrevistados na pesquisa os jovens homens que  trabalha são {0}% \n", homenst);
            Console.WriteLine("\n Dos entrevistados na pesquisa os jovens mulheres que não trabalha são {0}% \n", mulhern);
            Console.WriteLine("\n Dos entrevistados na pesquisa os jovens mulheres que não trabalha são {0}% \n", mulhert);












        }


    }
}
