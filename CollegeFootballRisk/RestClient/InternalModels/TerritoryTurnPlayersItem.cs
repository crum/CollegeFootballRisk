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

    public partial class TerritoryTurnPlayersItem
    {
        /// <summary>
        /// Initializes a new instance of the TerritoryTurnPlayersItem class.
        /// </summary>
        public TerritoryTurnPlayersItem() { }

        /// <summary>
        /// Initializes a new instance of the TerritoryTurnPlayersItem class.
        /// </summary>
        public TerritoryTurnPlayersItem(string? team = default, string? player = default, int? stars = default, int? weight = default, double? multiplier = default, bool? mvp = default, double? power = default)
        {
            Team = team;
            Player = player;
            Stars = stars;
            Weight = weight;
            Multiplier = multiplier;
            Mvp = mvp;
            Power = power;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "team")]
        public string? Team { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "player")]
        public string? Player { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stars")]
        public int? Stars { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public int? Weight { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "multiplier")]
        public double? Multiplier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mvp")]
        public bool? Mvp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "power")]
        public double? Power { get; set; }

    }
}
