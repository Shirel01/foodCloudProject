﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using foodCloudProject.Data;

#nullable disable

namespace foodCloudProject.Migrations
{
    [DbContext(typeof(foodCloudProjectContext))]
    partial class foodCloudProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("foodCloudProject.Models.Ingredients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int");

                    b.Property<string>("UnitOfMeasurements")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("foodCloudProject.Models.Instructions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int");

                    b.Property<string>("Step")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("Instructions");
                });

            modelBuilder.Entity("foodCloudProject.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recipe");
                });

            modelBuilder.Entity("foodCloudProject.Models.RTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("RTag");
                });

            modelBuilder.Entity("foodCloudProject.Models.Ingredients", b =>
                {
                    b.HasOne("foodCloudProject.Models.Recipe", null)
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeId");
                });

            modelBuilder.Entity("foodCloudProject.Models.Instructions", b =>
                {
                    b.HasOne("foodCloudProject.Models.Recipe", null)
                        .WithMany("Instructions")
                        .HasForeignKey("RecipeId");
                });

            modelBuilder.Entity("foodCloudProject.Models.RTag", b =>
                {
                    b.HasOne("foodCloudProject.Models.Recipe", null)
                        .WithMany("RTags")
                        .HasForeignKey("RecipeId");
                });

            modelBuilder.Entity("foodCloudProject.Models.Recipe", b =>
                {
                    b.Navigation("Ingredients");

                    b.Navigation("Instructions");

                    b.Navigation("RTags");
                });
#pragma warning restore 612, 618
        }
    }
}