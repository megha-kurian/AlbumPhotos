using AlbumPhotos.Controllers;
using AlbumPhotos.Domain.Interfaces;
using AlbumPhotos.Domain.Models;
using AlbumPhotos.Domain.Repositories;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace AlbumPhoto.Test
{

    public class PhotoAlbumTest
    {

        [Test]
        public void GetDataTestOk()
        {
            //Assign
            int id = 1;
           
            List<PhotoAlbum> photosList = new List<PhotoAlbum>();
            photosList.Add(new PhotoAlbum()
            {
                AlbumId = 1,
                UserId = 1,
                Photos = null,
                Title = "Test"

            });
            var service = new Mock<IPhotoAlbumService>();
            service.Setup(x => x.GetData(id)).Returns(photosList);
            AlbumController _controller = new AlbumController(service.Object);
            var result = _controller.GetData(id);
            //Assert
            Assert.AreEqual(result.Result.ToString(), "Microsoft.AspNetCore.Mvc.OkObjectResult");
           
        }

        [Test]
        public void GetDataTestNotFound()
        {
            int id = 1;

            List<PhotoAlbum> photosList = new List<PhotoAlbum>();
            photosList = null;
            var service = new Mock<IPhotoAlbumService>();           
            service.Setup(x => x.GetData(id)).Returns(photosList);
            AlbumController _controller = new AlbumController(service.Object);
            var result = _controller.GetData(id);
            Assert.AreEqual(result.Result.ToString(), "Microsoft.AspNetCore.Mvc.NotFoundResult");

        }

        //TODO:GetAllData Test
        //public void GetDataTestNotFound()
        //{
           
        //}





    }
}