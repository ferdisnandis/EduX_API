using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduX_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        [HttpGet("{arquivo}")]
        public IActionResult Get(string arquivo)
        {
            string directory = "Images";
            return PhysicalFile(Path.Combine(System.IO.Directory.GetCurrentDirectory(), directory , arquivo), "image/jpeg");
        }
    }
}
