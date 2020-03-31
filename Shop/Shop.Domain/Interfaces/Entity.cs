
using MongoDB.Bson;
using System;

namespace Shop.Domain.Interfaces
{
    public abstract class Entity
    {
        public ObjectId Id { get; set; }
    }
}
