using System.ComponentModel.DataAnnotations;

namespace Infra;
public class Preferencias{
    [Key]
    public int Id {get;set;}
    public string? CorDeFundo {get;set;}
    public string? CorDoTexto {get;set;}
    public string? TamanhoDaFonte {get;set;}
    public string? ConteudoDinamico {get;set;}
}