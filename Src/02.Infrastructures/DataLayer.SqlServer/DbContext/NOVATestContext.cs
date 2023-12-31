﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DomainClass.Models;

public partial class NOVATestContext : DbContext
{
    public NOVATestContext(DbContextOptions<NOVATestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Altersklassen> Altersklassens { get; set; }

    public virtual DbSet<Gewichtsklassen> Gewichtsklassens { get; set; }

    public virtual DbSet<Teilnehmer> Teilnehmers { get; set; }

    public virtual DbSet<Verbaende> Verbaendes { get; set; }

    public virtual DbSet<Vereine> Vereines { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Altersklassen>(entity =>
        {
            entity.HasKey(e => e.AklassenId);

            entity.ToTable("Altersklassen");

            entity.Property(e => e.AklassenId)
                .ValueGeneratedNever()
                .HasColumnName("AKlassenID");
            entity.Property(e => e.AklassenName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AKlassenName");
            entity.Property(e => e.Gewichtsklassen)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Stilart)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Gewichtsklassen>(entity =>
        {
            entity.ToTable("Gewichtsklassen");

            entity.Property(e => e.GewichtsKlassenId)
                .ValueGeneratedNever()
                .HasColumnName("GewichtsKlassenID");
            entity.Property(e => e.AklassenId).HasColumnName("AKlassenID");
        });

        modelBuilder.Entity<Teilnehmer>(entity =>
        {
            entity.HasKey(e => e.Nr);

            entity.ToTable("Teilnehmer");

            entity.Property(e => e.Nr).ValueGeneratedNever();
            entity.Property(e => e.AklassenId).HasColumnName("AKlassenId");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(30);
            entity.Property(e => e.Pool)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.PoolPlatz).HasMaxLength(2);
            entity.Property(e => e.Verband).HasMaxLength(4);
        });

        modelBuilder.Entity<Verbaende>(entity =>
        {
            entity.HasKey(e => e.LandesVerband);

            entity.ToTable("Verbaende");

            entity.Property(e => e.LandesVerband).HasMaxLength(5);
            entity.Property(e => e.Email)
                .HasMaxLength(40)
                .HasColumnName("EMail");
            entity.Property(e => e.Info).HasColumnType("text");
            entity.Property(e => e.InternetAdresse).HasMaxLength(80);
            entity.Property(e => e.VerbandsGuid).HasColumnName("VerbandsGUID");
            entity.Property(e => e.Verbandsname).HasMaxLength(50);
        });

        modelBuilder.Entity<Vereine>(entity =>
        {
            entity.HasKey(e => e.VereinsNr);

            entity.ToTable("Vereine");

            entity.Property(e => e.VereinsNr).ValueGeneratedNever();
            entity.Property(e => e.Bezirk).HasMaxLength(5);
            entity.Property(e => e.Landesverband).HasMaxLength(5);
            entity.Property(e => e.VereinBez).HasMaxLength(40);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}