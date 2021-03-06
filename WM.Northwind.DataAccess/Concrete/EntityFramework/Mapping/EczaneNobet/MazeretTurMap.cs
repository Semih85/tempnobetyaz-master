﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using WM.Northwind.Entities.Concrete.EczaneNobet;

namespace WM.Northwind.DataAccess.Concrete.EntityFramework.Mapping.EczaneNobet
{
    public class MazeretTurMap : EntityTypeConfiguration<MazeretTur>
    {
        public MazeretTurMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Table & Column Mappings
            this.ToTable("MazeretTurler");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Adi).HasColumnName("Adi");

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Adi)
                .HasMaxLength(30)
                .IsRequired()
                .HasColumnAnnotation("Index",
                        new IndexAnnotation(
                            new IndexAttribute("UN_MazeretTurler_Adi")
                            {
                                IsUnique = true
                            }));

        }
    }
}
