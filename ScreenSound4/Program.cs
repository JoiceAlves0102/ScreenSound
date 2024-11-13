using ScreenSound4.Modelos;
using System.Text.Json;
using ScreenSound4.Filtros;
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFiltros.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqFiltros.generosEArtista(musicas, "pop");
        //LinqFiltros.MusicasArtista(musicas, "Wiz Khalifa");
        //LinqOrder.ordemDeArtistas(musicas);
        // LinqFiltros.MusicasAno(musicas, 2012);
        LinqFiltros.TonalidadeDaMusica(musicas);
        //var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[377]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1467]);
        //musicasPreferidasDoDaniel.ExibirMusicasFavoritas();
        //musicasPreferidasDoDaniel.GerarDocumentoTXTComAsMusicasFavoritas();

        //var musicasPreferidasDaEmily = new MusicasPreferidas("Emily");
        //musicasPreferidasDaEmily.AdicionarMusicasFavoritas(musicas[2]);
        //musicasPreferidasDaEmily.AdicionarMusicasFavoritas(musicas[378]);
        //musicasPreferidasDaEmily.AdicionarMusicasFavoritas(musicas[5]);
        //musicasPreferidasDaEmily.AdicionarMusicasFavoritas(musicas[7]);
        //musicasPreferidasDaEmily.AdicionarMusicasFavoritas(musicas[1468]);
        //musicasPreferidasDaEmily.ExibirMusicasFavoritas();
        //musicasPreferidasDaEmily.GerarArquivoJson();
        //musicas[0].ExibirDetalhesDaMusica();

  
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}

