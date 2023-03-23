using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_LP3
{
    internal class Filme : Cinemagraph, IMostrarInfo
    {
        string? adaptação;

        public Filme(string nome, int duração, string? streaming, string? adaptação, string? mandachuva) : base(nome, duração, streaming, mandachuva)
        {
            this.adaptação = adaptação;
        }

        public void mostrarAdap()
        {
            Console.WriteLine("Obra original: " + this.adaptação);
        }
        public void mostrarInfo()
        {
            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Duracao: " + this.duracao + "h");
            Console.WriteLine("Streaming: " + this.streaming);
            this.mostrarAdap();
            this.mostrarMandaChuva();
            Console.WriteLine("----------------------------------------------------\n");
        }
    }
}
