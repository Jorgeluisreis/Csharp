using System;

namespace FichaMedica
{
    class Ficha
    {
        static void Main(string[] args)
        {
            int opcao;

            Cadastro pessoa = new Cadastro();

            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine("-       Ficha Médica       -");
            Console.WriteLine("----------------------------");
            Console.Write("Digite seu Nome: ");
            pessoa.Nome = Convert.ToString(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine("-       Ficha Médica       -");
            Console.WriteLine("----------------------------");
            Console.Write("Digite seu Sobrenome: ");
            pessoa.Sobrenome = Convert.ToString(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine("-       Ficha Médica       -");
            Console.WriteLine("----------------------------");
            Console.Write("Digite sua Idade: ");
            pessoa.Idade = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine("-       Ficha Médica       -");
            Console.WriteLine("----------------------------");
            Console.Write("Digite seu Peso: ");
            pessoa.Peso = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine("-       Ficha Médica       -");
            Console.WriteLine("----------------------------");
            Console.Write("Digite seu Altura: ");
            pessoa.Altura = float.Parse(Console.ReadLine());

        fatorrh:
            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine("-       Ficha Médica       -");
            Console.WriteLine("----------------------------");
            Console.WriteLine("-    Sabe seu Fator RH ?   -");
            Console.WriteLine("-     1- Sim | 2- Não      -");
            Console.WriteLine("----------------------------");
            Console.Write("Resposta: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("-       Ficha Médica       -");
                    Console.WriteLine("----------------------------");
                    Console.Write("Digite seu Fator RH: ");
                    pessoa.FatorRH = Convert.ToString(Console.ReadLine());
                    opcao = 0;
                    goto doenca;
                    break;
                case 2:
                    Console.Clear();
                    pessoa.FatorRH = "Não";
                    opcao = 0;
                    goto doenca;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("-     Entrada inválida     -");
                    Console.WriteLine("-     tente novamente!     -");
                    Console.WriteLine("-Aperte enter para retornar-");
                    Console.WriteLine("----------------------------");
                    opcao = 0;
                    Console.ReadLine();
                    goto fatorrh;
                    break;

            }

        doenca:

            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine("-       Ficha Médica       -");
            Console.WriteLine("----------------------------");
            Console.WriteLine("-    Tem alguma Doença ?   -");
            Console.WriteLine("-     1- Sim | 2- Não      -");
            Console.WriteLine("----------------------------");
            Console.Write("Resposta: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("-       Ficha Médica       -");
                    Console.WriteLine("----------------------------");
                    Console.Write("Digite sua Doença: ");
                    pessoa.Doenca = Convert.ToString(Console.ReadLine());
                    opcao = 0;
                    break;
                case 2:
                    Console.Clear();
                    pessoa.Doenca = "Não";
                    opcao = 0;
                    goto continuidade;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("-     Entrada inválida     -");
                    Console.WriteLine("-     tente novamente!     -");
                    Console.WriteLine("-Aperte enter para retornar-");
                    Console.WriteLine("----------------------------");
                    opcao = 0;
                    Console.ReadLine();
                    goto doenca;


            }
        continuidade:
            Console.Clear();
            Console.WriteLine("-------------------------");
            Console.WriteLine("-     Ficha Médica      -");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Nome: {0} -", pessoa.NomeCompleto);
            Console.WriteLine("Idade: {0} Anos -", pessoa.Idade);
            Console.WriteLine("Peso: {0}kg -", pessoa.Peso);
            Console.WriteLine("Altura: {0}cm -", pessoa.Altura);
            Console.WriteLine("Fator RH: {0} -", pessoa.FatorRH);
            Console.WriteLine("Doença: {0} -", pessoa.Doenca);
            Console.WriteLine("-------------------------");
            Console.ReadLine();



        }
    }
}