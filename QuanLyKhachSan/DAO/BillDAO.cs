﻿using QuanLyKhachSan.DTO;
using System.Data;
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
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.HoaDon where Phong = " + id);

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
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
            string query = "update dbo.Phong set TinhTrang = 0 where MaP = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

    }
}