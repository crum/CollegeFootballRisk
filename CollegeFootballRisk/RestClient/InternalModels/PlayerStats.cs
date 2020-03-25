﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace CollegeFootballRisk.InternalModels
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class PlayerStats
    {
        /// <summary>
        /// Initializes a new instance of the PlayerStats class.
        /// </summary>
        public PlayerStats() { }

        /// <summary>
        /// Initializes a new instance of the PlayerStats class.
        /// </summary>
        public PlayerStats(int? totalTurns = default(int?), int? gameTurns = default(int?), int? mvps = default(int?), int? streak = default(int?), int? awards = default(int?))
        {
            TotalTurns = totalTurns;
            GameTurns = gameTurns;
            Mvps = mvps;
            Streak = streak;
            Awards = awards;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalTurns")]
        public int? TotalTurns { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gameTurns")]
        public int? GameTurns { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mvps")]
        public int? Mvps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "streak")]
        public int? Streak { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "awards")]
        public int? Awards { get; set; }

    }
}