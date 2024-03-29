﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TypesOfLoadingEFCore.Web.Data;

#nullable disable

namespace TypesOfLoadingEFCore.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TypesOfLoadingEFCore.Web.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("DepartmentDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            DepartmentDescription = "Responsible for the over all IT running in the company.",
                            DepartmentName = "Information Technology"
                        },
                        new
                        {
                            DepartmentId = 2,
                            DepartmentDescription = "Responsible for the over all Finance in the department.",
                            DepartmentName = "Finance"
                        },
                        new
                        {
                            DepartmentId = 3,
                            DepartmentDescription = "Responsible for the sales in the department.",
                            DepartmentName = "Sales"
                        },
                        new
                        {
                            DepartmentId = 4,
                            DepartmentDescription = "Responsible for managing the company goals and agenda.",
                            DepartmentName = "Managers"
                        });
                });

            modelBuilder.Entity("TypesOfLoadingEFCore.Web.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 1,
                            Email = "mike@gmail.com",
                            FirstName = "Mike",
                            Gender = 1,
                            LastName = "Simson",
                            Phone = "+231778123123",
                            Salary = 10000m
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 1,
                            Email = "alexa@gmail.com",
                            FirstName = "Alexa",
                            Gender = 2,
                            LastName = "Smith",
                            Phone = "+231770333223",
                            Salary = 9000m
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 3,
                            Email = "sam@outlook.com",
                            FirstName = "Sam",
                            Gender = 1,
                            LastName = "Smith",
                            Phone = "+231770125473",
                            Salary = 5000m
                        },
                        new
                        {
                            Id = 4,
                            DepartmentId = 4,
                            Email = "dadwonkulah@tuseTheProgrammer.com",
                            FirstName = "Dad",
                            Gender = 1,
                            LastName = "Wonkulah",
                            Phone = "+231775060775",
                            Salary = 450000m
                        });
                });

            modelBuilder.Entity("TypesOfLoadingEFCore.Web.Models.Employee", b =>
                {
                    b.HasOne("TypesOfLoadingEFCore.Web.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("TypesOfLoadingEFCore.Web.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
