using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAO;
using DTO;

namespace Tester
{
    [TestClass]
    public class UnitTest1
    {
        private NhanVienDAO nvDAO = new NhanVienDAO();
        private NhanVien nv;
        private DocGiaDAO dgDAO = new DocGiaDAO();
        private DocGia dg;
        //private SachDAO sachDAO = new SachDAO();
        //private Sach s;
        private TheLoaiDAO tlDAO = new TheLoaiDAO();
        private TheLoai tl;
        [TestInitialize]
        public void Setup()
        {
            this.nv = new NhanVien("NV09", "Huỳnh Thị Lan", "0904356578");
            this.dg = new DocGia("DG13", "Nguyễn Văn A", "371 Nguyễn Kiệm", "0125487282", "");
            //this.s = new Sach("SA09", "Conan", "1987", "10000", "Ngô Lan", "Truyện");
            this.tl = new TheLoai("TL12", "Mẹ và bé");
        }
        [TestMethod]
        public void ThemDocGia()
        {
           int dem = this.dgDAO.getDocGia().Count;
            if(this.dgDAO.Add(dg)==1)
            {
                dem += 1;
            }
            
            Assert.AreEqual(dem,this.dgDAO.getDocGia().Count);
            //Assert.AreEqual();
        }

        public void ThemNhanVien()
        {
            int dem = this.nvDAO.getNV().Count;
            if(this.nvDAO.Add(nv) == 1)
            {
                dem += 1;
            }

            Assert.AreEqual(dem, this.nvDAO.getNV().Count);
        }

        //public void ThemSach()
        //{
        //    int dem = this.sachDAO.getSach().Count;
        //    if (this.sachDAO.Add(s) == 1)
        //    {
        //        dem += 1;
        //    }

        //    Assert.AreEqual(dem, this.sachDAO.getSach().Count);
        //}

        public void ThemTheLoai()
        {
            int dem = this.tlDAO.getTL().Count;
            if (this.tlDAO.Add(tl) == 1)
            {
                dem += 1;
            }

            Assert.AreEqual(dem, this.tlDAO.getTL().Count);
        }
        //[TestMethod]
        //public void XoaDocGia()
        //{
        //    int dem = this.dgDAO.getDocGia().Count;
        //    if(this.dgDAO.DeleteDG(dg)==1)
        //    {
        //        dem -= 1;
        //    }
        //    Assert.AreEqual(dem, this.dgDAO.getDocGia().Count);
        //}
    }
}
