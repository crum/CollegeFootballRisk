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

    public partial class TeamHistory
    {
        /// <summary>
        /// Initializes a new instance of the TeamHistory class.
        /// </summary>
        public TeamHistory() { }

        /// <summary>
        /// Initializes a new instance of the TeamHistory class.
        /// </summary>
        public TeamHistory(int? sequence = default, int? season = default, int? day = default, int? players = default, int? territories = default, int? starPower = default, int? effectivePower = default, TeamHistoryStarBreakdown? starBreakdown = default)
        {
            Sequence = sequence;
            Season = season;
            Day = day;
            Players = players;
            Territories = territories;
            StarPower = starPower;
            EffectivePower = effectivePower;
            StarBreakdown = starBreakdown;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sequence")]
        public int? Sequence { get; set; }

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
        [JsonProperty(PropertyName = "players")]
        public int? Players { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "territories")]
        public int? Territories { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "starPower")]
        public int? StarPower { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectivePower")]
        public int? EffectivePower { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "starBreakdown")]
        public TeamHistoryStarBreakdown? StarBreakdown { get; set; }

    }
}