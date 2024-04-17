﻿namespace LibraryManagement.Core.Dtos.Request
{
    public class AuthorRequestDto
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public List<BookRequestDto> Books { get; set; }
    }
}
