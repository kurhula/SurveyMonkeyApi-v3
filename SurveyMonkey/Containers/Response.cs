﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using SurveyMonkey.Enums;

namespace SurveyMonkey.Containers
{
    [JsonConverter(typeof(LaxPropertyNameJsonConverter))]
    public class Response
    {
        public long? Id { get; set; }
        public long? SurveyId { get; set; }
        public long? CollectorId { get; set; }
        public string Href { get; set; }
        public Dictionary<string, string> CustomVariables { get; set; }
        public int? TotalTime { get; set; }
        public string CustomValue { get; set; }
        public string EditUrl { get; set; }
        public string AnalyzeUrl { get; set; }
        public Dictionary<string, object> LogicPath { get; set; } //TODO this structure isn't documented
        public Dictionary<string, object> Metadata { get; set; } //TODO this structure isn't documented
        public List<object> PagePath { get; set; } //TODO this structure isn't documented
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public ResponseStatus? ResponseStatus { get; set; }
        public CollectionMode? CollectionMode { get; set; }
        public string IpAddress { get; set; }
        public long? RecipientId { get; set; }
        public List<ResponsePage> Pages { get; set; }
    }
}