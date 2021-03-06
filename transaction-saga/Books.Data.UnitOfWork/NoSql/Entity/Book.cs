﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Books.Data.UnitOfWork.NoSql.Entity
{
    public class Book
    {
        [BsonId]
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Path { get; set; }

        public string Author { get; set; }

        public string Status { get; set; }
    }
}
