//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class LIVRO
    {
        public LIVRO()
        {
            this.EMPRESTIMO = new HashSet<EMPRESTIMO>();
            this.LIVROS_AUTORES = new HashSet<LIVROS_AUTORES>();
            this.RESERVAS_LIVROS_ALUNOS = new HashSet<RESERVAS_LIVROS_ALUNOS>();
        }
    
        public int ID_LIVRO { get; set; }
        public string TITULO { get; set; }
        public int VOLUME { get; set; }
        public System.DateTime DATA_PUBLIC { get; set; }
        public int QTD_EXEMP { get; set; }
        public string SUMARIO { get; set; }
        public int ID_EDITORA { get; set; }
        public int ID_GENERO { get; set; }
    
        public virtual EDITORA EDITORA { get; set; }
        public virtual ICollection<EMPRESTIMO> EMPRESTIMO { get; set; }
        public virtual GENERO GENERO { get; set; }
        public virtual ICollection<LIVROS_AUTORES> LIVROS_AUTORES { get; set; }
        public virtual ICollection<RESERVAS_LIVROS_ALUNOS> RESERVAS_LIVROS_ALUNOS { get; set; }
    }
}
