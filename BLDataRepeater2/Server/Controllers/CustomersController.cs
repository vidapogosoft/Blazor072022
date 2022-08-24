using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using BLDataRepeater2.Shared;

namespace BLDataRepeater2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
		private string DataFolder { get; }
		private IWebHostEnvironment env { get; }
		public CustomersController(IWebHostEnvironment env)
		{
			this.env = env;
			DataFolder = env.ContentRootPath + Path.DirectorySeparatorChar + "CustomersData";
			try
			{
				if (!System.IO.Directory.Exists(DataFolder))
					System.IO.Directory.CreateDirectory(DataFolder);
			}
			catch { }
		}

		[HttpPut("{id}")]
		public async Task<Customer> Put(string id, [FromBody] Customer cust)
		{
			return await Task.Run(() =>
			{
				try
				{
					cust.id = id;
					System.IO.File.WriteAllText(DataFolder + Path.DirectorySeparatorChar + id + ".json", JsonSerializer.Serialize(cust));
					return cust;
				}
				catch { return null; }
			});
		}

		[HttpDelete("{id}")]
		public async Task<Customer> Delete(string id)
		{
			return await Task.Run(() =>
			{
				var di = new DirectoryInfo(DataFolder);
				try
				{
					string file = DataFolder + Path.DirectorySeparatorChar + id + ".json";
					var cust = JsonSerializer.Deserialize<Customer>(System.IO.File.ReadAllText(file));
					System.IO.File.Delete(file);
					return cust;
				}
				catch { return null; }
			});
		}

		[HttpPost]
		public async Task<Customer> Post([FromBody] Customer cust)
		{
			return await Task.Run(() =>
			{
				var di = new DirectoryInfo(DataFolder);
				string id = Guid.NewGuid().ToString("N");
				cust.id = id;
				if (cust.name == null)
					cust.name = string.Empty;
				else
					cust.name = cust.name.Substring(0, cust.name.Length > 100 ? 100 : cust.name.Length);
				if (cust.address == null)
					cust.address = string.Empty;
				else
					cust.address = cust.address.Substring(0, cust.address.Length > 100 ? 100 : cust.address.Length);
				if (cust.zip == null)
					cust.zip = string.Empty;
				else
					cust.zip = cust.zip.Substring(0, cust.zip.Length > 10 ? 10 : cust.zip.Length);
				try
				{
					System.IO.File.WriteAllText(DataFolder + Path.DirectorySeparatorChar + id + ".json", JsonSerializer.Serialize(cust));
					return cust;
				}
				catch { return null; }
			});
		}

		[HttpGet]
		public async Task<IEnumerable<Customer>> Get()
		{
			return await Task.Run(() =>
			{
				var di = new DirectoryInfo(DataFolder);
				FileInfo[] fi = di.GetFiles("*", SearchOption.TopDirectoryOnly);
				var q = from f in fi orderby f.CreationTime descending select f;
				var custs = new List<Customer>();
				for (int i = 0; i < fi.Length; i++)
					custs.Add(JsonSerializer.Deserialize<Customer>(System.IO.File.ReadAllText(fi[i].FullName)));
				return custs;
			});
		}

	}
}
