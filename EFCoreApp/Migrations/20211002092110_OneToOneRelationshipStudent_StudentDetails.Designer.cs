// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreApp.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20211002092110_OneToOneRelationshipStudent_StudentDetails")]
    partial class OneToOneRelationshipStudent_StudentDetails
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Student", b =>
                {
                    b.Property<Guid>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("StudentId");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<bool>("IsRegularStudent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StudentId");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            StudentId = new Guid("a3ce5cb3-708e-46cd-b3c3-d3c481f936ab"),
                            Age = 30,
                            IsRegularStudent = false,
                            Name = "John Doe"
                        },
                        new
                        {
                            StudentId = new Guid("b3d53a12-2cdd-4b11-9f85-15873cb4374f"),
                            Age = 25,
                            IsRegularStudent = false,
                            Name = "Jane Doe"
                        },
                        new
                        {
                            StudentId = new Guid("0982f0e2-2934-4653-acde-b8fddc05aa88"),
                            Age = 28,
                            IsRegularStudent = false,
                            Name = "Mike Miles"
                        },
                        new
                        {
                            StudentId = new Guid("aca7d57b-b6a1-49bf-b1c4-da9164be0b91"),
                            Age = 100,
                            IsRegularStudent = false,
                            Name = "TEST Name"
                        });
                });

            modelBuilder.Entity("Entities.StudentDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("StudentDetailsId");

                    b.Property<string>("AdditionalInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("StudentDetails");
                });

            modelBuilder.Entity("Entities.StudentDetails", b =>
                {
                    b.HasOne("Entities.Student", "Student")
                        .WithOne("StudentDetails")
                        .HasForeignKey("Entities.StudentDetails", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Entities.Student", b =>
                {
                    b.Navigation("StudentDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
