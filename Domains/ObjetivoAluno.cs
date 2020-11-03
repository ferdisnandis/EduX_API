using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_API.Domains
{
    public class ObjetivoAluno : BaseDomain
    {
        public float Nota { get; set; }
        public DateTime DataAlcancado { get; set; }

        //FK : ID ALUNO TURMA E ID OBJETIVO

        public Guid IdAlunoTurma { get; set; }
        [ForeignKey("IdAlunoTurma")]
        public AlunoTurma AlunoTurma { get; set; }

        public Guid IdTurma { get; set; }
        [ForeignKey("IdTurma")]
        public Turma Turma{ get; set; }

<<<<<<< HEAD
        public Guid IdObjetivo { get; set; }
        [ForeignKey("IdObjetivo")]
        public Objetivo Objetivo { get; set; }
=======
        [NotMapped]
        public IFormFile Imagem { get; set; }
        public string UrlImagem { get; set; }


        public void SalvarArquivo(ObjetivoAluno obja)
        {
            if (obja.Imagem != null)
            {
                string fileName = Guid.NewGuid().ToString();
                string directory = "Images";
                string path = Path.Combine(System.IO.Directory.GetCurrentDirectory(), directory, fileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    obja.Imagem.CopyTo(stream);
                    obja.UrlImagem = directory + "/" + fileName;
                }
            }

        }
>>>>>>> 8896f86d7d9aa3b439bbb6aad32763790398e1d1
    }
}