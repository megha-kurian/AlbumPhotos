using AlbumPhotos.Data.Repositories;
using AlbumPhotos.Domain.Interfaces;
using AlbumPhotos.Domain.Repositories;
using AlbumPhotos.Domain.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumPhotos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
                Host.CreateDefaultBuilder(args)
                    .ConfigureWebHostDefaults(webBuilder =>
                    {
                        webBuilder.UseStartup<Startup>();
                    }).ConfigureServices((_, services) =>
                    services.AddScoped<IPhotoAlbumService, PhotoAlbumService>()
                    .AddScoped<IPhotoAlbumDataService, PhotoAlbumDataService>());



    }
}
