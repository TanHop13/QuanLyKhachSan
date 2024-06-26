﻿using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }

        public List<Menu> GetListMenuByRoom(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "select dv.MaDV, dv.TenDV, dv.GiaDV from ChiTietHoaDon ct, HoaDon hd, DichVu dv, Phong p where ct.IDHoaDon = hd.MaHD and ct.IdDichVu = dv.MaDV and hd.Phong = p.MaP and hd.TrangThai = 0 and hd.Phong = +" + id;
            //string query = "select dv.MaDV, dv.TenDV, dv.GiaDV from ChiTietHoaDon ct, HoaDon hd, DichVu dv, Phong p where ct.IDHoaDon = hd.MaHD and ct.IdDichVu = dv.MaDV and hd.Phong = p.MaP and p.TinhTrang = 0 and hd.Phong = +" + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }

        public List<Menu> GetListDichVu()
        {
            List<Menu> listDV = new List<Menu>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from DichVu");

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listDV.Add(menu);
            }

            return listDV;
        }
    }
}
