﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SiparisTakipSistemiCore.Models.Entities;

namespace SiparisTakipSistemiCore.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220318132304_mig2")]
    partial class mig2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SiparisTakipSistemiCore.Models.Entities.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AdminAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminParola")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("SiparisTakipSistemiCore.Models.Entities.Musteri", b =>
                {
                    b.Property<int>("MusteriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("MusteriAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MusteriEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MusteriParola")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MusteriTelefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MusteriID");

                    b.ToTable("Musteris");
                });

            modelBuilder.Entity("SiparisTakipSistemiCore.Models.Entities.Siparis", b =>
                {
                    b.Property<int>("SiparisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Durum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EPosta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MusteriID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Urun")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SiparisID");

                    b.HasIndex("MusteriID");

                    b.ToTable("Sipariss");
                });

            modelBuilder.Entity("SiparisTakipSistemiCore.Models.Entities.Siparis", b =>
                {
                    b.HasOne("SiparisTakipSistemiCore.Models.Entities.Musteri", "Musteri")
                        .WithMany("Siparis")
                        .HasForeignKey("MusteriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musteri");
                });

            modelBuilder.Entity("SiparisTakipSistemiCore.Models.Entities.Musteri", b =>
                {
                    b.Navigation("Siparis");
                });
#pragma warning restore 612, 618
        }
    }
}
