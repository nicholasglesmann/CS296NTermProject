﻿// <auto-generated />
using System;
using CS295NTermProject.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CS295NTermProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191203192530_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CS295NTermProject.Models.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentText");

                    b.Property<int?>("MusicTrackID");

                    b.HasKey("CommentID");

                    b.HasIndex("MusicTrackID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("CS295NTermProject.Models.GenreTag", b =>
                {
                    b.Property<int>("GenreTagID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tag");

                    b.HasKey("GenreTagID");

                    b.ToTable("GenreTags");
                });

            modelBuilder.Entity("CS295NTermProject.Models.InstrumentTag", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MusicTrackID");

                    b.Property<string>("Tag");

                    b.HasKey("ID");

                    b.HasIndex("MusicTrackID");

                    b.ToTable("InstrumentTags");
                });

            modelBuilder.Entity("CS295NTermProject.Models.Message", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("MessageBody");

                    b.Property<string>("MessageTitle");

                    b.Property<string>("Name");

                    b.HasKey("MessageID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("CS295NTermProject.Models.MoodTag", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MusicTrackID");

                    b.Property<string>("Tag");

                    b.HasKey("ID");

                    b.HasIndex("MusicTrackID");

                    b.ToTable("MoodTags");
                });

            modelBuilder.Entity("CS295NTermProject.Models.MusicTrack", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName");

                    b.Property<int?>("GenreTagID");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("GenreTagID");

                    b.ToTable("MusicTracks");
                });

            modelBuilder.Entity("CS295NTermProject.Models.MusicTrackInstrumentTag", b =>
                {
                    b.Property<int>("MusicTrackID");

                    b.Property<int>("InstrumentTagID");

                    b.HasKey("MusicTrackID", "InstrumentTagID");

                    b.HasAlternateKey("InstrumentTagID", "MusicTrackID");

                    b.ToTable("MusicTrackInstrumentTag");
                });

            modelBuilder.Entity("CS295NTermProject.Models.MusicTrackMoodTag", b =>
                {
                    b.Property<int>("MusicTrackID");

                    b.Property<int>("MoodTagID");

                    b.HasKey("MusicTrackID", "MoodTagID");

                    b.HasAlternateKey("MoodTagID", "MusicTrackID");

                    b.ToTable("MusicTrackMoodTags");
                });

            modelBuilder.Entity("CS295NTermProject.Models.MusicTrackOtherTag", b =>
                {
                    b.Property<int>("MusicTrackID");

                    b.Property<int>("OtherTagID");

                    b.HasKey("MusicTrackID", "OtherTagID");

                    b.HasIndex("OtherTagID");

                    b.ToTable("MusicTrackOtherTag");
                });

            modelBuilder.Entity("CS295NTermProject.Models.OtherTag", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MusicTrackID");

                    b.Property<string>("Tag");

                    b.HasKey("ID");

                    b.HasIndex("MusicTrackID");

                    b.ToTable("OtherTags");
                });

            modelBuilder.Entity("CS295NTermProject.Models.Rating", b =>
                {
                    b.Property<int>("RatingID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MusicTrackID");

                    b.Property<int>("RatingValue");

                    b.HasKey("RatingID");

                    b.HasIndex("MusicTrackID");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("CS295NTermProject.Models.Comment", b =>
                {
                    b.HasOne("CS295NTermProject.Models.MusicTrack")
                        .WithMany("Comments")
                        .HasForeignKey("MusicTrackID");
                });

            modelBuilder.Entity("CS295NTermProject.Models.InstrumentTag", b =>
                {
                    b.HasOne("CS295NTermProject.Models.MusicTrack")
                        .WithMany("Instruments")
                        .HasForeignKey("MusicTrackID");
                });

            modelBuilder.Entity("CS295NTermProject.Models.MoodTag", b =>
                {
                    b.HasOne("CS295NTermProject.Models.MusicTrack")
                        .WithMany("Moods")
                        .HasForeignKey("MusicTrackID");
                });

            modelBuilder.Entity("CS295NTermProject.Models.MusicTrack", b =>
                {
                    b.HasOne("CS295NTermProject.Models.GenreTag", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreTagID");
                });

            modelBuilder.Entity("CS295NTermProject.Models.MusicTrackInstrumentTag", b =>
                {
                    b.HasOne("CS295NTermProject.Models.InstrumentTag", "InstrumentTag")
                        .WithMany("MusicTrackInstrumentTags")
                        .HasForeignKey("InstrumentTagID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CS295NTermProject.Models.MusicTrack", "MusicTrack")
                        .WithMany("MusicTrackInstrumentTags")
                        .HasForeignKey("MusicTrackID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CS295NTermProject.Models.MusicTrackMoodTag", b =>
                {
                    b.HasOne("CS295NTermProject.Models.MoodTag", "MoodTag")
                        .WithMany("MusicTrackMoodTags")
                        .HasForeignKey("MoodTagID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CS295NTermProject.Models.MusicTrack", "MusicTrack")
                        .WithMany("MusicTrackMoodTags")
                        .HasForeignKey("MusicTrackID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CS295NTermProject.Models.MusicTrackOtherTag", b =>
                {
                    b.HasOne("CS295NTermProject.Models.MusicTrack", "MusicTrack")
                        .WithMany("MusicTrackOtherTags")
                        .HasForeignKey("MusicTrackID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CS295NTermProject.Models.OtherTag", "OtherTag")
                        .WithMany("MusicTrackOtherTags")
                        .HasForeignKey("OtherTagID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CS295NTermProject.Models.OtherTag", b =>
                {
                    b.HasOne("CS295NTermProject.Models.MusicTrack")
                        .WithMany("Tags")
                        .HasForeignKey("MusicTrackID");
                });

            modelBuilder.Entity("CS295NTermProject.Models.Rating", b =>
                {
                    b.HasOne("CS295NTermProject.Models.MusicTrack")
                        .WithMany("Ratings")
                        .HasForeignKey("MusicTrackID");
                });
#pragma warning restore 612, 618
        }
    }
}
