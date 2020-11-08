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




        public string SalvarArquivo(Objetivo obj)
        {
            string url = null;
            if (obj.Imagem != null)
            {
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(obj.Imagem.FileName);
                string directory = "Images";
                string path = Path.Combine(System.IO.Directory.GetCurrentDirectory(), directory, fileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    obj.Imagem.CopyTo(stream);
                    url = "http://localhost:64557/" + directory + "/" + fileName;
                }
            }
            return url;
        }

    }

}