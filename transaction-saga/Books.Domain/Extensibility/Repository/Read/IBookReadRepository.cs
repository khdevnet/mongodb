﻿using System;
using System.Collections.Generic;

namespace Books.Domain.Read.Repository
{
    public interface IBookReadRepository
    {
        Book Add(Book book);
        Guid Delete(Guid id);
        IReadOnlyCollection<Book> CreateBulk(IReadOnlyCollection<Book> books);
        IReadOnlyCollection<Book> Get();
        Book Get(Guid id);
        void Clear();
    }
}