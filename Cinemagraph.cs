using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_LP3
{
    public abstract class Cinemagraph
    {
        public String nome;
        public int duracao;
        public string? streaming;
        public string? mandaChuva;
        protected Cinemagraph(string nome, int duracao, string? streaming, string? mandaChuva)
        {
            this.nome = nome;
            this.streaming = streaming;
            this.duracao = duracao;
            this.mandaChuva = mandaChuva;
        }

        public virtual void mostrarInfo()
        {
            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Duracao: " + this.duracao); //adicionar exemplo de medida de tempo
            Console.WriteLine("Streaming: " + this.streaming);
            Console.WriteLine("----------------------------------------------------\n");
        }

        public void mostrarMandaChuva()
        {
            Console.WriteLine("O diretor dessa joça é: "+ this.mandaChuva);
        }
    }
}
