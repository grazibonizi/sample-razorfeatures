using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CanalNoticias.Models
{
    public class Noticia
    {
        public int Id { get; set; }
        public string TituloURL { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public string FotoPrincipal { get; set; }
        public bool EhDestaque { get; set; }
        public string Categoria { get; set; }

        public void FormatarTituloUrl(string titulo)
        {
            TituloURL = titulo.ToLower().Trim().Replace(" ", "-");                 
        }

        public Noticia()
        {

        }        
    }
}
