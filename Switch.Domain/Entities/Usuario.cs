using Switch.Domain.Enums;
using System;
using System.Collections.Generic;

namespace Switch.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }
        public SexoEnum Sexo { get; set; }
        public string UrlFoto { get; set; }

        public virtual Identificacao Identificacao { get; set; }
        public virtual StatusRelacionamento StatusRelacionamento { get; set; }
        public ProcurandoPor ProcurandoPor { get;  set; }
        public virtual ICollection<Postagem> Postagens { get; set; }
        public virtual ICollection<UsuarioGrupo> UsuariosGrupos { get; set; }
        public virtual ICollection<LocalTrabalho> LocalTrabalhos { get; set; }
        public virtual ICollection<InstituicaoEnsino> InstituicoesEnsinos { get; set; }
        public virtual ICollection<Amigo> Amigos { get; set; }
        public virtual ICollection<Comentario> Comentarios { get; set; }

        public Usuario()
        {
            Postagens = new List<Postagem>();
            UsuariosGrupos = new List<UsuarioGrupo>();
            LocalTrabalhos = new List<LocalTrabalho>();
            InstituicoesEnsinos = new List<InstituicaoEnsino>();
            Amigos = new List<Amigo>();

        }
    }
}
