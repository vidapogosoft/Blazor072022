﻿using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace LocalStoragesArray
{
    public interface ILocalStorage
    {
        public Task RemoveAsync(string key);
        public Task SaveStringAsync(string key, string value);
        public Task<string> GetStringAsync(string key);
        public Task SaveStringArrayAsync(string key, string[] values);
        public Task<string[]> GetStringArrayAsync(string key);
        public Task SaveObjectAsync(string key, object value);
        public Task<T> GetObjectAsync<T>(string key);

    }
    public class LocalStorage : ILocalStorage
    {
        private readonly IJSRuntime jsruntime;
        public LocalStorage(IJSRuntime jSRuntime)
        {
            jsruntime = jSRuntime;
        }

        public async Task RemoveAsync(string key)
        {
            await jsruntime.InvokeVoidAsync("localStorage.removeItem", key).ConfigureAwait(false);
        }
        public async Task SaveStringAsync(string key, string value)
        {
            await jsruntime.InvokeVoidAsync("localStorage.setItem", key, value).ConfigureAwait(false);
        }

        public async Task<string> GetStringAsync(string key)
        {
            return await jsruntime.InvokeAsync<string>("localStorage.getItem", key).ConfigureAwait(false);
        }

        public async Task SaveStringArrayAsync(string key, string[] values)
        {
            if (values != null)
                await jsruntime.InvokeVoidAsync("localStorage.setItem", key, string.Join('\0', values)).ConfigureAwait(false);
        }

        public async Task<string[]> GetStringArrayAsync(string key)
        {
            var data = await jsruntime.InvokeAsync<string>("localStorage.getItem", key).ConfigureAwait(false);
            if (!string.IsNullOrEmpty(data))
                return data.Split('\0');
            return null;
        }

        public async Task SaveObjectAsync(string key, object value)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(value);
            byte[] data = System.Text.Encoding.UTF8.GetBytes(json);
            string b64 = System.Convert.ToBase64String(data);
            await SaveStringAsync(key, b64);
        }

        public async Task<T> GetObjectAsync<T>(string key)
        {
            string b64 = await GetStringAsync(key);
            
            //if (b64 == null) { return null; }
                
            byte[] data = System.Convert.FromBase64String(b64);
            string json = System.Text.Encoding.UTF8.GetString(data);
            return System.Text.Json.JsonSerializer.Deserialize<T>(json);
        }
    }
}
