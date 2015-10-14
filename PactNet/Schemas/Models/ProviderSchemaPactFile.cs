﻿using System.Collections.Generic;
using Newtonsoft.Json;
using PactNet.Models;

namespace PactNet.Schemas.Models
{
    class ProviderSchemaPactFile : PactFile
    {
        [JsonProperty(PropertyName = "schemas")]
        public IEnumerable<ProviderDataSchema> Schemas { get; set; }
    }
}
