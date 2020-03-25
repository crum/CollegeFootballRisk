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

    public partial class TeamHistoryStarBreakdown
    {
        /// <summary>
        /// Initializes a new instance of the TeamHistoryStarBreakdown class.
        /// </summary>
        public TeamHistoryStarBreakdown() { }

        /// <summary>
        /// Initializes a new instance of the TeamHistoryStarBreakdown class.
        /// </summary>
        public TeamHistoryStarBreakdown(int? ones = default, int? twos = default, int? threes = default, int? fours = default, int? fives = default)
        {
            Ones = ones;
            Twos = twos;
            Threes = threes;
            Fours = fours;
            Fives = fives;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ones")]
        public int? Ones { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "twos")]
        public int? Twos { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "threes")]
        public int? Threes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fours")]
        public int? Fours { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fives")]
        public int? Fives { get; set; }

    }
}
