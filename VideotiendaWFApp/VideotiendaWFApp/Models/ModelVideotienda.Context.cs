﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideotiendaWFApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VIDEOTIENDAEntities : DbContext
    {
        public VIDEOTIENDAEntities()
            : base("name=VIDEOTIENDAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<alq_videojuegos> alq_videojuegos { get; set; }
        public virtual DbSet<alquiler> alquiler { get; set; }
        public virtual DbSet<cat_videojuegos> cat_videojuegos { get; set; }
        public virtual DbSet<categorias> categorias { get; set; }
        public virtual DbSet<dominios> dominios { get; set; }
        public virtual DbSet<personas> personas { get; set; }
        public virtual DbSet<productores> productores { get; set; }
        public virtual DbSet<videojuegos> videojuegos { get; set; }
    }
}