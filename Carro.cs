using System;
using System.Threading;

namespace ExemploEvento
{
    public class Carro
    {
        int qtdTanque = 0;
        public string Telefone { get; set; }

        public Carro(int qtdGasolina, string telefone)
        {
            this.qtdTanque = qtdGasolina;   
            this.Telefone = telefone;         
        }

        public void Ligar()
        {
            while(true){
                Console.WriteLine("Tanque: "+this.qtdTanque);
                Thread.Sleep(1000); //thread.sleep entra no laço, espera o tempo de mili segundos e executa a função
                this.qtdTanque--;

                if(this.qtdTanque.Equals(3)){
                    this.Ligacao(this.Telefone);                    
                }

                if(this.qtdTanque.Equals(0)){
                    this.TanqueVazio(); //TanqueVazio é o evento do carro quando o tanque chegar a zero                 
                    break;
                }
            }
        }

        public delegate void EventoCarro();

        public event EventoCarro TanqueVazio;

        public delegate void Chamar (string texto);
        
        public event Chamar Ligacao;
    }
}