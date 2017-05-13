using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanalNoticias.Services
{
    public class ListasService
    {
        public IList<SelectListItem> ObterCategorias()
        {
            var categorias = new List<SelectListItem>()
            {
                new SelectListItem { Value = "Death", Text = "Death" },
                new SelectListItem { Value = "Thrash", Text = "Thrash" },
                new SelectListItem { Value = "Symphonic", Text = "Symphonic" },
                new SelectListItem { Value = "Heavy", Text = "Heavy" }
            };
            return categorias;
        }

        public IList<SelectListItem> ObterImagens()
        {
            var imagens = new List<SelectListItem>()
            {
                new SelectListItem { Value = "arch-enemy.jpg", Text = "arch-enemy.jpg" },
                new SelectListItem { Value = "epica.jpg", Text = "epica.jpg" },
                new SelectListItem { Value = "ghost.jpg", Text = "ghost.jpg" },
                new SelectListItem { Value = "nightwish.jpg", Text = "nightwish.jpg" },
                new SelectListItem { Value = "sepultura.jpg", Text = "sepultura.jpg" }
            };
            return imagens;
        }
    }
}
