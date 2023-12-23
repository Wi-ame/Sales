﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using vente_en_ligne.Data;

#nullable disable

namespace venteenligne.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231223005208_lkwa3")]
    partial class lkwa3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("vente_en_ligne.Models.Admin", b =>
                {
                    b.Property<string>("CIN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CIN");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("vente_en_ligne.Models.Categories", b =>
                {
                    b.Property<int>("CategorieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategorieID"));

                    b.Property<string>("CategorieName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategorieID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("vente_en_ligne.Models.Panier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IDPro")
                        .HasColumnType("int");

                    b.Property<int>("IDU")
                        .HasColumnType("int");

                    b.Property<int>("Quantité")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Paniers");
                });

            modelBuilder.Entity("vente_en_ligne.Models.Produit", b =>
                {
                    b.Property<int>("IdPr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPr"));

                    b.Property<DateTime>("DateDepot")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IDC")
                        .HasColumnType("int");

                    b.Property<string>("IDP")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte[]>("ImageData")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("prix")
                        .HasColumnType("float");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.HasKey("IdPr");

                    b.HasIndex("IDC");

                    b.HasIndex("IDP");

                    b.ToTable("Produits");
                });

            modelBuilder.Entity("vente_en_ligne.Models.Proprietaire", b =>
                {
                    b.Property<string>("INterID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AdresseEntreprise")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomEntreprise")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Tele")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("INterID");

                    b.ToTable("Proprietaires");
                });

            modelBuilder.Entity("vente_en_ligne.Models.Utilisateur", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Utilisateurs");
                });

            modelBuilder.Entity("vente_en_ligne.Models.Produit", b =>
                {
                    b.HasOne("vente_en_ligne.Models.Categories", "Categories")
                        .WithMany()
                        .HasForeignKey("IDC");

                    b.HasOne("vente_en_ligne.Models.Proprietaire", "proprietaires")
                        .WithMany()
                        .HasForeignKey("IDP");

                    b.Navigation("Categories");

                    b.Navigation("proprietaires");
                });
#pragma warning restore 612, 618
        }
    }
}
