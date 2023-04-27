using QuanLyKhachSan.DAO;
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
    public partial class LTfHoaDon : Form
    {
        public LTfHoaDon()
        {
            InitializeComponent();
        }

        #region methods

        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dGVBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }

        #endregion


        #region events
        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        #endregion


    }
}
