using LottoLab.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LottoLab.Mapping
{
    public class LotoFacilMostDownMapping : IEntityTypeConfiguration<LotoFacilMostDown>
    {
        public void Configure(EntityTypeBuilder<LotoFacilMostDown> builder)
        {
            builder.ToTable("LotoFacilMostDown");
            builder.HasKey(L => L.Id);
            builder.Property(L => L.Concurso).HasColumnType("int");
            builder.Property(L => L.Data).HasMaxLength(20);
            builder.Property(L => L.bola1).HasColumnType("int");
            builder.Property(L => L.bola2).HasColumnType("int");
            builder.Property(L => L.bola3).HasColumnType("int");
            builder.Property(L => L.bola4).HasColumnType("int");
            builder.Property(L => L.bola5).HasColumnType("int");
            builder.Property(L => L.bola6).HasColumnType("int");
            builder.Property(L => L.bola7).HasColumnType("int");
            builder.Property(L => L.bola8).HasColumnType("int");
            builder.Property(L => L.bola9).HasColumnType("int");
            builder.Property(L => L.bola10).HasColumnType("int");
            builder.Property(L => L.bola11).HasColumnType("int");
            builder.Property(L => L.bola12).HasColumnType("int");
            builder.Property(L => L.bola13).HasColumnType("int");
            builder.Property(L => L.bola14).HasColumnType("int");
            builder.Property(L => L.bola15).HasColumnType("int");
            builder.Property(L => L.bola16).HasColumnType("int");
            builder.Property(L => L.bola17).HasColumnType("int");
            builder.Property(L => L.bola18).HasColumnType("int");
            builder.Property(L => L.bola19).HasColumnType("int");
            builder.Property(L => L.bola20).HasColumnType("int");
            builder.Property(L => L.bola21).HasColumnType("int");
            builder.Property(L => L.bola22).HasColumnType("int");
            builder.Property(L => L.bola23).HasColumnType("int");
            builder.Property(L => L.bola24).HasColumnType("int");
            builder.Property(L => L.bola25).HasColumnType("int");
        }
    }
}