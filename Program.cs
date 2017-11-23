using System;

namespace ExemploEvento
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro (10, "4833331666"); //Carro com 10l de gasolina
            carro.TanqueVazio += new Carro.EventoCarro(tanque_vazio); //adicionando os eventos dentro do carro. quando ocorrer o TanqueVazio (evento) deve ocorrer o método tanque_vazio
            carro.TanqueVazio += new Carro.EventoCarro(ligar_uber);
            carro.Ligacao += new Carro.Chamar(ligar_casa);
            carro.Ligar();
        }
        static void tanque_vazio(){
            Console.WriteLine("Tanque vazio");
        }
        static void ligar_uber(){
            Console.WriteLine("Ligue para o Uber");
        }
        static void ligar_casa(string telefone){
            Console.WriteLine("Ligar telefone: "+telefone);
        }
    }
}
