
using LottoLab.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LottoLab.Mapping
{
    public class LotoFacilRNAMapping : IEntityTypeConfiguration<LotoFacilRNA>
    {
        public void Configure(EntityTypeBuilder<LotoFacilRNA> builder)
        {
            builder.ToTable("LotoFacilRNA");
            builder.HasKey(L => L.Id);
            builder.Property(L => L.Concurso).HasColumnType("char");
            builder.Property(L => L.Data).HasMaxLength(20);
            builder.Property(L => L.bola1).HasColumnType("char");
            builder.Property(L => L.bola2).HasColumnType("char");
            builder.Property(L => L.bola3).HasColumnType("char");
            builder.Property(L => L.bola4).HasColumnType("char");
            builder.Property(L => L.bola5).HasColumnType("char");
            builder.Property(L => L.bola6).HasColumnType("char");
            builder.Property(L => L.bola7).HasColumnType("char");
            builder.Property(L => L.bola8).HasColumnType("char");
            builder.Property(L => L.bola9).HasColumnType("char");
            builder.Property(L => L.bola10).HasColumnType("char");
            builder.Property(L => L.bola11).HasColumnType("char");
            builder.Property(L => L.bola12).HasColumnType("char");
            builder.Property(L => L.bola13).HasColumnType("char");
            builder.Property(L => L.bola14).HasColumnType("char");
            builder.Property(L => L.bola15).HasColumnType("char");
            builder.Property(L => L.bola16).HasColumnType("char");
            builder.Property(L => L.bola17).HasColumnType("char");
            builder.Property(L => L.bola18).HasColumnType("char");
            builder.Property(L => L.bola19).HasColumnType("char");
            builder.Property(L => L.bola20).HasColumnType("char");
            builder.Property(L => L.bola21).HasColumnType("char");
            builder.Property(L => L.bola22).HasColumnType("char");
            builder.Property(L => L.bola23).HasColumnType("char");
            builder.Property(L => L.bola24).HasColumnType("char");
            builder.Property(L => L.bola25).HasColumnType("char");
        }        
    }    
}