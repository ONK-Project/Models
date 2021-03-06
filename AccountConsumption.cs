﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    [BsonIgnoreExtraElements]
    public class AccountConsumption
    {
        public Account Account { get; set; }
        public string UnitOfMeassure { get; set; }
        public string Type { get; set; }
        public double RessourceUsage { get; set; }
        public DateTime TimeStamp { get; set; }
        public SubmissionPrice Price { get; set; }
        public ulong EventSequence { get; set; }
    }
}
