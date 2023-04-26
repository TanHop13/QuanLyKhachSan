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

namespace QuanLyKhachSan
{
    public partial class LeTan : Form
    {
        public LeTan()
        {
            InitializeComponent();

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

        void showBill(int id)
        {
            lsvBill.Items.Clear();
            List<BillInfo> listBillInfo = BillInfoDAO.Instance.GetListBillInfo(BillDAO.Instance.GetBillIDByRoomID(id));

            foreach (BillInfo item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.IdDV.ToString());
                lsvItem.SubItems.Add(item.ChiPhi.ToString());

                lsvBill.Items.Add(lsvItem);
            }
        }


        #endregion


        #region Events

        void btn_Click(object sender, EventArgs e)
        {
            int roomID = ((sender as Button).Tag as Room).MaP;
            showBill(roomID);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #endregion

        
    }
}
