﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RazorPagesSample.Models;

namespace RazorPagesSample.Data.Configurations;

public partial class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> entity)
    {
        entity.ToTable("User");

        entity.Property(e => e.Name).IsRequired();
        entity.Property(e => e.Password).IsRequired();

        entity.Property(e => e.Password).HasConversion(
            v => BC.HashPassword(v),
            v => v);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<User> entity);
        
}