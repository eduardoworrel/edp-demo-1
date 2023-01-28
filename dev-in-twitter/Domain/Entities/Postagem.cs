using System.ComponentModel.DataAnnotations;
namespace Domain.Entities;

public class Postagem : BaseEntity{
    public string NomeUsuario {get;set;}
    public string ConteudoPublicado {get;set;}
    public DateTime DataHoraPublicacao {get;set;}
}