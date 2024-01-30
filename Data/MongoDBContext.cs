﻿using System;
using MongoDB.Driver;
using simple_mongodb_connection.Models;

namespace simple_mongodb_connection.Data
{
	public class MongoDBContext
	{
        private readonly IMongoDatabase _database;

        public MongoDBContext(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }

        public IMongoCollection<User> Users => _database.GetCollection<User>("users");
    }
}

