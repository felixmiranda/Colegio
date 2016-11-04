namespace Colegio.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class colegioContext : DbContext
    {
        public colegioContext()
            : base("name=colegioContext")
        {
        }

        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            //modelBuilder.Entity<Alumno>()
            //    .HasMany(e => e.Curso)
            //    .WithMany(e => e.Alumno)
            //    .IsUnicode(false);

        }
    }
}
