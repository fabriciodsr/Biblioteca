﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BibliotecaVirtualEntities : DbContext
    {
        public BibliotecaVirtualEntities()
            : base("name=BibliotecaVirtualEntities")
        {
            Configuration.ProxyCreationEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ALUNO> ALUNO { get; set; }
        public DbSet<AUTOR> AUTOR { get; set; }
        public DbSet<EDITORA> EDITORA { get; set; }
        public DbSet<EMPRESTIMO> EMPRESTIMO { get; set; }
        public DbSet<GENERO> GENERO { get; set; }
        public DbSet<LIVRO> LIVRO { get; set; }
        public DbSet<LIVROS_AUTORES> LIVROS_AUTORES { get; set; }
        public DbSet<RESERVA> RESERVA { get; set; }
        public DbSet<RESERVAS_LIVROS_ALUNOS> RESERVAS_LIVROS_ALUNOS { get; set; }
    }
}
