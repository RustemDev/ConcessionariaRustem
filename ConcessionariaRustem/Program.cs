using ConcessionariaRustem.Models;
using System;
using System.Collections.Generic;

namespace ConcessionariaRustem
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoEscolhida = 0;
            int quantidadeCarro = 0;
            string marcaEscolhida = "";

            Console.WriteLine("Por favor informe seu nome");

            Cliente cli = new Cliente();
            cli.Nome = Console.ReadLine();

            Console.WriteLine(cli.Nome + " bem vindo a concessionária Rustem!");
            Console.WriteLine("Informe quanto vc tem de grana");
            cli.Saldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("sua grana é de " + cli.Saldo + " vamos comprar uns carros?");

            Console.WriteLine("digite a opção");
            Console.WriteLine("1 - Ford");
            Console.WriteLine("2 - Fiat");
            Console.WriteLine("3 - Jeep");
            Console.WriteLine("4 - volks");
            Console.WriteLine("5 - Renault");
            Console.WriteLine("6 - Toyota");

            opcaoEscolhida = Convert.ToInt32(Console.ReadLine());

            if (opcaoEscolhida == 1)
            {
                marcaEscolhida = "Ford";
            }
            else if(opcaoEscolhida == 2)
            {
                marcaEscolhida = "Fiat";
            }
            else if (opcaoEscolhida == 3)
            {
                marcaEscolhida = "Jeep";
            }
            else if (opcaoEscolhida == 4)
            {
                marcaEscolhida = "Volks";
            }
            else if (opcaoEscolhida == 5)
            {
                marcaEscolhida = "Renault";
            }
            else if (opcaoEscolhida == 6)
            {
                marcaEscolhida = "Toyota";
            }
            else
            {
                Console.WriteLine("Opção errada, tchau");
                return;
            }


            Console.WriteLine("você escolheu a opção " + opcaoEscolhida);
            Console.WriteLine("digite quantos carros vc quer");

            quantidadeCarro = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("você vai comprar " + quantidadeCarro + " carros");

            Console.WriteLine("Estamos preparando os seus carros");

            List<Carro> carros = new List<Carro>();


      


            for (int i = 0; i < quantidadeCarro; i++)
            {
                Carro car = new Carro();

                car.Marca = marcaEscolhida;

                carros.Add(car);
            }

            Console.WriteLine("Carro prontos, veja abaixo");

            for (int i = 0; i < carros.Count; i++)
            {
                Console.WriteLine("marca " + carros[i].Marca);
            }

            Console.ReadLine();
        }
    }
}
