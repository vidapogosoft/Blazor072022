using System.IO;
using System.IO.Compression;
using System.Threading;
using System.Threading.Tasks;

namespace BLUploadFiles.Shared
{
    public class Compressor
    {
		public static async Task<byte[]> CompressBytesAsync(byte[] bytes, CancellationToken cancel = default(CancellationToken))
		{
			using (var outputStream = new MemoryStream())
			{
				using (var compressStream = new GZipStream(outputStream, CompressionLevel.Optimal))
				{
					await compressStream.WriteAsync(bytes, 0, bytes.Length, cancel);
				}
				return outputStream.ToArray();
			}
		}

		public static async Task<byte[]> DecompressBytesAsync(byte[] bytes, CancellationToken cancel = default(CancellationToken))
		{
			using (var inputStream = new MemoryStream(bytes))
			{
				using (var outputStream = new MemoryStream())
				{
					using (var decompressStream = new GZipStream(inputStream, CompressionMode.Decompress))
					{
						await decompressStream.CopyToAsync(outputStream, cancel);
					}
					return outputStream.ToArray();
				}
			}
		}
	}
}
