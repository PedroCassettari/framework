﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IOC.FW.Core.Abstraction.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IOC.Model
{
    [Table("Genre")]
    public class Genre
        : IModelCreating
    {
        [Key]
        public int IdGenre { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }

        public void OnCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Genre>()
                .HasMany(a => a.Artists)
                .WithMany(g => g.Genres)
                .Map(mp => {
                        mp.ToTable("ArtistGenre");
                        mp.MapLeftKey("IdGenre");
                        mp.MapRightKey("IdArtist");
                    }
                );
        }
    }
}
