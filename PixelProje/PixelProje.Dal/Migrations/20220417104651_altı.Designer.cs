// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PixelProje.Dal;

#nullable disable

namespace PixelProje.Dal.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220417104651_altı")]
    partial class altı
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PixelProje.Ent.Abone", b =>
                {
                    b.Property<int>("AboneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AboneId"), 1L, 1);

                    b.Property<bool>("AboneSituation")
                        .HasColumnType("bit");

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Deposit")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboneId");

                    b.ToTable("Abone");
                });

            modelBuilder.Entity("PixelProje.Ent.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceId"), 1L, 1);

                    b.Property<int>("AboneId")
                        .HasColumnType("int");

                    b.Property<string>("InvoiceAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InvoiceAmount")
                        .HasColumnType("int");

                    b.Property<string>("InvoiceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvoiceSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InvoiceTel")
                        .HasColumnType("int");

                    b.Property<int?>("InvoicesInvoiceId")
                        .HasColumnType("int");

                    b.HasKey("InvoiceId");

                    b.HasIndex("AboneId");

                    b.HasIndex("InvoicesInvoiceId");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("PixelProje.Ent.Invoice", b =>
                {
                    b.HasOne("PixelProje.Ent.Abone", "Abone")
                        .WithMany("Invoice")
                        .HasForeignKey("AboneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PixelProje.Ent.Invoice", "Invoices")
                        .WithMany()
                        .HasForeignKey("InvoicesInvoiceId");

                    b.Navigation("Abone");

                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("PixelProje.Ent.Abone", b =>
                {
                    b.Navigation("Invoice");
                });
#pragma warning restore 612, 618
        }
    }
}
