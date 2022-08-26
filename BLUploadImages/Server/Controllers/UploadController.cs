using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Hosting;
using BLUploadImages.Shared;

namespace BLUploadImages.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {

        private readonly IWebHostEnvironment env;

        public UploadController(IWebHostEnvironment env)
        {
            this.env = env;
        }

        [HttpPost]
        public async Task Post([FromBody] ImageFile[] files)
        {
            foreach (var file in files)
            {
                var buf = Convert.FromBase64String(file.base64data);

                await System.IO.File.WriteAllBytesAsync(env.ContentRootPath + System.IO.Path.DirectorySeparatorChar + Guid.NewGuid().ToString("N") + "-" + file.fileName, buf);
            }
        }
    }
}
