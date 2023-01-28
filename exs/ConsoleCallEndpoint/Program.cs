
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using (HttpClient client = new HttpClient())
{
   client.BaseAddress = new Uri("http://localhost:5151");
    var content = new FormUrlEncodedContent(new[]
    {
        new KeyValuePair<string, string>("corDeFundo", "yellow"),
        new KeyValuePair<string, string>("corDoTexto", "black"),
        new KeyValuePair<string, string>("tamanhoDaFonte", "160px"),
        new KeyValuePair<string, string>("conteudoDinamico", "Salvê by from form")
    });
    // var content = new StringContent(JsonConvert.SerializeObject(new {
    //     corDeFundo = "yellow",
    //     corDoTexto = "black",
    //     tamanhoDaFonte = "60px",
    //     conteudoDinamico = "Salvê by httpClient"
    // }), Encoding.UTF8, "application/json");

    // client.DefaultRequestHeaders
    // .Accept
    // .Add(new MediaTypeWithQualityHeaderValue("application/json"));//ACCEPT header

    var result = await client.PostAsync("/WeatherForecast/SalvaPrefencia", content);
    Console.WriteLine(result.RequestMessage);
    string resultContent = await result.Content.ReadAsStringAsync();
    Console.WriteLine(resultContent);
    Console.WriteLine(content);
}

// using (HttpClient client = new HttpClient())
// {
//     HttpResponseMessage response = await client.GetAsync("https://servicodados.ibge.gov.br/api/v2/censos/nomes/ranking");
//     if (response.IsSuccessStatusCode)
//     {
//         string content = await response.Content.ReadAsStringAsync();
//         var res = JsonConvert.DeserializeObject<List<Info>>(content);
//         foreach(var item in res[0].Res){
//             Console.WriteLine(item.Ranking+" ° - "+item.Nome);
//         }
//     }
// }


