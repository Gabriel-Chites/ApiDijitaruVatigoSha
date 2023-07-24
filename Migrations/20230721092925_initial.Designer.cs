﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TreinandoCodinDojo.Data;

#nullable disable

namespace TreinandoCodinDojo.Migrations
{
    [DbContext(typeof(CodinContext))]
    [Migration("20230721092925_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CollaboratorProject", b =>
                {
                    b.Property<int>("CollaboratorsId")
                        .HasColumnType("int");

                    b.Property<int>("Projectsid")
                        .HasColumnType("int");

                    b.HasKey("CollaboratorsId", "Projectsid");

                    b.HasIndex("Projectsid");

                    b.ToTable("CollaboratorProject");
                });

            modelBuilder.Entity("TreinandoCodinDojo.Models.Collaborator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Modality")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Collaborators");
                });

            modelBuilder.Entity("TreinandoCodinDojo.Models.Project", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Budget")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("CollaboratorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ProjectType")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("CollaboratorProject", b =>
                {
                    b.HasOne("TreinandoCodinDojo.Models.Collaborator", null)
                        .WithMany()
                        .HasForeignKey("CollaboratorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TreinandoCodinDojo.Models.Project", null)
                        .WithMany()
                        .HasForeignKey("Projectsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}