using ScreenSound4.Modelos;
using System.Linq;
using System.Security.AccessControl;


namespace ScreenSound4.Filtros;

internal class LinqFiltros
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"-{genero}");
        }
    }
    public static void generosEArtista(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine("Exibindo os artistas por gênero musical >>>");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"-{artista}");
        }
    }
    public static void MusicasArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"-{musica.Nome}");
        }
    }

    public static void MusicasAno(List<Musica> musicas, int ano)
    {
        var musicasAno = musicas.Where(musica => musica.Ano == ano).OrderBy(musicas => musicas.Nome).Select(musicas => musicas.Nome).Distinct().ToList();
        Console.WriteLine("\n Exibindo as músicas por ano");
        foreach (var musica in musicasAno)
        {
            Console.WriteLine($"-{musica}");
        }

    }

    public static void TonalidadeDaMusica(List<Musica> musicas)
    {
        var tonalidadesDaMusica = musicas.Where(musica => musica.Tonalidade.Equals("C#")).Select(musica => musica.Nome).ToList();
        foreach (var tonalidade in tonalidadesDaMusica)
        {
            Console.WriteLine($" - {tonalidade}");
        }
    }

}
