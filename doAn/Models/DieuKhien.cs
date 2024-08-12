using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace doAn.Models
{
    public class DieuKhien
    {
        /// <summary>
        /// Hàm lấy danh sach tất cả các  loại sản phẩm;
        /// </summary>
        /// <returns></returns>
        public static List<SanPham> getSanPham()
        {
            List<SanPham> d = new List<SanPham>();
            ///
            /// Khai báo đối tượng đại diện cho database
            ///
            DbContext cn = new DbContext("name=ChuaTeBanHangLongEntities");
            d = cn.Set<SanPham>().ToList<SanPham>();
            return d;
        }
        ///
        /// hàm lấy ra loại sp dựa trên phái
        /// 
        public static List<LoaiSP> getLoaiSPByGioiTinh(string gioitinh)
        {
            return new DbContext("name=ChuaTeBanHangLongEntities").Set<LoaiSP>().Where<LoaiSP>(x=>x.gioiTinh==gioitinh).ToList<LoaiSP>();
        }
        public static List<SanPham> getSanPhamByMaLoai(int maloai)
        {
            return new DbContext("name=ChuaTeBanHangLongEntities").Set<SanPham>().Where<SanPham>(y => y.maLoai == maloai).ToList<SanPham>();
        }
        /// <summary>
        /// hàm lấy ra ds sp dựa trên loại hàng
        /// </summary>
        /// <returns></returns>
        public static List<LoaiSP> GetMaLoai()
        {
            return new DbContext("name=ChuaTeBanHangLongEntities").Set<LoaiSP>().ToList<LoaiSP>();
        }
    }
}