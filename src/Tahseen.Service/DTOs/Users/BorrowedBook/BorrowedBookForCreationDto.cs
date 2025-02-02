﻿using Tahseen.Domain.Enums;

namespace Tahseen.Service.DTOs.Users.BorrowedBook
{
    public class BorrowedBookForCreationDto
    {
        public long UserId { get; set; }
        public long BookId { get; set; }
        public DateTime ReturnDate { get; set; }
        public BorrowedBookStatus Status { get; set; }
        public decimal FineAmount { get; set; }
    }
}
