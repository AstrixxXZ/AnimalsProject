﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsV2.Data
{
    public class AnimalsContext : DbContext
    {
        public AnimalsContext() : base("AnimalsContext")
        {

        }

        public DbSet<BreedType> BreedTypes { get; set; }
        public DbSet<Animal> Animals { get; set; }
    }
}
