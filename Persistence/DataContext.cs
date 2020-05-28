﻿using Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Persistence
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }
    }
}
