using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace Entities.Concrete
{
    public class CarImage:IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }

        [NotMapped]
        public IFormFile DocumentFile { get; set; }

        public string ImagePath { get; set; }
        public DateTime? Date { get; set; }
    }
}
