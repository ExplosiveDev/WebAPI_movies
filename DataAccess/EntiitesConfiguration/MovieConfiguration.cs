﻿using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace DataAccess.EntiitesConfiguration
{
    public class MovieConfiguration:IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder) {

            //Set Primary Key
            builder.HasKey(x => x.Id);

            //Set Property configurations
            builder.Property(x => x.Title)
                   .HasMaxLength(180)
                   .IsRequired();

            builder.Property(x => x.Description)
                   .HasMaxLength(1024);
        }
    }
}
