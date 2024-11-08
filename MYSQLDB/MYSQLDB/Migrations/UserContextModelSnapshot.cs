﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MYSQLDB.Migrations
{
    // This class represents a snapshot of the UserContext model.
    // It is used by Entity Framework to compare the current state of the model with the database schema during migrations.
    [DbContext(typeof(UserContext))]
    partial class UserContextModelSnapshot : ModelSnapshot
    {
        // This method is used to build the model during the migration process.
        // It defines how each entity in the model is mapped to the database schema.
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            // Adds annotations to the model, specifying the version of Entity Framework Core and the max identifier length.
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);
            // MySQL specific extension method to configure auto-increment columns in the database.
            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);
            // Configures the "UserModel" entity in the model.
            modelBuilder.Entity("MYSQLDB.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
