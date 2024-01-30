using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace simple_mongodb_connection.Models
{
	public class User
	{
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("uuid")]
        public string Uuid { get; set; }

        [BsonElement("company_id")]
        public string CompanyId { get; set; }

        [BsonElement("first_name")]
        public string FirstName { get; set; }

        [BsonElement("last_name")]
        public string LastName { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("deleted_at")]
        public DateTime? DeletedAt { get; set; }

        [BsonElement("roles")]
        public List<object> Roles { get; set; }

        [BsonElement("token")]
        public string Token { get; set; }

        [BsonElement("__v")]
        public int Version { get; set; }
    }
}

