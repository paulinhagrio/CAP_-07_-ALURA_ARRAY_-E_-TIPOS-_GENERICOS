using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui criaremos o ARRAY ContaCorrente:
            // Tipo: ContaCorrente[], nome: contas = , valor: tipo ContaCorrente[o nº de conta corrente que quero criar]

            ContaCorrente[] contas = new ContaCorrente[3];

            contas[0] = new ContaCorrente(874, 5679787);
            contas[1] = new ContaCorrente(874, 4456668);
            contas[2] = new ContaCorrente(874, 7781438);

            for(int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }

            Console.ReadLine();

        }

        static void TestaArrayInt()
        {

            //ARRAY DE INTEIROS, COM 5 POSIÇÕES:
            int[] idades = null;
            idades = new int[3];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            //idades[3] = 50;
            //idades[4] = 28;
            //idades[5] = 60;

            Console.WriteLine(idades.Length);

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Media de idades = {media}");

            Console.ReadLine();
        }
    }
}
