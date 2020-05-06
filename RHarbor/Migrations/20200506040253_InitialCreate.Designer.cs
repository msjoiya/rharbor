﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kenzauros.RHarbor.Models;

namespace kenzauros.RHarbor.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200506040253_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("kenzauros.RHarbor.Models.RDPConnectionInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Admin")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DesktopHeight")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DesktopWidth")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("FullScreen")
                        .HasColumnType("INTEGER");

                    b.Property<string>("GroupName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Host")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<int>("Port")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("RequiredConnectionId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SavePassword")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SaveUsername")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Settings")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("ShowInJumpList")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RequiredConnectionId");

                    b.ToTable("rdp_connection_infos");
                });

            modelBuilder.Entity("kenzauros.RHarbor.Models.SSHConnectionInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ExpectedFingerPrint")
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Host")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("KeepAliveEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KeepAliveInterval")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<int>("Port")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PortForwardings")
                        .HasColumnType("TEXT");

                    b.Property<string>("PrivateKeyFilePath")
                        .HasColumnType("TEXT");

                    b.Property<long?>("RequiredConnectionId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SavePassword")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SaveUsername")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("ShowInJumpList")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RequiredConnectionId");

                    b.ToTable("ssh_connection_infos");
                });

            modelBuilder.Entity("kenzauros.RHarbor.Models.RDPConnectionInfo", b =>
                {
                    b.HasOne("kenzauros.RHarbor.Models.SSHConnectionInfo", "RequiredConnection")
                        .WithMany()
                        .HasForeignKey("RequiredConnectionId");
                });

            modelBuilder.Entity("kenzauros.RHarbor.Models.SSHConnectionInfo", b =>
                {
                    b.HasOne("kenzauros.RHarbor.Models.SSHConnectionInfo", "RequiredConnection")
                        .WithMany()
                        .HasForeignKey("RequiredConnectionId");
                });
#pragma warning restore 612, 618
        }
    }
}
