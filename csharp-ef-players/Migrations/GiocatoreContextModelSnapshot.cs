﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using csharp_ef_players;

#nullable disable

namespace csharp_ef_players.Migrations
{
    [DbContext(typeof(GiocatoreContext))]
    partial class GiocatoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("csharp_ef_players.Giocatore", b =>
                {
                    b.Property<int>("GiocatoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GiocatoreId"));

                    b.Property<string>("Cognome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PartiteGiocate")
                        .HasColumnType("int");

                    b.Property<int>("PartiteVinte")
                        .HasColumnType("int");

                    b.Property<double>("Punteggio")
                        .HasColumnType("float");

                    b.HasKey("GiocatoreId");

                    b.ToTable("Giocatore");
                });
#pragma warning restore 612, 618
        }
    }
}
