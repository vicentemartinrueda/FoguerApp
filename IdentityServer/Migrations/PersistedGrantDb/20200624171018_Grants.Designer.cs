﻿// <auto-generated />
using System;
using IdentityServer4.EntityFramework.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlendhubAPI.AuthServer.Migrations.PersistedGrantDb
{
    [DbContext(typeof(PersistedGrantDbContext))]
    [Migration("20200624171018_Grants")]
    partial class Grants
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("DATE");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(50000);

                    b.Property<string>("Description")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(200);

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("DATE");

                    b.Property<string>("SessionId")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(100);

                    b.Property<string>("SubjectId")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(200);

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes");
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("ConsumedTime")
                        .HasColumnType("DATE");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("DATE");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(50000);

                    b.Property<string>("Description")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("DATE");

                    b.Property<string>("SessionId")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(100);

                    b.Property<string>("SubjectId")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(200);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(50);

                    b.HasKey("Key");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.HasIndex("SubjectId", "SessionId", "Type");

                    b.ToTable("PersistedGrants");
                });
#pragma warning restore 612, 618
        }
    }
}
