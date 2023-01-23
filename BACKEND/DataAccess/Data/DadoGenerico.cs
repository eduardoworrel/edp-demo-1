using System.ComponentModel.DataAnnotations;
public class DadoGenerico
{
    [KeyAttribute]
    public int Id {get;set;}
    public string Chave {get; set;}
    public string? Valor {get; set;}
}