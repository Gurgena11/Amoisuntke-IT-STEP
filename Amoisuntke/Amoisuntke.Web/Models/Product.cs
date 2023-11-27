using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Amoisuntke.Web.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("დასახელება")]
        public string Name { get; set; }
        [DisplayName("აღწერა")]
        public string Description { get; set; }
        [DisplayName("ფოტო")]
        public string ImageUrl { get; set; }
        [Required]
        [DisplayName("ფასი")]
        public double Price { get; set; }
        [Required]
        [DisplayName("დაკლებული ფასი")]
        public double DiscountPrice { get; set; }
        [Required]
        [DisplayName("ხელმისაწვდომია")]
        public bool IsExpired { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("ფერი")]
        public string Color { get; set; }
        [Required]
        [DisplayName("რაოდენობა")]
        public int Quantity { get; set; }
        [DisplayName("ავზი")]
        public int Tank { get; set; }
        [DisplayName("დაცულია")]
        public bool IsSecured { get; set; }
        [DisplayName("გამოფრქვევა")]
        public int Splash { get; set; }
        [DisplayName("დაფარვის არეალი")]
        public int Coverage { get; set; }
        [Required]
        [DisplayName("არის თუ არა არომატი?")]
        public bool IsAroma { get; set; }
        [Required]
        [DisplayName("არის თუ არა ჰაერის დამატენიანებელი?")]
        public bool IsHumidifier { get; set; }
    }
}
