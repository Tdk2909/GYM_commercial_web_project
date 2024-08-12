using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using doAn.Controllers;
namespace doAn.Models
{
    public class Common
    {
      
        /// <summary>
        /// Hàm lấy danh sach tất cả các  loại sản phẩm;
        /// </summary>
        /// <returns></returns>
        public static List<TaiKhoan> getTaiKhoan2()
        {
            List<TaiKhoan> d = new List<TaiKhoan>();
            ///
            /// Khai báo đối tượng đại diện cho database
            ///
            DbContext cn = new DbContext("name=DuLieu2Entities2");
            d = cn.Set<TaiKhoan>().ToList<TaiKhoan>();
            return d;
        }
        public static List<SanPham> getSanPham2()
        {
            List<SanPham> d = new List<SanPham>();
            ///
            /// Khai báo đối tượng đại diện cho database
            ///
            DbContext cn = new DbContext("name=DuLieu2Entities2");
            d = cn.Set<SanPham>().ToList<SanPham>();
            return d;
        }
        public static List<DonHang> getDonHang2()
        {
            List<DonHang> d = new List<DonHang>();
            ///
            /// Khai báo đối tượng đại diện cho database
            ///
            DbContext cn = new DbContext("name=DuLieu2Entities2");
            d = cn.Set<DonHang>().ToList<DonHang>();
            return d;
        }
        public static List<KhachHang> getKhachHang()
        {
            List<KhachHang> d = new List<KhachHang>();
            ///
            /// Khai báo đối tượng đại diện cho database
            ///
            DbContext cn = new DbContext("name=DuLieu2Entities2");
            d = cn.Set<KhachHang>().ToList<KhachHang>();
            return d;
        }
       
        public static List<CtDonHang> getCtDonHang2()
        {
            List<CtDonHang> d = new List<CtDonHang>();
            ///
            /// Khai báo đối tượng đại diện cho database
            ///
            DbContext cn = new DbContext("name=DuLieu2Entities2");
            d = cn.Set<CtDonHang>().ToList<CtDonHang>();
            return d;
        }

        ///
        /// hàm lấy ra loại sp dựa trên phái
        /// 
        public static List<LoaiSP> getLoaiSPByGioiTinh(string gioitinh)
        {
            return new DbContext("name=DuLieu2Entities2").Set<LoaiSP>().Where<LoaiSP>(x => x.gioiTinh == gioitinh).ToList<LoaiSP>();
        }
        public static List<SanPham> getSanPhamByMaLoai(int maloai)
        {
            return new DbContext("name=DuLieu2Entities2").Set<SanPham>().Where<SanPham>(y => y.maLoai == maloai).ToList<SanPham>();
        }
        public static List<SanPham> getSanPhamByMaSanPham(string maSP)
        {
            return new DbContext("name=DuLieu2Entities2").Set<SanPham>().Where<SanPham>(z => z.maSP == maSP).ToList<SanPham>();
        }
        /// <summary>
        /// hàm lấy ra ds sp dựa trên loại hàng
        /// </summary>
        /// <returns></returns>
        public static List<LoaiSP> GetMaLoai()
        {
            return new DbContext("name=DuLieu2Entities2").Set<LoaiSP>().ToList<LoaiSP>();
        }

        ///
        /// hàm lấy ra danh sách bài viết
        ///
        public static List<BaiViet> getBaiViet(int n)
        {
            DuLieu2Entities2 db = new DuLieu2Entities2();
            List<BaiViet> l = new List<BaiViet>();
            l = db.BaiViets.OrderByDescending(baiViet => baiViet.ngayDang).Take(n).ToList<BaiViet>();
            return l;
        }
        ///
        /// hàm lấy danh sách bài viết theo mã bài viết
        ///
        public static List<BaiViet> GetBaiVietTheoMaBV(string mabv)
        {
            List<BaiViet> cc = new List<BaiViet>();
            DuLieu2Entities2 db = new DuLieu2Entities2();
            cc = db.BaiViets.OrderByDescending(baiViet => baiViet.ngayDang).Where(x=>x.maBV==mabv).ToList<BaiViet>();
            return cc;
        }

        ///
        /// hàm lấy danh sách admin theo mã bài viết
        ///
        public static List<TaiKhoan> getAdminTheoTaiKhoan(string tk)
        {
            return new DbContext("name=DuLieu2Entities2").Set<TaiKhoan>().Where(x => x.taiKhoan1 == tk).ToList<TaiKhoan>();
        }
      
        public static List<KhachHang> getTongKH()
        {
            return new DbContext("name=DuLieu2Entities2").Set<KhachHang>().ToList<KhachHang>();
        }
       
        public static SanPham GetProductByID(string maSP)
        {
            DuLieu2Entities2 db = new DuLieu2Entities2();
            return db.Set<SanPham>().Find(maSP);
        }
        public static string getNameOfProductByID(string maSP)
        {
            DuLieu2Entities2 db = new DuLieu2Entities2();
            return db.Set<SanPham>().Find(maSP).tenSP;
        }
        public static string getImagesOfProductByID(string maSP)
        {
            DuLieu2Entities2 db = new DuLieu2Entities2();
            return db.Set<SanPham>().Find(maSP).hinhDD;
        }
        public static string getNXSOfProductByID(string maSP)
        {
            DuLieu2Entities2 db = new DuLieu2Entities2();
            return db.Set<SanPham>().Find(maSP).nhaSanXuat;
        }
        public static string getSoLuongKH(string makh)
        {
            DuLieu2Entities2 db = new DuLieu2Entities2();
            return db.Set<KhachHang>().Find(makh).maKH;
        }
       

    }
}


