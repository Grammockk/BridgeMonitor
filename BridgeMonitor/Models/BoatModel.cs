using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgeMonitor.Models
{
    public class BoatModel
    {
        [JsonProperty("reopening_date")]
        public DateTime ReopeningDate { get; set; }
        
        [JsonProperty("closing_type")]
        public string ClosingType { get; set; }

        [JsonProperty("closing_date")]
        public DateTime ClosingDate { get; set; }

        [JsonProperty("boat_name")]
        public string BoatName { get; set; }


        
    }