public class Info{
    public string Localidade {get;set;}
    public string? Sexo {get;set;}
    public List<Unidade> Res {get;set;}
}

public class Unidade{
     public string Nome {get;set;}
    public long Frequencia {get;set;}
    public int Ranking {get;set;}
}