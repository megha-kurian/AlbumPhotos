
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using AlbumPhotos.Domain.Models;
using AlbumPhotos.Domain.Repositories;
using Newtonsoft.Json;
using System.Linq;
using Newtonsoft.Json.Linq;
using AlbumPhotos.Domain.Services;

namespace AlbumPhotos.Data.Repositories
{
    public class PhotoAlbumDataService : IPhotoAlbumDataService
    {
        public IEnumerable<PhotoAlbum> GetData(int UserID)
        {
            var webClient = new WebClient();
            webClient.Headers.Add(HttpRequestHeader.Cookie, "cookievalue");
            var json = webClient.DownloadString(@"http://jsonplaceholder.typicode.com/albums");
            var album = JsonConvert.DeserializeObject<List<Album>>(json);
            string photojson = webClient.DownloadString(@"https://jsonplaceholder.typicode.com/photos");
            List<Photos> photos = JsonConvert.DeserializeObject<List<Photos>>(photojson);
            List<PhotoAlbum> photosList = new List<PhotoAlbum>();
            List<Album> fileteredAlbum = album.Where(c => c.UserId == UserID).ToList();
            if (fileteredAlbum.Count>0)
            {
                foreach (var item in fileteredAlbum)
                {
                    List<Photos> filteredList = photos.Where(c => c.AlbumId == item.Id).ToList();
                    photosList.Add(new PhotoAlbum()
                    {
                        AlbumId = item.Id,
                        UserId = item.UserId,
                        Photos = filteredList,
                        Title = item.Title

                    });

                }
                return photosList;
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<PhotoAlbum> GetAllData(Parameters parameters)
        {
            var webClient = new WebClient();
            webClient.Headers.Add(HttpRequestHeader.Cookie, "cookievalue");
            var json = webClient.DownloadString(@"http://jsonplaceholder.typicode.com/albums");
            var album = JsonConvert.DeserializeObject<List<Album>>(json);
            string photojson= webClient.DownloadString(@"https://jsonplaceholder.typicode.com/photos");         
            List<Photos> photos = JsonConvert.DeserializeObject<List<Photos>>(photojson);
            List<PhotoAlbum> photosList = new List<PhotoAlbum>();
            
            foreach (var item in album)
            {
                List<Photos> lineItem = photos.Where(c => c.AlbumId == item.Id).ToList();
                photosList.Add(new PhotoAlbum()
                {
                    AlbumId=item.Id,
                    UserId=item.UserId,
                    Photos= lineItem,
                    Title=item.Title

                });              

             }
            return photosList.OrderBy(on => on.UserId)
            .Skip((parameters.PageNumber - 1) * parameters.PageSize)
            .Take(parameters.PageSize)
            .ToList(); 
        }

    }
}
