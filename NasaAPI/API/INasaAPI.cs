using Microsoft.AspNetCore.ResponseCompression;
using NasaAPI.Models;
using System.Text.Json;

namespace NasaAPI.API
{
    public interface INasaAPI
    {
        Task<Apod> GetApodAsync(DateTime date);
    }

}
