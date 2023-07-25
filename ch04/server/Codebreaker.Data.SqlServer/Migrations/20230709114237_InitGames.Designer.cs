﻿// <auto-generated />
using System;
using Codebreaker.Data.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Codebreaker.Data.SqlServer.Migrations
{
    [DbContext(typeof(GamesSqlServerContext))]
    [Migration("20230709114237_InitGames")]
    partial class InitGames
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("codebreaker")
                .HasAnnotation("ProductVersion", "8.0.0-preview.5.23280.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Codebreaker.GameAPIs.Models.Game", b =>
                {
                    b.Property<Guid>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Codes")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<TimeSpan?>("Duration")
                        .HasColumnType("time");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FieldValues")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Fields");

                    b.Property<string>("GameType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("IsVictory")
                        .HasColumnType("bit");

                    b.Property<int>("LastMoveNumber")
                        .HasColumnType("int");

                    b.Property<int>("MaxMoves")
                        .HasColumnType("int");

                    b.Property<int>("NumberCodes")
                        .HasColumnType("int");

                    b.Property<string>("PlayerName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("GameId");

                    b.ToTable("Games", "codebreaker");
                });

            modelBuilder.Entity("Codebreaker.GameAPIs.Models.Move", b =>
                {
                    b.Property<Guid>("MoveId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GuessPegs")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("KeyPegs")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("MoveNumber")
                        .HasColumnType("int");

                    b.HasKey("MoveId");

                    b.HasIndex("GameId");

                    b.ToTable("Moves", "codebreaker");
                });

            modelBuilder.Entity("Codebreaker.GameAPIs.Models.Move", b =>
                {
                    b.HasOne("Codebreaker.GameAPIs.Models.Game", null)
                        .WithMany("Moves")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Codebreaker.GameAPIs.Models.Game", b =>
                {
                    b.Navigation("Moves");
                });
#pragma warning restore 612, 618
        }
    }
}
