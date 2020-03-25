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

    public partial class PlayerTeamColors
    {
        /// <summary>
        /// Initializes a new instance of the PlayerTeamColors class.
        /// </summary>
        public PlayerTeamColors() { }

        /// <summary>
        /// Initializes a new instance of the PlayerTeamColors class.
        /// </summary>
        public PlayerTeamColors(string? primary = default, string? secondary = default)
        {
            Primary = primary;
            Secondary = secondary;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primary")]
        public string? Primary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "secondary")]
        public string? Secondary { get; set; }

    }
}