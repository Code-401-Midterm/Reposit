﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositAPI.Data;

namespace RepositAPI.Migrations
{
    [DbContext(typeof(RepositDbContext))]
    [Migration("20181106000711_fixIssueTry")]
    partial class fixIssueTry
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RepositAPI.Models.Author", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Authors");

                    b.HasData(
                        new { ID = 1, Name = "Jeff" },
                        new { ID = 2, Name = "Kendra" },
                        new { ID = 3, Name = "Richard" },
                        new { ID = 4, Name = "Allisa" },
                        new { ID = 5, Name = "Jeremy" }
                    );
                });

            modelBuilder.Entity("RepositAPI.Models.Snippet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorID");

                    b.Property<string>("CodeBody")
                        .IsRequired();

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("Language");

                    b.Property<string>("Notes");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("AuthorID");

                    b.ToTable("Snippets");

                    b.HasData(
                        new { ID = 1, AuthorID = 1, CodeBody = "Console.WriteLine(\"Hello World!\")", DateCreated = new DateTime(2018, 11, 5, 16, 7, 11, 641, DateTimeKind.Local), Language = 8, Notes = "This is cool.", Title = "Hello World console writeline" },
                        new { ID = 2, AuthorID = 2, CodeBody = "Print(\"Hello World!\")", DateCreated = new DateTime(2018, 11, 5, 16, 7, 11, 643, DateTimeKind.Local), Language = 4, Notes = "This is cooler", Title = "Hello World python" }
                    );
                });

            modelBuilder.Entity("RepositAPI.Models.Snippet", b =>
                {
                    b.HasOne("RepositAPI.Models.Author", "Author")
                        .WithMany("Snippets")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
