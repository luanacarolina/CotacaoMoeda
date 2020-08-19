using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace atlas_moeda.Models
{
    public class Requisicao
    {
        [JsonPropertyName("cotacaoVenda")]
        public string cotacaoVenda { get; set; }

    }
}
