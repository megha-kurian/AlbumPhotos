using System;
using System.Collections.Generic;
using System.Text;

namespace AlbumPhotos.Domain.Models
{
    public class PhotoAlbum
    {
        public int UserId { get; set; }
        public int AlbumId { get; set; }
        public List<Photos> Photos { get; set; }
        public string Title { get; set; }
    }
}
