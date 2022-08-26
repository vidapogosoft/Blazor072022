using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Hosting;
using System.Threading;
using System.IO;
using BLUploadFiles.Shared;

namespace BLUploadFiles.Server.Controllers
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
        public async Task Post([FromBody] FileX[] files, CancellationToken cancel)
        {
            foreach (var file in files)
            {
                var buf = Convert.FromBase64String(file.base64string);
                if ((file.state & 2) != 0)
                    buf = await Compressor.DecompressBytesAsync(buf, cancel);
                await System.IO.File.WriteAllBytesAsync(Path.Combine(env.ContentRootPath, Guid.NewGuid().ToString("N") + "-" + file.fileName), buf, cancel);
            }
        }


    }
}
