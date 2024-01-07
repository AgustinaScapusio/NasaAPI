using System.ComponentModel.DataAnnotations;

namespace NasaAPI.Models
{
    public class IndexViewModel
    {
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; } = DateTime.Today;
        public Apod PictureOfTheDay { get; set; }
    }
}
