using Infra;

var db = new PreferenciasContext();
var p = db.Preferencias.First();
Console.WriteLine(p.CorDeFundo);
