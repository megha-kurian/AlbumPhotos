using AlbumPhotos.Domain.Models;
using AlbumPhotos.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlbumPhotos.Domain.Repositories
{

    public interface IPhotoAlbumDataService
    {
        IEnumerable<PhotoAlbum> GetAllData(Parameters parameters);
        IEnumerable<PhotoAlbum> GetData(int userid);
    }
}
