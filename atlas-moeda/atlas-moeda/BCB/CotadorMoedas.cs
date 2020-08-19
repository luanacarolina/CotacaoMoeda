using atlas_moeda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace atlas_moeda.BCB
{
    public static class CotadorMoedas
    {
        private static readonly HttpClient client = new HttpClient();
           
        public static async Task<List<Requisicao>> ProcessRepositories()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var url = client.GetStringAsync("https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/CotacaoMoedaDia(moeda=@moeda,dataCotacao=@dataCotacao)?@moeda='EUR'&@dataCotacao='07-08-2020'&$top=1&$skip=0&$filter=tipoBoletim%20eq%20'Fechamento%20PTAX'&$format=json&$select=cotacaoVenda");
            var repositories =  JsonSerializer.Deserialize<List<Requisicao>>( url.Result);
            return repositories;
        }
          /*  static async Task<Requisicao> GetCotadorAsync(string path)
        {
            Requisicao requisicao = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                requisicao= await response.Content.ReadAsAsync<Requisicao>();
            }
        }*/
        public static double CotarMoeda(string Moeda, DateTime data)
        {
            var repositories =  ProcessRepositories();
               
            return 0;
        }
    }
}
