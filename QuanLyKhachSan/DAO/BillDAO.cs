using QuanLyKhachSan.DTO;
using System.Data;
using System;
using System.Data.SqlClient;

namespace QuanLyKhachSan.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }

        public int GetBillIDByRoomID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select HoaDon.MaHD from dbo.HoaDon, dbo.Phong where HoaDon.Phong = Phong.MaP and Phong.MaP = " + id +" and HoaDon.TrangThai = 0");
            //DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.HoaDon where Phong = " + id);

            if (data != null && data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0]["MaHD"]);
            }

            return -1;
        }

        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteQuery("exec LTP_InsertBill @idTable", new object[] {id});
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(MaHD) from dbo.HoaDon");
            }
            catch
            {
                return 1;
            }
        }

        public void CheckOut (int id)
        {
            string query = "UPDATE dbo.Phong SET TinhTrang = 0 WHERE MaP IN(SELECT Phong.MaP FROM dbo.Phong, dbo.HoaDon WHERE Phong.MaP = HoaDon.Phong AND MaHD = " + id + ") " ;
            DataProvider.Instance.ExecuteNonQuery(query);
            string query2 = "UPDATE dbo.HoaDon SET TrangThai = 1 WHERE MaHD = " + id;
            DataProvider.Instance.ExecuteNonQuery(query2);
        }

        public decimal LoadPrice(int id)
        {
            string query = "exec dbo.GetTotalByMaHD @MaHD = "+ id +" select Total from HoaDon where MaHD = " + id;      
            return (decimal)DataProvider.Instance.ExecuteScalar(query);
        }

        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec LTS_GetBillByDate @checkIn , @checkout", new object[] {checkIn,checkOut});
        }


    }
}
