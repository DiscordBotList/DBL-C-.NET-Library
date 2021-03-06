﻿using DiscordBotsList.Api.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace DiscordBotsList.Api.Internal.Queries
{
    internal class BotListQuery : ISearchResult<IDblBot>
    {
        public List<IDblBot> Items => results
            .Cast<IDblBot>()
            .ToList();

        public int CurrentPage => (int)Math.Ceiling((double)offset / limit);

        public int ItemsPerPage => limit;

        public int TotalItems => total;

        public int TotalPages => (int)Math.Ceiling((double)limit / count);

        [JsonPropertyName("results")]
        public List<Bot> results;

        [JsonPropertyName("limit")]
        public int limit;

        [JsonPropertyName("offset")]
        public int offset;

        [JsonPropertyName("count")]
        public int count;

        [JsonPropertyName("total")]
        public int total;
    }
}