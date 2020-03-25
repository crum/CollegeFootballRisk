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

    public partial class Player
    {
        /// <summary>
        /// Initializes a new instance of the Player class.
        /// </summary>
        public Player() { }

        /// <summary>
        /// Initializes a new instance of the Player class.
        /// </summary>
        public Player(string? name = default, PlayerTeam? team = default, PlayerRatings? ratings = default, PlayerStats? stats = default, IList<PlayerTurnsItem>? turns = default)
        {
            Name = name;
            Team = team;
            Ratings = ratings;
            Stats = stats;
            Turns = turns;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "team")]
        public PlayerTeam? Team { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ratings")]
        public PlayerRatings? Ratings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stats")]
        public PlayerStats? Stats { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "turns")]
        public IList<PlayerTurnsItem>? Turns { get; set; }

    }
}