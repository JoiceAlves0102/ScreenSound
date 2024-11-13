﻿using ScreenSound4.Modelos;
namespace ScreenSound4.Filtros;

internal class LinqOrder
{
    public static void ordemDeArtistas(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine("\n Lista de artistas ordenados");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"-{artista}");
        }
    }
}
