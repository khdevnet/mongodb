﻿using System;

namespace Books.Domain
{
    public class Book
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Path { get; set; }

        public string Author { get; set; }
    }
}
