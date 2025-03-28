using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Web.UI.WebControls;
namespace Winform_Nhom20_BTL.Model
{
    internal class phimmodel
    {
        private int idphim;
        private string tenphim;
        private int thoiluong;
        private string theloai;
        private string daodien;
        private string mota;
        private string hinhanh;

        [DisplayName ("ID_phim")]
        
        public int Idphim { get => idphim; set => idphim = value; }
        [DisplayName("Ten_phim")]
        [Required(ErrorMessage = "Tên phim bắt buộc")]
        [StringLength(50,MinimumLength = 3,ErrorMessage ="Tên phim phải cso độ dài từ 3-50 kí tự")]
        public string Tenphim { get => tenphim; set => tenphim = value; }
        [DisplayName("Thoi_luong")]
        public int Thoiluong { get => thoiluong; set => thoiluong = value; }
        [DisplayName("The_loai")]
        [Required(ErrorMessage = "Thể loại bắt buộc")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Thể loại phải cso độ dài từ 3-50 kí tự")]
        public string Theloai { get => theloai; set => theloai = value; }
        [DisplayName("Dao_dien")]
        [Required(ErrorMessage = "Đạo diễn bắt buộc")]
        //[StringLength(50, MinimumLength = 3, ErrorMessage = "Tên phim phải cso độ dài từ 3-50 kí tự")]
        public string Daodien { get => daodien; set => daodien = value; }
        [DisplayName("Mo_ta")]
        public string Mota { get => mota; set => mota = value; }
        [DisplayName("Hinh_anh")]
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }
    }
}
