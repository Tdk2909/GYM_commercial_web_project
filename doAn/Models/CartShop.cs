using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using doAn.Models;

namespace doAn.Models
{
    public class CartShop
    {
        public String MaKH { get; set; }
        public String TaiKhoan { get; set; }
        public DateTime NgayDat { get; set; }
        public DateTime NgayGiao { get; set; }
        public String DiaChi { get; set; }
        public SortedList<string, CtDonHang> SPTrongCart { get; set; }

        /// Default Constructor
        public CartShop()
        {
            this.MaKH = ""; this.TaiKhoan = ""; this.NgayDat = DateTime.Now; this.NgayGiao = DateTime.Now.AddDays(2);
            this.DiaChi = "";
            this.SPTrongCart = new SortedList<string, CtDonHang>();
        }

		//
		/// Ham kiem tra neu Cart rong
		///
		public bool sEmpty()
		{
			return (SPTrongCart.Keys.Count == 0);
		}

		/// Them san pham vao gio hang
		public void addItem(string maSP)
		{
			if (SPTrongCart.Keys.Contains(maSP))
			{
				/// Lay san pham tu trong gio hang
				CtDonHang x = SPTrongCart.Values[SPTrongCart.IndexOfKey(maSP)];
		        /// Tang so luong len 1
				x.soLuong++;
				/// Gan lai gia tri cho gio hang sau khi cap nhat soLuong
				updateOneItem(x);
			}
			else
			{
				CtDonHang i = new CtDonHang();
				i.maSP = maSP;
				i.soLuong = 1;
				SanPham z = Common.GetProductByID(maSP);
				i.giaBan = z.giaBan;
				i.giamGia = z.giamGia;

				/// Phuong thuc them SanPham da chon vao danh sach Cart
				SPTrongCart.Add(maSP, i);
			}
		}
		public void updateOneItem(CtDonHang x)
		{
			this.SPTrongCart.Remove(x.maSP);
			this.SPTrongCart.Add(x.maSP, x);
		}
		/// Xoa san pham trong gio hang	
		public void deleteItem(string maSP)
		{
			if (SPTrongCart.Keys.Contains(maSP))
			{
				SPTrongCart.Remove(maSP);
			}
		}
		/// Giam so luong hoac xoa SP trong Cart
		public void decrease(string maSP)
		{
			if (SPTrongCart.Keys.Contains(maSP))
			{
				CtDonHang x = SPTrongCart.Values[SPTrongCart.IndexOfKey(maSP)];
				if(x.soLuong > 1)
				{
					x.soLuong--;
					updateOneItem(x);
				}
			}
			else
				deleteItem(maSP);
		}
		///
		/// Tien cua 1 SP da chon
		///
		public long MoneyOf1Product(CtDonHang x)
		{
			return (long)(x.giaBan * x.soLuong - (x.giaBan * x.soLuong * x.giamGia / 100));
		}
		///
		/// Tong tien cua cac san pham trong Cart
		///
		public long TotalMoney()
		{
			long kq = 0;
			foreach (CtDonHang lmao in SPTrongCart.Values)
				kq += MoneyOf1Product(lmao);
			return kq;
		}

	}

}