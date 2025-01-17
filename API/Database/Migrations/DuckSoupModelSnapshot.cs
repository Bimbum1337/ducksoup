﻿// <auto-generated />
using System;
using API.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Database.Migrations
{
    [DbContext(typeof(Context.DuckSoup))]
    partial class DuckSoupModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.Database.DuckSoup.Blacklist", b =>
                {
                    b.Property<int>("BlacklistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BlacklistId"));

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MsgId")
                        .HasColumnType("int");

                    b.Property<int>("ServerType")
                        .HasColumnType("int");

                    b.HasKey("BlacklistId")
                        .HasName("PK_dbo.Blacklist");

                    b.ToTable("Blacklist", (string)null);
                });

            modelBuilder.Entity("API.Database.DuckSoup.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"));

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Crontime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eventname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventId")
                        .HasName("PK_dbo.Event");

                    b.ToTable("Event", (string)null);
                });

            modelBuilder.Entity("API.Database.DuckSoup.GlobalSetting", b =>
                {
                    b.Property<int>("SettingsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SettingsId"));

                    b.Property<string>("key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SettingsId")
                        .HasName("PK_dbo.GlobalSetting");

                    b.ToTable("GlobalSetting", (string)null);
                });

            modelBuilder.Entity("API.Database.DuckSoup.Machine", b =>
                {
                    b.Property<int>("MachineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MachineId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Notice")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MachineId")
                        .HasName("PK_dbo.Machine");

                    b.ToTable("Machine", (string)null);
                });

            modelBuilder.Entity("API.Database.DuckSoup.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceId"));

                    b.Property<bool>("AutoStart")
                        .HasColumnType("bit");

                    b.Property<int>("BindPort")
                        .HasColumnType("int");

                    b.Property<int>("ByteLimitation")
                        .HasColumnType("int");

                    b.Property<int>("LocalMachine_MachineId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RemoteMachine_MachineId")
                        .HasColumnType("int");

                    b.Property<int>("RemotePort")
                        .HasColumnType("int");

                    b.Property<int>("ServerType")
                        .HasColumnType("int");

                    b.Property<int?>("SpoofMachine_MachineId")
                        .HasColumnType("int");

                    b.HasKey("ServiceId")
                        .HasName("PK_dbo.Service");

                    b.HasIndex(new[] { "LocalMachine_MachineId" }, "IX_LocalMachine_MachineId");

                    b.HasIndex(new[] { "RemoteMachine_MachineId" }, "IX_RemoteMachine_MachineId");

                    b.HasIndex(new[] { "SpoofMachine_MachineId" }, "IX_SpoofMachine_MachineId");

                    b.ToTable("Service", (string)null);
                });

            modelBuilder.Entity("API.Database.DuckSoup.User", b =>
                {
                    b.Property<Guid>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("passwordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("passwordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("tokenVersion")
                        .HasColumnType("int");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userId")
                        .HasName("PK_dbo.User");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("API.Database.DuckSoup.Whitelist", b =>
                {
                    b.Property<int>("WhitelistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WhitelistId"));

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MsgId")
                        .HasColumnType("int");

                    b.Property<int>("ServerType")
                        .HasColumnType("int");

                    b.HasKey("WhitelistId")
                        .HasName("PK_dbo.Whitelist");

                    b.ToTable("Whitelist", (string)null);
                });

            modelBuilder.Entity("API.Database.DuckSoup.Service", b =>
                {
                    b.HasOne("API.Database.DuckSoup.Machine", "LocalMachine_Machine")
                        .WithMany("ServiceLocalMachine_Machines")
                        .HasForeignKey("LocalMachine_MachineId")
                        .IsRequired()
                        .HasConstraintName("FK_dbo.Service_dbo.Machine_LocalMachine_MachineId");

                    b.HasOne("API.Database.DuckSoup.Machine", "RemoteMachine_Machine")
                        .WithMany("ServiceRemoteMachine_Machines")
                        .HasForeignKey("RemoteMachine_MachineId")
                        .IsRequired()
                        .HasConstraintName("FK_dbo.Service_dbo.Machine_RemoteMachine_MachineId");

                    b.HasOne("API.Database.DuckSoup.Machine", "SpoofMachine_Machine")
                        .WithMany("ServiceSpoofMachine_Machines")
                        .HasForeignKey("SpoofMachine_MachineId")
                        .HasConstraintName("FK_dbo.Service_dbo.Machine_SpoofMachine_MachineId");

                    b.Navigation("LocalMachine_Machine");

                    b.Navigation("RemoteMachine_Machine");

                    b.Navigation("SpoofMachine_Machine");
                });

            modelBuilder.Entity("API.Database.DuckSoup.Machine", b =>
                {
                    b.Navigation("ServiceLocalMachine_Machines");

                    b.Navigation("ServiceRemoteMachine_Machines");

                    b.Navigation("ServiceSpoofMachine_Machines");
                });
#pragma warning restore 612, 618
        }
    }
}
