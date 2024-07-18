﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using YahtBoss.DataAccess.EFData;

#nullable disable

namespace YahtBoss.DataAccess.Migrations
{
    [DbContext(typeof(VoyageDataContext))]
    [Migration("20240718203818_init1")]
    partial class init1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("YahtBoss.DataAccess.Voyage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("VoyageEventId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Voyages");
                });

            modelBuilder.Entity("YahtBoss.DataAccess.VoyageEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateAndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("VoyageId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("VoyageId");

                    b.ToTable("VoyageEvents");
                });

            modelBuilder.Entity("YahtBoss.DataAccess.VoyageEvent", b =>
                {
                    b.HasOne("YahtBoss.DataAccess.Voyage", null)
                        .WithMany("VoyageEvents")
                        .HasForeignKey("VoyageId");
                });

            modelBuilder.Entity("YahtBoss.DataAccess.Voyage", b =>
                {
                    b.Navigation("VoyageEvents");
                });
#pragma warning restore 612, 618
        }
    }
}
