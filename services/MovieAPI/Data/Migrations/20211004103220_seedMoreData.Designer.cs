﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using movieAPI.Data;

namespace MovieAPI.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211004103220_seedMoreData")]
    partial class seedMoreData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("movieAPI.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Clint Eastwood"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Samuel L. Jackson"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Brad Pitt"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Leonardo Di Caprio"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Sandra Bullock"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Robert De Niro"
                        });
                });

            modelBuilder.Entity("movieAPI.Models.ActorMovie", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("integer");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("ActorsMovies");

                    b.HasData(
                        new
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 2,
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 2
                        },
                        new
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 3
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new
                        {
                            ActorId = 4,
                            MovieId = 4
                        },
                        new
                        {
                            ActorId = 5,
                            MovieId = 5
                        },
                        new
                        {
                            ActorId = 6,
                            MovieId = 5
                        },
                        new
                        {
                            ActorId = 6,
                            MovieId = 6
                        },
                        new
                        {
                            ActorId = 1,
                            MovieId = 6
                        },
                        new
                        {
                            ActorId = 2,
                            MovieId = 7
                        },
                        new
                        {
                            ActorId = 6,
                            MovieId = 7
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 8
                        },
                        new
                        {
                            ActorId = 4,
                            MovieId = 8
                        },
                        new
                        {
                            ActorId = 1,
                            MovieId = 9
                        },
                        new
                        {
                            ActorId = 5,
                            MovieId = 9
                        },
                        new
                        {
                            ActorId = 4,
                            MovieId = 10
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 10
                        },
                        new
                        {
                            ActorId = 5,
                            MovieId = 11
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 11
                        },
                        new
                        {
                            ActorId = 4,
                            MovieId = 12
                        },
                        new
                        {
                            ActorId = 6,
                            MovieId = 12
                        });
                });

            modelBuilder.Entity("movieAPI.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "An action movie",
                            Image = "image.jpg",
                            ReleaseDate = new DateTime(2000, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Film 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "An action movie",
                            Image = "image.jpg",
                            ReleaseDate = new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Film 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "An action movie",
                            Image = "image.jpg",
                            ReleaseDate = new DateTime(2010, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Film 3"
                        },
                        new
                        {
                            Id = 4,
                            Description = "An action movie",
                            Image = "image.jpg",
                            ReleaseDate = new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Film 4"
                        },
                        new
                        {
                            Id = 5,
                            Description = "An action movie",
                            Image = "image.jpg",
                            ReleaseDate = new DateTime(2008, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Film 5"
                        },
                        new
                        {
                            Id = 6,
                            Description = "An action movie",
                            Image = "image.jpg",
                            ReleaseDate = new DateTime(2001, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Film 6"
                        },
                        new
                        {
                            Id = 7,
                            Description = "An action movie",
                            Image = "image.jpg",
                            ReleaseDate = new DateTime(1994, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Film 7"
                        },
                        new
                        {
                            Id = 8,
                            Description = "An action movie",
                            Image = "image.jpg",
                            ReleaseDate = new DateTime(1990, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Film 8"
                        },
                        new
                        {
                            Id = 9,
                            Description = "An action movie",
                            Image = "image.jpg",
                            ReleaseDate = new DateTime(1978, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Film 9"
                        },
                        new
                        {
                            Id = 10,
                            Description = "An action movie",
                            Image = "image.jpg",
                            ReleaseDate = new DateTime(2010, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Film 10"
                        },
                        new
                        {
                            Id = 11,
                            Description = "An action movie",
                            Image = "image.jpg",
                            ReleaseDate = new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Film 11"
                        },
                        new
                        {
                            Id = 12,
                            Description = "An action movie",
                            Image = "image.jpg",
                            ReleaseDate = new DateTime(2020, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Film 12"
                        });
                });

            modelBuilder.Entity("movieAPI.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.Property<int>("Score")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MovieId = 1,
                            Score = 3
                        },
                        new
                        {
                            Id = 2,
                            MovieId = 1,
                            Score = 1
                        },
                        new
                        {
                            Id = 3,
                            MovieId = 2,
                            Score = 4
                        },
                        new
                        {
                            Id = 4,
                            MovieId = 2,
                            Score = 5
                        },
                        new
                        {
                            Id = 5,
                            MovieId = 3,
                            Score = 5
                        },
                        new
                        {
                            Id = 6,
                            MovieId = 3,
                            Score = 2
                        },
                        new
                        {
                            Id = 7,
                            MovieId = 4,
                            Score = 3
                        },
                        new
                        {
                            Id = 8,
                            MovieId = 4,
                            Score = 4
                        },
                        new
                        {
                            Id = 9,
                            MovieId = 5,
                            Score = 4
                        },
                        new
                        {
                            Id = 10,
                            MovieId = 5,
                            Score = 5
                        },
                        new
                        {
                            Id = 11,
                            MovieId = 6,
                            Score = 1
                        },
                        new
                        {
                            Id = 12,
                            MovieId = 6,
                            Score = 2
                        },
                        new
                        {
                            Id = 13,
                            MovieId = 7,
                            Score = 3
                        },
                        new
                        {
                            Id = 14,
                            MovieId = 7,
                            Score = 1
                        },
                        new
                        {
                            Id = 15,
                            MovieId = 8,
                            Score = 4
                        },
                        new
                        {
                            Id = 16,
                            MovieId = 8,
                            Score = 5
                        },
                        new
                        {
                            Id = 17,
                            MovieId = 9,
                            Score = 3
                        },
                        new
                        {
                            Id = 18,
                            MovieId = 9,
                            Score = 2
                        },
                        new
                        {
                            Id = 19,
                            MovieId = 10,
                            Score = 5
                        },
                        new
                        {
                            Id = 20,
                            MovieId = 10,
                            Score = 4
                        },
                        new
                        {
                            Id = 21,
                            MovieId = 11,
                            Score = 4
                        },
                        new
                        {
                            Id = 22,
                            MovieId = 11,
                            Score = 5
                        },
                        new
                        {
                            Id = 23,
                            MovieId = 12,
                            Score = 5
                        },
                        new
                        {
                            Id = 24,
                            MovieId = 12,
                            Score = 1
                        });
                });

            modelBuilder.Entity("movieAPI.Models.ActorMovie", b =>
                {
                    b.HasOne("movieAPI.Models.Actor", "Actor")
                        .WithMany("ActorMovie")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("movieAPI.Models.Movie", "Movie")
                        .WithMany("ActorMovie")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("movieAPI.Models.Rating", b =>
                {
                    b.HasOne("movieAPI.Models.Movie", "Movie")
                        .WithMany("Ratings")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("movieAPI.Models.Actor", b =>
                {
                    b.Navigation("ActorMovie");
                });

            modelBuilder.Entity("movieAPI.Models.Movie", b =>
                {
                    b.Navigation("ActorMovie");

                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}
