﻿// <auto-generated />

using LBPUnion.ProjectLighthouse;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectLighthouse;

namespace ProjectLighthouse.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20211019203627_LastMatches")]
    partial class LastMatches
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("ProjectLighthouse.Types.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .HasColumnType("longtext");

                    b.Property<int>("PosterUserId")
                        .HasColumnType("int");

                    b.Property<int>("TargetUserId")
                        .HasColumnType("int");

                    b.Property<int>("ThumbsDown")
                        .HasColumnType("int");

                    b.Property<int>("ThumbsUp")
                        .HasColumnType("int");

                    b.Property<long>("Timestamp")
                        .HasColumnType("bigint");

                    b.HasKey("CommentId");

                    b.HasIndex("PosterUserId");

                    b.HasIndex("TargetUserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ProjectLighthouse.Types.HeartedLevel", b =>
                {
                    b.Property<int>("HeartedLevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("SlotId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("HeartedLevelId");

                    b.HasIndex("SlotId");

                    b.HasIndex("UserId");

                    b.ToTable("HeartedLevels");
                });

            modelBuilder.Entity("ProjectLighthouse.Types.LastMatch", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("Timestamp")
                        .HasColumnType("bigint");

                    b.HasKey("UserId");

                    b.ToTable("LastMatches");
                });

            modelBuilder.Entity("ProjectLighthouse.Types.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("X")
                        .HasColumnType("int");

                    b.Property<int>("Y")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("ProjectLighthouse.Types.QueuedLevel", b =>
                {
                    b.Property<int>("QueuedLevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("SlotId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("QueuedLevelId");

                    b.HasIndex("SlotId");

                    b.HasIndex("UserId");

                    b.ToTable("QueuedLevels");
                });

            modelBuilder.Entity("ProjectLighthouse.Types.Slot", b =>
                {
                    b.Property<int>("SlotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AuthorLabels")
                        .HasColumnType("longtext");

                    b.Property<string>("BackgroundHash")
                        .HasColumnType("longtext");

                    b.Property<int>("CreatorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("IconHash")
                        .HasColumnType("longtext");

                    b.Property<bool>("InitiallyLocked")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lbp1Only")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("MaximumPlayers")
                        .HasColumnType("int");

                    b.Property<int>("MinimumPlayers")
                        .HasColumnType("int");

                    b.Property<bool>("MoveRequired")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Resource")
                        .HasColumnType("longtext");

                    b.Property<string>("RootLevel")
                        .HasColumnType("longtext");

                    b.Property<int>("Shareable")
                        .HasColumnType("int");

                    b.Property<bool>("SubLevel")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("SlotId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("LocationId");

                    b.ToTable("Slots");
                });

            modelBuilder.Entity("ProjectLighthouse.Types.Token", b =>
                {
                    b.Property<int>("TokenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserToken")
                        .HasColumnType("longtext");

                    b.HasKey("TokenId");

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("ProjectLighthouse.Types.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Biography")
                        .HasColumnType("longtext");

                    b.Property<string>("BooHash")
                        .HasColumnType("longtext");

                    b.Property<int>("CommentCount")
                        .HasColumnType("int");

                    b.Property<bool>("CommentsEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("FavouriteSlotCount")
                        .HasColumnType("int");

                    b.Property<int>("FavouriteUserCount")
                        .HasColumnType("int");

                    b.Property<int>("Game")
                        .HasColumnType("int");

                    b.Property<int>("HeartCount")
                        .HasColumnType("int");

                    b.Property<string>("IconHash")
                        .HasColumnType("longtext");

                    b.Property<int>("Lists")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("LolCatFtwCount")
                        .HasColumnType("int");

                    b.Property<int>("PhotosByMeCount")
                        .HasColumnType("int");

                    b.Property<int>("PhotosWithMeCount")
                        .HasColumnType("int");

                    b.Property<string>("Pins")
                        .HasColumnType("longtext");

                    b.Property<string>("PlanetHash")
                        .HasColumnType("longtext");

                    b.Property<int>("ReviewCount")
                        .HasColumnType("int");

                    b.Property<int>("StaffChallengeBronzeCount")
                        .HasColumnType("int");

                    b.Property<int>("StaffChallengeGoldCount")
                        .HasColumnType("int");

                    b.Property<int>("StaffChallengeSilverCount")
                        .HasColumnType("int");

                    b.Property<int>("UsedSlots")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.Property<string>("YayHash")
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.HasIndex("LocationId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ProjectLighthouse.Types.Comment", b =>
                {
                    b.HasOne("ProjectLighthouse.Types.User", "Poster")
                        .WithMany()
                        .HasForeignKey("PosterUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectLighthouse.Types.User", "Target")
                        .WithMany()
                        .HasForeignKey("TargetUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Poster");

                    b.Navigation("Target");
                });

            modelBuilder.Entity("ProjectLighthouse.Types.HeartedLevel", b =>
                {
                    b.HasOne("ProjectLighthouse.Types.Slot", "Slot")
                        .WithMany()
                        .HasForeignKey("SlotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectLighthouse.Types.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Slot");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectLighthouse.Types.QueuedLevel", b =>
                {
                    b.HasOne("ProjectLighthouse.Types.Slot", "Slot")
                        .WithMany()
                        .HasForeignKey("SlotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectLighthouse.Types.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Slot");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectLighthouse.Types.Slot", b =>
                {
                    b.HasOne("ProjectLighthouse.Types.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectLighthouse.Types.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("ProjectLighthouse.Types.User", b =>
                {
                    b.HasOne("ProjectLighthouse.Types.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });
#pragma warning restore 612, 618
        }
    }
}
