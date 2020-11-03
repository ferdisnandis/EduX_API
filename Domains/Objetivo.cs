using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Text;

namespace EduX_API.Domains
{

    public class Objetivo : BaseDomain

    {
        public string Descricao { get; set; }

        //FK em Categoria 
        public Guid IdCategoria { get; set; }
        [ForeignKey("IdCategoria")]
        public Categoria Categoria { get; set; }

        [NotMapped]
        public IFormFile Imagem { get; set; }
        public string UrlImagem { get; set; }




        public void SalvarArquivo(Objetivo obj)
        {
            if (obj.Imagem != null)
            {
                string path = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Images", obj.Imagem.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    obj.Imagem.CopyTo(stream);
                    obj.UrlImagem = path;
                }
            }
        }

    }

}