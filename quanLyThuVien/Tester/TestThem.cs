using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAO;
using BUS;
using DTO;


namespace Tester
{
    [TestClass]
    public class TestThem
    {
        private NhanVienDAO nvDAO = new NhanVienDAO();
        private NhanVien nv;
        private DocGiaDAO dgDAO = new DocGiaDAO();
        private DocGia dg;
        private SachDAO sachDAO = new SachDAO();
        private Sach s;
        private TheLoaiDAO tlDAO = new TheLoaiDAO();
        private TheLoai tl;
        private TacGiaDAO tgDAO = new TacGiaDAO();
        private TacGia tg;
        private PhieuMuonDAO pmDAO = new PhieuMuonDAO();
        private PhieuMuon pm;
        private PhieuTraDAO ptDAO = new PhieuTraDAO();
        private PhieuTra pt;

        [TestInitialize]
        public void Setup()
        {
            this.nv = new NhanVien("NV23", "Lương Xuân Tiến", "0904356578");
            this.dg = new DocGia("DG21", "Nguyễn Anh Đào", "371 Đào Duy Từ", "0125487282", "");
            this.s = new Sach("SA13", "Cánh Hồng phai", "TG05", "TL02", 1965, "Mới");
            this.tl = new TheLoai("", "Thơ bát cú");
            this.tg = new TacGia("TG10", "Nguyễn Ái Quốc", "");
            this.pm = new PhieuMuon("PM06", "2018-01-12", "DG01", "NV03");
            this.pt = new PhieuTra("PT03", "2018-06-30", "DG03", "NV02");
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
            //Assert.AreEqual(dem,);
        }

        [TestMethod]
        public void ThemTacGia()
        {
            int dem = this.tgDAO.getTacGia().Count;
            if (this.tgDAO.AddTG(tg) == 1)
            {
                dem += 1;
            }

            Assert.AreEqual(dem, this.tgDAO.getTacGia().Count);
        }

        [TestMethod]
        public void ThemPhieuMuon()
        {
            int dem = this.pmDAO.getPM().Count;
            if (this.pmDAO.Add(pm) == 1)
            {
                dem += 1;
            }

            Assert.AreEqual(dem, this.pmDAO.getPM().Count);
        }

        [TestMethod]
        public void ThemPhieuTra()
        {
            int dem = this.ptDAO.getPT().Count;
            if (this.ptDAO.Add(pt) == 1)
            {
                dem += 1;
            }

            Assert.AreEqual(dem, this.ptDAO.getPT().Count);
        }


    }
}
