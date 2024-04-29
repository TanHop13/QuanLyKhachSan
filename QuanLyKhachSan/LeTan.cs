using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = QuanLyKhachSan.DTO.Menu;

namespace QuanLyKhachSan
{
    public partial class LeTan : Form
    {
        public LeTan()
        {
            InitializeComponent();

            LoadDichVu();
            LoadRoom();
        }

        #region Method
        void LoadRoom()
        {
            List<Room> roomList = RoomDAO.Instance.LoadRoomList();

            foreach (Room item in roomList)
            {
                Button btn = new Button(){ Width = RoomDAO.RoomWidth, Height = RoomDAO.RoomHeight};
                btn.Text = item.TenP + Environment.NewLine;
                btn.Click += btn_Click;
                btn.Tag = item;
                
                if (item.TinhTrang)
                {
                    btn.Text = btn.Text + "Đã có khách";
                    btn.BackColor = Color.LightCoral;
                }
                else
                {
                    btn.Text = btn.Text + "Trống";
                    btn.BackColor = Color.LightGreen;
                }

               
                flpRoom.Controls.Add(btn);
            }
        }

        void clearRoom()
        {
            flpRoom.Controls.Clear();
        }

        void showBill(int id)
        {
            lsvBill.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByRoom(id);

            //decimal totalPrice = 0;
            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.IdDV.ToString());
                lsvItem.SubItems.Add(item.TenDV.ToString());
                lsvItem.SubItems.Add(item.GiaDV.ToString());

                LoadTotalPrice();

                lsvBill.Items.Add(lsvItem);
            }
        }

        void LoadDichVu()
        {
            List<Menu> listDichVu = MenuDAO.Instance.GetListDichVu();
            cbDichVu.DataSource = listDichVu;
            cbDichVu.DisplayMember = "TenDV";
        }

        public void LoadTotalPrice()
        {
            Room room = lsvBill.Tag as Room;
            int idBill = BillDAO.Instance.GetBillIDByRoomID(room.MaP);

            if (idBill != -1)
            {
                txbTotalPrice.Text = (BillDAO.Instance.LoadPrice(idBill)).ToString();
            }
            else
            {
                txbTotalPrice.Text = "0";
            }
        }


        #endregion


        #region Events

        void btn_Click(object sender, EventArgs e)
        {
            int roomID = ((sender as Button).Tag as Room).MaP;
            lsvBill.Tag = (sender as Button).Tag;
            showBill(roomID);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int i = 0;

            ComboBox cb = new ComboBox();

            if (cb.SelectedItem == null)
                return;

            QuanLyKhachSan.DTO.Menu selected = cb.SelectedItem as QuanLyKhachSan.DTO.Menu;
        }

        private void btnAddDV_Click(object sender, EventArgs e)
        {
            Room room = lsvBill.Tag as Room;

            int idBill = BillDAO.Instance.GetBillIDByRoomID(room.MaP);
            int idDV = (cbDichVu.SelectedItem as Menu).IdDV;
            decimal ChiPhi = (cbDichVu.SelectedItem as Menu).GiaDV;


            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(room.MaP);
                BillInfoDAO.Instance.InsertBillInfo(room.MaP, BillDAO.Instance.GetMaxIDBill(), idDV, ChiPhi);

            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(room.MaP, idBill, idDV, ChiPhi);
            }
            showBill(room.MaP);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Room room = lsvBill.Tag as Room;

            int idBill = BillDAO.Instance.GetBillIDByRoomID(room.MaP);

            if (idBill != -1)
            {
                if (MessageBox.Show("Xác nhận thanh toán hóa đơn?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill);
                    showBill(room.MaP);
                }
            }
            clearRoom();
            LoadRoom();
        }

        private void ttMenuTTKH_Click(object sender, EventArgs e)
        {
            LTfThongTinKH f = new LTfThongTinKH();
            f.ShowDialog();
        }

        private void ttMenuHD_Click(object sender, EventArgs e)
        {
            LTfHoaDon f = new LTfHoaDon();
            f.ShowDialog();
        }

        private void LeTan_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        #endregion

        private void btnDP_Click(object sender, EventArgs e)
        {
            Room room = lsvBill.Tag as Room;

            //int idBill = BillDAO.Instance.GetBillIDByRoomID(room.MaP);

            //if (idBill != -1)
            //{
            //    if (MessageBox.Show("Xác nhận thanh toán hóa đơn?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            //    {
            //        BillDAO.Instance.CheckOut(idBill);
            //        showBill(room.MaP);
            //    }
            //}
            clearRoom();
            LoadRoom();
        }
    }
}
