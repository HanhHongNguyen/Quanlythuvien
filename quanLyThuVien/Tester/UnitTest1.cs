using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAO;
using BUS;
using DTO;

namespace Tester2
{
    [TestClass]
    public class UnitTest1
    {
        private NhanVienDAO nvDAO = new NhanVienDAO();
        private NhanVien nv;
        private DocGiaDAO dgDAO = new DocGiaDAO();
        private DocGia dg;
        private SachDAO sachDAO = new SachDAO();
        private Sach s;
        private TheLoaiDAO tlDAO = new TheLoaiDAO();
        private TheLoai tl;

        [TestInitialize]
        public void Setup()
        {
            this.nv = new NhanVien("NV20", "Hu?nh Th? Lan", "0904356578");
            this.dg = new DocGia("DG19", "Nguy?n Van A", "371 Nguy?n Ki?m", "0125487282", "");
            this.s = new Sach("SA11", "Hoa h?ng den", "TG04", "TL03", 1965, "M?i");
            this.tl = new TheLoai("TL17", "M? và bé");
        }

        [TestMethod]
        public void ThemDocGia()
        {
            int dem = this.dgDAO.getDocGia().Count;
            if (this.dgDAO.Add(dg) == 1)
            {
                dem += 1;
            }

            Assert.AreEqual(dem, this.dgDAO.getDocGia().Count);

        }

        [TestMethod]
        public void ThemNhanVien()
        {
            int dem = this.nvDAO.getNV().Count;
            if (this.nvDAO.Add(nv) == 1)
            {
                dem += 1;
            }

            Assert.AreEqual(dem, this.nvDAO.getNV().Count);
        }

        [TestMethod]
        public void ThemSach()
        {
            int dem = this.sachDAO.getSach().Count;
            if (this.sachDAO.Add(s) == 1)
            {
                dem += 1;
            }

            Assert.AreEqual(dem, this.sachDAO.getSach().Count);
        }

        [TestMethod]
        public void ThemTheLoai()
        {
            int dem = this.tlDAO.getTL().Count;
            if (this.tlDAO.Add(tl) == 1)
            {
                dem += 1;
            }

            Assert.AreEqual(dem, this.tlDAO.getTL().Count);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
