using AlbumPhotos.Domain.Models;
using AlbumPhotos.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlbumPhotos.Domain.Interfaces
{
    public interface IPhotoAlbumService
    {
        IEnumerable<PhotoAlbum> GetAllData(Parameters parameters);
        IEnumerable<PhotoAlbum> GetData(int userid);
    }
}
