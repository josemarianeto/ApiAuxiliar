﻿// <auto-generated />
using ApiAuxiliar.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiAuxiliar.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ApiAuxiliar.Models.Assunto", b =>
                {
                    b.Property<int>("AssuntoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AssuntoId"));

                    b.Property<int>("ClienteID")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AssuntoId");

                    b.HasIndex("ClienteID");

                    b.ToTable("Assuntos");
                });

            modelBuilder.Entity("ApiAuxiliar.Models.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("conector")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("database")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ip")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("porta")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ApiAuxiliar.Models.Assunto", b =>
                {
                    b.HasOne("ApiAuxiliar.Models.Cliente", null)
                        .WithMany("Assuntos")
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiAuxiliar.Models.Cliente", b =>
                {
                    b.Navigation("Assuntos");
                });
#pragma warning restore 612, 618
        }
    }
}
