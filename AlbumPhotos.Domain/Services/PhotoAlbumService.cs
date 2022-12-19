using AlbumPhotos.Domain.Interfaces;
using AlbumPhotos.Domain.Models;
using AlbumPhotos.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlbumPhotos.Domain.Services
{
    public class PhotoAlbumService:IPhotoAlbumService
    {
        private readonly IPhotoAlbumDataService _service;
        // private readonly IConfiguration _configuration;

        public PhotoAlbumService(IPhotoAlbumDataService service)
        {
            _service = service;

        }
        public IEnumerable<PhotoAlbum> GetData(int UserID)
        {
            IEnumerable<PhotoAlbum> albums = _service.GetData(UserID);
            return albums;
        }

        public IEnumerable<PhotoAlbum> GetAllData(Parameters parameters)
        {
            IEnumerable<PhotoAlbum> albums = _service.GetAllData( parameters);
            return albums;
        }

      
    }
}
