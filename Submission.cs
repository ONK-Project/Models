using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    [Serializable]
    public class Submission
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string SubmissionId { get; set; }
        public MeteringUnit MeteringUnit { get; set; }
        public SubmissionPrice SubmissionPrice { get; set; }
        public DateTime DateTime { get; set; }
        public double RessourceUsage { get; set; }
        public string UnitOfMeassure { get; set; }
    }
}
