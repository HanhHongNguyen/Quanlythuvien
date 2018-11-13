using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAO;
using DTO;
namespace Tester
{
    [TestClass]
    public class UnitTest1
    {
        private DocGiaDAO docgiaDAO = new DocGiaDAO();
        private DocGia dg;
        [TestInitialize]
        public void Setup()
        {
            dg = new DocGia("DG11", "Nguyễn Văn A", "371 Nguyễn Kiệm", "0911223344", "nguyenvana@gmail.com");
        }
        [TestMethod]
        public void TestAddDG()
        {
            int dem = this.docgiaDAO.getDocGia().Count;
            
            if (this.docgiaDAO.Add(dg) == 1)
            {
                dem += 1;
            }
            Assert.AreEqual(9,this.docgiaDAO.getDocGia().Count);
            
        }
    }
}
