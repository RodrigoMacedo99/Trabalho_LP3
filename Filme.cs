using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_LP3
{
    internal class Filme : Cinemagraph
    {
        string? adaptação;

        public Filme(string nome, int duração, string? streaming, string? adaptação, string? mandachuva) : base(nome, duração, streaming, mandachuva)
        {
            this.adaptação = adaptação;
        }

        public void mostrarInfoFilme()
        {
            this.mostrarInfo();
        }
    }
}
