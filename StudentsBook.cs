﻿using System;

namespace Dummy_Db
{
    class StudentsBook
    {
        public int BookId { get; set; }
        public int StudentId { get; set; }
        public DateTime DateOfGetting { get; set; }
        public DateTime DateOfReturning { get; set; }
    }
}