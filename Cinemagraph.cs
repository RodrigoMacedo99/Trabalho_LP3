﻿using System;
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

<<<<<<< HEAD
        public virtual void mostrarInfo()
        {
            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine("Nome: " + this.nome);
<<<<<<< HEAD
            Console.WriteLine("Duracao: " + this.duracao);
=======
            Console.WriteLine("Duracao: " + this.duracao); //adicionar exemplo de medida de tempo
>>>>>>> ff18debee3f0fe102ad64ace1476c68941a18073
            Console.WriteLine("Streaming: " + this.streaming);
            Console.WriteLine("----------------------------------------------------\n");
        }

=======
>>>>>>> b0357031eba643aea259afec455d6cd15e58324d
        public void mostrarMandaChuva()
        {
            Console.WriteLine("O diretor dessa joça é: "+ this.mandaChuva); //Mantemos essa função para ficar como "mal exemplo"
        }
    }
}
