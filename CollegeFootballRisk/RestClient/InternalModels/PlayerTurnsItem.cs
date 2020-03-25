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

    public partial class PlayerTurnsItem
    {
        /// <summary>
        /// Initializes a new instance of the PlayerTurnsItem class.
        /// </summary>
        public PlayerTurnsItem() { }

        /// <summary>
        /// Initializes a new instance of the PlayerTurnsItem class.
        /// </summary>
        public PlayerTurnsItem(int? season = default, int? day = default, int? stars = default, bool? mvp = default, string? territory = default, string? team = default)
        {
            Season = season;
            Day = day;
            Stars = stars;
            Mvp = mvp;
            Territory = territory;
            Team = team;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "season")]
        public int? Season { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "day")]
        public int? Day { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stars")]
        public int? Stars { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mvp")]
        public bool? Mvp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "territory")]
        public string? Territory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "team")]
        public string? Team { get; set; }

    }
}
