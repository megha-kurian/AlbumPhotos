
using AlbumPhotos.Configurations;
using AlbumPhotos.Domain.Interfaces;
using AlbumPhotos.Domain.Models;
using AlbumPhotos.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumPhotos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        
        private IPhotoAlbumService _photoalbumservice;
        //TODO:Logging
        //private readonly ILogger<AlbumController> _logger;

        public AlbumController( IPhotoAlbumService photoalbumservice)
        {            
            _photoalbumservice = photoalbumservice;
        }

        // GET api/values
        /// <summary>
        /// Get all album with photos
        /// </summary>
        /// <remarks>This API will get all the values.</remarks>
        
        [HttpGet]
        public ActionResult<List<PhotoAlbum>> GetAllData([FromQuery] Parameters parameters)
        {
            try
            {
                var photoalbum = _photoalbumservice.GetAllData(parameters);
                     
                if (photoalbum == null)
                {
                    return NotFound();
                }
              
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }

            return Ok(_photoalbumservice.GetAllData( parameters));

        }



        // POST api/<AlbumController>
        
        /// <summary>
        /// Get data for a user
        /// </summary>
        /// <remarks>This API will get values.</remarks>

        [HttpPost]
        public ActionResult<List<PhotoAlbum>> GetData ([FromBody] int userid)
        {
            try
            {
            var photoalbum =  _photoalbumservice.GetData(userid);
            if (photoalbum == null)
            {
                return NotFound();
            }
            }
            catch( Exception ex)
            {
                return StatusCode(500, ex);
            }

            return  Ok(_photoalbumservice.GetData(userid));
        }

        
    }
}
