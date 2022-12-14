using InventoryManagementApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;


namespace InventoryManagementApp.Migrations
{
    [DbContext(typeof(InventoryManagementAppContext))]
    partial class InventoryManagementAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InventoryManagementApp.Models.Computer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ComputerSpecification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InstallationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ManufacturerSerialNumber")
                        .HasColumnType("int");

                    b.Property<string>("OfficeLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficeRoomNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperatingSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Computer");
                });
#pragma warning restore 612, 618
        }
    }
}
