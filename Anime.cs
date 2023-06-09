﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_LP3
{
    internal class Anime : Cinemagraph, IQtd_eps, IMostrarInfo
    {
        private int ano;
        private int eps;

        public Anime(string nome, int duração, string? streaming, int ano, int eps, string? mandachuva) : base(nome, duração, streaming, mandachuva)
        {
            this.ano = ano;
            this.eps = eps;
        }
        public void mostrarQtdDeEps()
        {

            Console.WriteLine("Quantidade de epidodios: " + this.eps);
        }
        public void mostrarAnoLancamento()
        {
            Console.WriteLine("Ano de lançamento: " + this.ano);
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