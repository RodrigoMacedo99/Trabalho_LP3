﻿// See https://aka.ms/new-console-template for more information
using Trabalho_LP3;

internal class Program
{
    private static void Main(string[] args)
    {
        Filme laranjinha = new Filme("Laranjinha ataca novamente", 2, "Netflix", "LN: Fui transportado para outro mundo como uma laranja!", "Patolino");
        Serie lapa = new Serie("Lapa in the UK", 15, "Star+", "Carol Paim", 20);
        Anime soussa = new Anime("Soussa contra as bruxinhas", 20, "Crunchyroll", 2019, 30, "Murilo");

        /*
        laranjinha.mostrarInfoFilme();
        lapa.mostrarInfoSerie();
        soussa.mostrarInfo();
        */


        //Pela utilização da mesma interface a chamada de metodos tb é simplificada já que é utilizada o msm nome agr
        laranjinha.mostrarInfo();
        lapa.mostrarInfo();
        soussa.mostrarInfo();

    }
}