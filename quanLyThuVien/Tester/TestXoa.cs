using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAO;
using DTO;
using BUS;

namespace Tester
{
    [TestClass]
    public class TestXoa
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
            this.nv = new NhanVien("NV22", "Lương Văn Mai", "0904356578");
            this.dg = new DocGia("DG19", "Nguy?n Van A", "371 Nguy?n Ki?m", "0125487282", "");
            this.s = new Sach("SA12", "Hoa Hồng đen", "TG05", "TL02", 1965, "Mới");
            this.tl = new TheLoai("TL10", "Thơ ngụ ngôn");
            this.tg = new TacGia("TG09", "Nguyễn Ái Quốc", "");
            this.pm = new PhieuMuon("PM05", "2018-01-12", "DG02", "NV02");
            this.pt = new PhieuTra("PT02", "2018-06-30", "DG01", "NV01");
        }

        [TestMethod]
        public void XoaDocGia()
        {
            int dem = this.dgDAO.getDocGia().Count;
            if (this.dgDAO.DeleteDG(dg) == true)
            {
                dem -= 1;
            }

            Assert.AreEqual(dem, this.dgDAO.getDocGia().Count);
        }

        [TestMethod]
        public void XoaNhanVien()
        {
            int dem = this.nvDAO.getNV().Count;
            if (this.nvDAO.DeleteNV(nv) == true)
            {
                dem -= 1;
            }

            Assert.AreEqual(dem, this.nvDAO.getNV().Count);
        }

        [TestMethod]
        public void XoaSach()
        {
            int dem = this.sachDAO.getSach().Count;
            if (this.sachDAO.DeleteSach(s) == true)
            {
                dem -= 1;
            }

            Assert.AreEqual(dem, this.sachDAO.getSach().Count);
        }

        [TestMethod]
        public void XoaTheLoai()
        {
            int dem = this.tlDAO.getTL().Count;
            if (this.tlDAO.DeleteTL(tl) == true)
            {
                dem -= 1;
            }

            Assert.AreEqual(dem, this.tlDAO.getTL().Count);
        }

        [TestMethod]
        public void XoaTacGia()
        {
            int dem = this.tgDAO.getTacGia().Count;
            if (this.tgDAO.DeleteTG(tg) == true)
            {
                dem -= 1;
            }

            Assert.AreEqual(dem, this.tgDAO.getTacGia().Count);
        }

        [TestMethod]
        public void XoaPhieuMuon()
        {
            int dem = this.pmDAO.getPM().Count;
            if (this.pmDAO.DeletePM(pm) == true)
            {
                dem -= 1;
            }

            Assert.AreEqual(dem, this.pmDAO.getPM().Count);
        }

        [TestMethod]
        public void XoaPhieuTra()
        {
            int dem = this.ptDAO.getPT().Count;
            if (this.ptDAO.DeletePT(pt) == true)
            {
                dem -= 1;
            }

            Assert.AreEqual(dem, this.ptDAO.getPT().Count);
        }
    }
}
