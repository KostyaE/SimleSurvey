﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SimleSurvey.Data;
using System;

namespace SimleSurvey.Migrations
{
    [DbContext(typeof(AppDBContent))]
    partial class AppDBContentModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SimleSurvey.Data.Models.Question", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Surveyid");

                    b.Property<string>("answer");

                    b.Property<string>("question");

                    b.HasKey("id");

                    b.HasIndex("Surveyid");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("SimleSurvey.Data.Models.Survey", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Userid");

                    b.Property<bool>("active");

                    b.Property<string>("description");

                    b.Property<string>("nameSurvey");

                    b.HasKey("id");

                    b.HasIndex("Userid");

                    b.ToTable("Survey");
                });

            modelBuilder.Entity("SimleSurvey.Data.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("firstname");

                    b.Property<string>("lastname");

                    b.HasKey("id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("SimleSurvey.Data.Models.Question", b =>
                {
                    b.HasOne("SimleSurvey.Data.Models.Survey")
                        .WithMany("allQuestions")
                        .HasForeignKey("Surveyid");
                });

            modelBuilder.Entity("SimleSurvey.Data.Models.Survey", b =>
                {
                    b.HasOne("SimleSurvey.Data.Models.User")
                        .WithMany("allsurvey")
                        .HasForeignKey("Userid");
                });
#pragma warning restore 612, 618
        }
    }
}
