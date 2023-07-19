using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace simplecalculator
{
    internal class Databasehandler
    {
        private IMongoCollection<BsonDocument> collection;

        public Databasehandler(string connectionString, string databaseName, string collectionName)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            collection = database.GetCollection<BsonDocument>(collectionName);
        }

        public void StoreCalculationData(int operand1, int operand2, string operation, int result)
        {
            var document = new BsonDocument
            {
                { "Operand1", operand1 },
                { "Operand2", operand2 },
                { "Operation", operation },
                { "Result", result }
            };
            collection.InsertOne(document);
        }
    }
}
