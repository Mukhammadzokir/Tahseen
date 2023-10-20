﻿using Tahseen.Domain.Commons;

namespace Tahseen.Domain.Entities.Books
{
    public class Genre:Auditable
    {
        public string Name { get; set; }
        public IQueryable<Book> Books { get; set;}
    }
}
