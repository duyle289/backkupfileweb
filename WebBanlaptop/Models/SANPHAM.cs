﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanlaptop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            this.BINHLUAN = new HashSet<BINHLUAN>();
            this.CHITIETSP = new HashSet<CHITIETSP>();
        }
    
        public int MASP { get; set; }
        public string TENSP { get; set; }
        public Nullable<decimal> DONGIA { get; set; }
        public string HINHANH { get; set; }
        public bool TRANGTHAI { get; set; }
        public Nullable<int> MALSP { get; set; }
        public Nullable<int> MANSX { get; set; }
        public Nullable<bool> SANPHAMMOI { get; set; }
        public Nullable<bool> SPNOIBAT { get; set; }
        public string CAUHINH { get; set; }
        public string MOTA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BINHLUAN> BINHLUAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETSP> CHITIETSP { get; set; }
        public virtual LOAISANPHAM LOAISANPHAM { get; set; }
        public virtual NHASANXUAT NHASANXUAT { get; set; }
        //=======================giá trị ngoài===============================

        public string tenNSX;
        public string loaiSP;
        public int maNSX;
        public List<string> mauSP;
        public List<int> maMau;
        public List<int?> soluongton;
        public int slton1sp;
        public bool tinhTrangSanPham; // hết hàng hoặc còn hàng => số lượng tồn = 0
        public List<NHASANXUAT> listNSX;
        public List<LOAISANPHAM> listloaiSP;
        public string urlBack; // khi nhấn vào button trở lại ở productDetail thì sẽ trả lại link dựa vào biến urlBack
        public string searchingValue; // lưu giá trị mà người dùng nhập vào ô tìm kiếm sản phẩm (action: SearchProduct)
    }
}
