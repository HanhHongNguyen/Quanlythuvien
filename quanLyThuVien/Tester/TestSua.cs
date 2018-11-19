using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAO;
using DTO;
using BUS;

namespace Tester
{
    [TestClass]
    public class TestSua
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
        public void TestMethod1()
        {
        }
    }
}
