﻿// <auto-generated />
using System;
using Cachr.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cachr.Core.Migrations
{
    [DbContext(typeof(ObjectStorageContext))]
    partial class ObjectStorageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("Cachr.Core.Data.StoredObject", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("TEXT");

                    b.Property<long>("Created")
                        .HasColumnType("INTEGER");

                    b.Property<long>("LastUpdate")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Modified");

                    b.Property<Guid>("MetadataId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("StoredObjectMetadataId")
                        .HasColumnType("TEXT");

                    b.HasKey("Key");

                    b.HasIndex("MetadataId")
                        .IsUnique();

                    b.HasIndex("StoredObjectMetadataId");

                    b.ToTable("StoredObjects");
                });

            modelBuilder.Entity("Cachr.Core.Data.StoredObjectMetadata", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<long?>("AbsoluteExpiration")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("TEXT");

                    b.Property<long?>("CurrentExpiration")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<long?>("SlidingExpiration")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("ObjectMetadata");
                });

            modelBuilder.Entity("Cachr.Core.Data.StoredObject", b =>
                {
                    b.HasOne("Cachr.Core.Data.StoredObjectMetadata", null)
                        .WithMany()
                        .HasForeignKey("StoredObjectMetadataId");
                });
#pragma warning restore 612, 618
        }
    }
}
