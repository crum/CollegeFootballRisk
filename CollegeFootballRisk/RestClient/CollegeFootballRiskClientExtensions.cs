﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace CollegeFootballRisk.RestClient
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using InternalModels;

    /// <summary>
    /// Extension methods for CollegeFootballRiskClient.
    /// </summary>
    public static partial class CollegeFootballRiskClientExtensions
    {
            /// <summary>
            /// Player information
            /// </summary>
            /// Player information
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='player'>
            /// Player username without the "u/" (e.g. "u/BlueSCar" would just be
            /// "BlueSCar")
            /// </param>
            public static Player GetPlayer(this ICollegeFootballRiskClient operations, string player)
            {
                return Task.Factory.StartNew(s => ((ICollegeFootballRiskClient)s).GetPlayerAsync(player), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }


        /// <summary>
        /// Player information
        /// </summary>
        /// Player information
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='player'>
        /// Player username without the "u/" (e.g. "u/BlueSCar" would just be
        /// "BlueSCar")
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0063:Use simple 'using' statement", Justification = "The recommended style is ugly")]
        public static async Task<Player> GetPlayerAsync(this ICollegeFootballRiskClient operations, string player, CancellationToken cancellationToken = default)
            {
                using (var _result = await operations.GetPlayerWithHttpMessagesAsync(player, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List of players
            /// </summary>
            /// List of players
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='team'>
            /// Team name filter
            /// </param>
            public static IList<TeamPlayer> GetPlayers(this ICollegeFootballRiskClient operations, string? team = default)
            {
                return Task.Factory.StartNew(s => ((ICollegeFootballRiskClient)s).GetPlayersAsync(team), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }


        /// <summary>
        /// List of players
        /// </summary>
        /// List of players
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='team'>
        /// Team name filter
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0063:Use simple 'using' statement", Justification = "The recommended style is ugly")]
        public static async Task<IList<TeamPlayer>> GetPlayersAsync(this ICollegeFootballRiskClient operations, string? team = default, CancellationToken cancellationToken = default)
            {
                using (var _result = await operations.GetPlayersWithHttpMessagesAsync(team, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Game leaderboard
            /// </summary>
            /// Game leaderboard
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='season'>
            /// Season number
            /// </param>
            /// <param name='day'>
            /// Day number
            /// </param>
            public static IList<LeaderboardTeam> GetLeaderboard(this ICollegeFootballRiskClient operations, int season, int day)
            {
                return Task.Factory.StartNew(s => ((ICollegeFootballRiskClient)s).GetLeaderboardAsync(season, day), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }


        /// <summary>
        /// Game leaderboard
        /// </summary>
        /// Game leaderboard
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='season'>
        /// Season number
        /// </param>
        /// <param name='day'>
        /// Day number
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0063:Use simple 'using' statement", Justification = "The recommended style is ugly")]
        public static async Task<IList<LeaderboardTeam>> GetLeaderboardAsync(this ICollegeFootballRiskClient operations, int season, int day, CancellationToken cancellationToken = default)
            {
                using (var _result = await operations.GetLeaderboardWithHttpMessagesAsync(season, day, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get turns list
            /// </summary>
            /// List of turns
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<Turn> GetTurns(this ICollegeFootballRiskClient operations)
            {
                return Task.Factory.StartNew(s => ((ICollegeFootballRiskClient)s).GetTurnsAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }


        /// <summary>
        /// Get turns list
        /// </summary>
        /// List of turns
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0063:Use simple 'using' statement", Justification = "The recommended style is ugly")]
        public static async Task<IList<Turn>> GetTurnsAsync(this ICollegeFootballRiskClient operations, CancellationToken cancellationToken = default)
            {
                using (var _result = await operations.GetTurnsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get current team strength
            /// </summary>
            /// Team strength for the most recent turns
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='team'>
            /// Team name
            /// </param>
            public static TeamStrength GetTeamStrength(this ICollegeFootballRiskClient operations, string team)
            {
                return Task.Factory.StartNew(s => ((ICollegeFootballRiskClient)s).GetTeamStrengthAsync(team), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }


        /// <summary>
        /// Get current team strength
        /// </summary>
        /// Team strength for the most recent turns
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='team'>
        /// Team name
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0063:Use simple 'using' statement", Justification = "The recommended style is ugly")]
        public static async Task<TeamStrength> GetTeamStrengthAsync(this ICollegeFootballRiskClient operations, string team, CancellationToken cancellationToken = default)
            {
                using (var _result = await operations.GetTeamStrengthWithHttpMessagesAsync(team, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get historical team stats
            /// </summary>
            /// Historical team statistics
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='team'>
            /// Team name
            /// </param>
            public static IList<TeamHistory> GetTeamHistory(this ICollegeFootballRiskClient operations, string team)
            {
                return Task.Factory.StartNew(s => ((ICollegeFootballRiskClient)s).GetTeamHistoryAsync(team), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }


        /// <summary>
        /// Get historical team stats
        /// </summary>
        /// Historical team statistics
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='team'>
        /// Team name
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0063:Use simple 'using' statement", Justification = "The recommended style is ugly")]
        public static async Task<IList<TeamHistory>> GetTeamHistoryAsync(this ICollegeFootballRiskClient operations, string team, CancellationToken cancellationToken = default)
            {
                using (var _result = await operations.GetTeamHistoryWithHttpMessagesAsync(team, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get players moves by turn
            /// </summary>
            /// Get player moves by turn
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='season'>
            /// Season filter
            /// </param>
            /// <param name='day'>
            /// Day filter
            /// </param>
            /// <param name='team'>
            /// Team name filter
            /// </param>
            public static IList<TeamTurnPlayer> GetPlayerMovesByTurn(this ICollegeFootballRiskClient operations, int season, int day, string? team = default)
            {
                return Task.Factory.StartNew(s => ((ICollegeFootballRiskClient)s).GetPlayerMovesByTurnAsync(season, day, team), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }


        /// <summary>
        /// Get players moves by turn
        /// </summary>
        /// Get player moves by turn
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='season'>
        /// Season filter
        /// </param>
        /// <param name='day'>
        /// Day filter
        /// </param>
        /// <param name='team'>
        /// Team name filter
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0063:Use simple 'using' statement", Justification = "The recommended style is ugly")]
        public static async Task<IList<TeamTurnPlayer>> GetPlayerMovesByTurnAsync(this ICollegeFootballRiskClient operations, int season, int day, string? team = default, CancellationToken cancellationToken = default)
            {
                using (var _result = await operations.GetPlayerMovesByTurnWithHttpMessagesAsync(season, day, team, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get list of teams
            /// </summary>
            /// Teams list
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<Team> GetTeams(this ICollegeFootballRiskClient operations)
            {
                return Task.Factory.StartNew(s => ((ICollegeFootballRiskClient)s).GetTeamsAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }


        /// <summary>
        /// Get list of teams
        /// </summary>
        /// Teams list
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0063:Use simple 'using' statement", Justification = "The recommended style is ugly")]
        public static async Task<IList<Team>> GetTeamsAsync(this ICollegeFootballRiskClient operations, CancellationToken cancellationToken = default)
            {
                using (var _result = await operations.GetTeamsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get list of territories, including ownership status for the given turn
            /// </summary>
            /// Territories list
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='season'>
            /// Season filter
            /// </param>
            /// <param name='day'>
            /// Day filter
            /// </param>
            public static IList<Territory> GetTerritories(this ICollegeFootballRiskClient operations, int? season = default, int? day = default)
            {
                return Task.Factory.StartNew(s => ((ICollegeFootballRiskClient)s).GetTerritoriesAsync(season, day), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }


        /// <summary>
        /// Get list of territories, including ownership status for the given turn
        /// </summary>
        /// Territories list
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='season'>
        /// Season filter
        /// </param>
        /// <param name='day'>
        /// Day filter
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0063:Use simple 'using' statement", Justification = "The recommended style is ugly")]
        public static async Task<IList<Territory>> GetTerritoriesAsync(this ICollegeFootballRiskClient operations, int? season = default, int? day = default, CancellationToken cancellationToken = default)
            {
                using (var _result = await operations.GetTerritoriesWithHttpMessagesAsync(season, day, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get historical territory data
            /// </summary>
            /// Historical territory data
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='territory'>
            /// Territory name
            /// </param>
            /// <param name='season'>
            /// Season
            /// </param>
            public static IList<TerritoryHistory> GetTerritoryHistory(this ICollegeFootballRiskClient operations, string territory, int season)
            {
                return Task.Factory.StartNew(s => ((ICollegeFootballRiskClient)s).GetTerritoryHistoryAsync(territory, season), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }


        /// <summary>
        /// Get historical territory data
        /// </summary>
        /// Historical territory data
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='territory'>
        /// Territory name
        /// </param>
        /// <param name='season'>
        /// Season
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0063:Use simple 'using' statement", Justification = "The recommended style is ugly")]
        public static async Task<IList<TerritoryHistory>> GetTerritoryHistoryAsync(this ICollegeFootballRiskClient operations, string territory, int season, CancellationToken cancellationToken = default)
            {
                using (var _result = await operations.GetTerritoryHistoryWithHttpMessagesAsync(territory, season, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get territory statistics for a specific turn
            /// </summary>
            /// Territory statistics for a specific turn
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='territory'>
            /// Territory name
            /// </param>
            /// <param name='season'>
            /// Season
            /// </param>
            /// <param name='day'>
            /// Day
            /// </param>
            public static IList<TerritoryTurn> GetTerritoryTurn(this ICollegeFootballRiskClient operations, string territory, int season, int day)
            {
                return Task.Factory.StartNew(s => ((ICollegeFootballRiskClient)s).GetTerritoryTurnAsync(territory, season, day), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }


        /// <summary>
        /// Get territory statistics for a specific turn
        /// </summary>
        /// Territory statistics for a specific turn
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='territory'>
        /// Territory name
        /// </param>
        /// <param name='season'>
        /// Season
        /// </param>
        /// <param name='day'>
        /// Day
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0063:Use simple 'using' statement", Justification = "The recommended style is ugly")]
        public static async Task<IList<TerritoryTurn>> GetTerritoryTurnAsync(this ICollegeFootballRiskClient operations, string territory, int season, int day, CancellationToken cancellationToken = default)
            {
                using (var _result = await operations.GetTerritoryTurnWithHttpMessagesAsync(territory, season, day, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}