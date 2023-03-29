using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_LP3
{
    internal class Serie: Cinemagraph, IQtd_eps, IMostrarInfo
    {
        private int eps;

        public Serie(string nome, int duracao, string? streaming, string? mandaChuva, int eps) : base(nome, duracao, streaming, mandaChuva)
        {
            this.eps = eps;
        }

        public void mostrarQtdDeEps()
        {
            Console.WriteLine("Quantidade de epidodios: " + this.eps);
        }

        public void mostrarInfo()
        {
            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Duracao: " + this.duracao + "min");
            Console.WriteLine("Streaming: " + this.streaming);
            this.mostrarQtdDeEps();
            this.mostrarMandaChuva();
            Console.WriteLine("----------------------------------------------------\n");
        }
    }
}
