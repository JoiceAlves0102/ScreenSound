using System.Text.Json.Serialization;

namespace ScreenSound4.Modelos;

internal class Musica
{
    private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    //traduz a variavel do json, transformando em classe
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("key")]
    public int Tom { get; set; }
    public string Tonalidade {
        get
        {
            return tonalidades[Tom];
        }
     }

    [JsonPropertyName("year")]
    public string? AnoString { get; set; }
    public int Ano
    {
        get
        {
            return int.Parse(AnoString!);
        }
    }
    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Duração em segundos: {Duracao / 1000}");
        Console.WriteLine($"Gênero musical: {Genero}");
        Console.WriteLine($"Tonalidade musical: {Tonalidade}");
    }
}
