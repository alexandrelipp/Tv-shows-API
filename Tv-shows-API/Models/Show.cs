using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using MongoDB.Bson;
using System.Linq;
using System.Threading.Tasks;

namespace Tv_shows_API.Models
{
    public class Show
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }
        public int Grade { get; set; }
        public List<string> Authors { get; set; }
    }
}
