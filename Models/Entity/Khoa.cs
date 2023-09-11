using System.ComponentModel.DataAnnotations;

namespace LaiSuat.Models.Entity
{
    public class Khoa
    {
        [Key]
        public string MaKhoa { get; set; }
        [Required]
        public string TenKhoa { get; set; }
        [Required]
        public string DienThoai { get; set; }
    }
}
