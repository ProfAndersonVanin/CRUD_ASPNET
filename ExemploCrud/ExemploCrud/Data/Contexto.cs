﻿using ExemploCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace ExemploCrud.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        { }

        public DbSet<Usuario> Usuario { get; set; }

    }
}
