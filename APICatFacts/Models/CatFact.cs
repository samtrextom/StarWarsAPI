using System;
using Newtonsoft.Json;

namespace APISample
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class CatFact
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }


    }
}