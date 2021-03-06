﻿
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using Shop.Domain.Entities;
using System.Collections.Generic;

namespace Shop.Infra.Data
{
    public  class BaseRepository : IBaseRepository
    {
        MongoClient _client;
        IMongoDatabase _database;
        IMongoCollection<Produto> _collection;
        private IConfiguration _configuration;
        public BaseRepository(IConfiguration config)
        {
            _configuration = config;
            _client = new MongoClient(config.GetConnectionString("DefaultConnection"));
            _database = _client.GetDatabase("shop");
            _collection = _database.GetCollection<Produto>("Produtos");
        }

        public List<Produto> GetAll() { return _collection.Find(new BsonDocument()).ToList(); }

        public Produto Insert(Produto produto) 
        {
            _collection.InsertOne(produto);
            return produto;
        }

        public Produto Get(string nome)
        {
            return _collection.Find(p => p.Nome == nome).FirstOrDefault();
        }
    }
}
