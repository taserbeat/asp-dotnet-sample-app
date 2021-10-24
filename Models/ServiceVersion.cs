using System;
using Newtonsoft.Json;

namespace asp_dotnet_sample_app.Models
{
    /// <summary>
    /// サービスのバージョンモデル
    /// </summary>
    /// <remarks>https://mikewilliams.io/net-core-3-jsonproperty-not-working-53f62f288f15</remarks>
    public class ServiceVersion
    {
        [JsonProperty("version")]
        public string Version { get; set; } = "0.0.1";

        [JsonProperty("release")]
        public string Release { get; set; }
            = DateTime.Parse("2021/10/24").ToString("yyyy-MM-dd");
    }
}
