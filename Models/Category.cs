using System.ComponentModel.DataAnnotations;

namespace ProjectASP.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [StringLength(100)]
        public string CategoryName { get; set; } = string.Empty;

        public string? Description { get; set; }

        // Mối quan hệ: 1 Danh mục có nhiều Sản phẩm
        public ICollection<Product>? Products { get; set; }
    }
}