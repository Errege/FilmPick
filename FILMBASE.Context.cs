//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FilmPick
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FilmPickEntities3 : DbContext
    {
     
        public FilmPickEntities3()
            : base("name=FilmPickEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
      

        public virtual DbSet<ACTOR> ACTOR { get; set; }
        public virtual DbSet<DATA> DATA { get; set; }
        public virtual DbSet<FILM> FILM { get; set; }
        public virtual DbSet<GERNE> GERNE { get; set; }
        public virtual DbSet<PRODUCER> PRODUCER { get; set; }
        public virtual DbSet<RATING> RATING { get; set; }
        public virtual DbSet<SCREENWRITER> SCREENWRITER { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
