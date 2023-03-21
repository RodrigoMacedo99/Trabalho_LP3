using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_LP3
{
    public abstract class Cinemagraph
    {
        String nome;
        int duração;
        string? streaming;
        protected Cinemagraph(string nome, int duração, string? streaming)
        {
            this.nome = nome;
            this.duração = duração;
            this.streaming = streaming;
        }
        //oi mundo ha
    }
}
