﻿// <auto-generated />
using System;
using Metro_Ticketing_System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Metro_Ticketing_System.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240910093406_intial-migration")]
    partial class intialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("Metro_Ticketing_System.Model.Line", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Lines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Line1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Line2"
                        });
                });

            modelBuilder.Entity("Metro_Ticketing_System.Model.Station", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasTransition")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LineId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Postion")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TransionToStationId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("LineId");

                    b.HasIndex("TransionToStationId");

                    b.ToTable("Stations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Helwan",
                            Postion = 1
                        },
                        new
                        {
                            Id = 2,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Ain Helwan",
                            Postion = 2
                        },
                        new
                        {
                            Id = 3,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Helwan University",
                            Postion = 3
                        },
                        new
                        {
                            Id = 4,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Wadi Hof",
                            Postion = 4
                        },
                        new
                        {
                            Id = 5,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Hadayek Helwan",
                            Postion = 5
                        },
                        new
                        {
                            Id = 6,
                            HasTransition = false,
                            LineId = 1,
                            Name = "El Maasara",
                            Postion = 6
                        },
                        new
                        {
                            Id = 7,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Tora El Asmant",
                            Postion = 7
                        },
                        new
                        {
                            Id = 8,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Kozzika",
                            Postion = 8
                        },
                        new
                        {
                            Id = 9,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Tora El Balad",
                            Postion = 9
                        },
                        new
                        {
                            Id = 10,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Sakanat El Maadi",
                            Postion = 10
                        },
                        new
                        {
                            Id = 11,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Maadi",
                            Postion = 11
                        },
                        new
                        {
                            Id = 12,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Hadayek El Maadi",
                            Postion = 12
                        },
                        new
                        {
                            Id = 13,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Dar El Salam",
                            Postion = 13
                        },
                        new
                        {
                            Id = 14,
                            HasTransition = false,
                            LineId = 1,
                            Name = "El Zahraa",
                            Postion = 14
                        },
                        new
                        {
                            Id = 15,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Mar Girgis",
                            Postion = 15
                        },
                        new
                        {
                            Id = 16,
                            HasTransition = false,
                            LineId = 1,
                            Name = "El Malek El Saleh",
                            Postion = 16
                        },
                        new
                        {
                            Id = 17,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Al Sayeda Zeinab",
                            Postion = 17
                        },
                        new
                        {
                            Id = 18,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Saad Zaghloul",
                            Postion = 18
                        },
                        new
                        {
                            Id = 19,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Sadat",
                            Postion = 19
                        },
                        new
                        {
                            Id = 20,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Nasser",
                            Postion = 20
                        },
                        new
                        {
                            Id = 21,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Orabi",
                            Postion = 21
                        },
                        new
                        {
                            Id = 22,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Al Shohadaa",
                            Postion = 22
                        },
                        new
                        {
                            Id = 23,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Ghamra",
                            Postion = 23
                        },
                        new
                        {
                            Id = 24,
                            HasTransition = false,
                            LineId = 1,
                            Name = "El Demerdash",
                            Postion = 24
                        },
                        new
                        {
                            Id = 25,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Manshiet El Sadr",
                            Postion = 25
                        },
                        new
                        {
                            Id = 26,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Kobri El Qobba",
                            Postion = 26
                        },
                        new
                        {
                            Id = 27,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Hammamat El Qobba",
                            Postion = 27
                        },
                        new
                        {
                            Id = 28,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Saray El Qobba",
                            Postion = 28
                        },
                        new
                        {
                            Id = 29,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Hadayeq El Zaitoun",
                            Postion = 29
                        },
                        new
                        {
                            Id = 30,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Helmeyet El Zaitoun",
                            Postion = 30
                        },
                        new
                        {
                            Id = 31,
                            HasTransition = false,
                            LineId = 1,
                            Name = "El Matareyya",
                            Postion = 31
                        },
                        new
                        {
                            Id = 32,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Ain Shams",
                            Postion = 32
                        },
                        new
                        {
                            Id = 33,
                            HasTransition = false,
                            LineId = 1,
                            Name = "Ezbet El Nakhl",
                            Postion = 33
                        },
                        new
                        {
                            Id = 34,
                            HasTransition = false,
                            LineId = 1,
                            Name = "El Marg",
                            Postion = 34
                        },
                        new
                        {
                            Id = 35,
                            HasTransition = false,
                            LineId = 1,
                            Name = "New El Marg",
                            Postion = 35
                        },
                        new
                        {
                            Id = 36,
                            HasTransition = false,
                            LineId = 2,
                            Name = "Shubra Al Khaimah",
                            Postion = 1
                        },
                        new
                        {
                            Id = 37,
                            HasTransition = false,
                            LineId = 2,
                            Name = "Koliet El-Zeraa",
                            Postion = 2
                        },
                        new
                        {
                            Id = 38,
                            HasTransition = false,
                            LineId = 2,
                            Name = "Mezallat",
                            Postion = 3
                        },
                        new
                        {
                            Id = 39,
                            HasTransition = false,
                            LineId = 2,
                            Name = "Khalafawy",
                            Postion = 4
                        },
                        new
                        {
                            Id = 40,
                            HasTransition = false,
                            LineId = 2,
                            Name = "St. Teresa",
                            Postion = 5
                        },
                        new
                        {
                            Id = 41,
                            HasTransition = false,
                            LineId = 2,
                            Name = "Rod El-Farag",
                            Postion = 6
                        },
                        new
                        {
                            Id = 42,
                            HasTransition = false,
                            LineId = 2,
                            Name = "Masarra",
                            Postion = 7
                        },
                        new
                        {
                            Id = 43,
                            HasTransition = false,
                            LineId = 2,
                            Name = "Al Shohadaa",
                            Postion = 8
                        },
                        new
                        {
                            Id = 44,
                            HasTransition = false,
                            LineId = 2,
                            Name = "Attaba",
                            Postion = 9
                        },
                        new
                        {
                            Id = 45,
                            HasTransition = false,
                            LineId = 2,
                            Name = "Mohamed Naguib",
                            Postion = 10
                        },
                        new
                        {
                            Id = 46,
                            HasTransition = false,
                            LineId = 2,
                            Name = "Sadat",
                            Postion = 11
                        },
                        new
                        {
                            Id = 47,
                            HasTransition = false,
                            LineId = 2,
                            Name = "Opera",
                            Postion = 12
                        },
                        new
                        {
                            Id = 48,
                            HasTransition = false,
                            LineId = 2,
                            Name = "Dokki",
                            Postion = 13
                        },
                        new
                        {
                            Id = 49,
                            HasTransition = false,
                            LineId = 2,
                            Name = "El Bohoth",
                            Postion = 14
                        },
                        new
                        {
                            Id = 50,
                            HasTransition = false,
                            LineId = 2,
                            Name = "Cairo University",
                            Postion = 15
                        },
                        new
                        {
                            Id = 51,
                            HasTransition = false,
                            LineId = 2,
                            Name = "Faisal",
                            Postion = 16
                        },
                        new
                        {
                            Id = 52,
                            HasTransition = false,
                            LineId = 2,
                            Name = "Giza",
                            Postion = 17
                        },
                        new
                        {
                            Id = 53,
                            HasTransition = false,
                            LineId = 2,
                            Name = "Omm El-Masryeen",
                            Postion = 18
                        },
                        new
                        {
                            Id = 54,
                            HasTransition = false,
                            LineId = 2,
                            Name = "Sakiat Mekky",
                            Postion = 19
                        },
                        new
                        {
                            Id = 55,
                            HasTransition = false,
                            LineId = 2,
                            Name = "El Monib",
                            Postion = 20
                        });
                });

            modelBuilder.Entity("Metro_Ticketing_System.Model.Station", b =>
                {
                    b.HasOne("Metro_Ticketing_System.Model.Line", "Line")
                        .WithMany("Stations")
                        .HasForeignKey("LineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Metro_Ticketing_System.Model.Station", "TransionToStation")
                        .WithMany()
                        .HasForeignKey("TransionToStationId");

                    b.Navigation("Line");

                    b.Navigation("TransionToStation");
                });

            modelBuilder.Entity("Metro_Ticketing_System.Model.Line", b =>
                {
                    b.Navigation("Stations");
                });
#pragma warning restore 612, 618
        }
    }
}