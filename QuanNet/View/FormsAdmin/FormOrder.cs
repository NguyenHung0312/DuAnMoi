﻿using QuanNet.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanNet.LinQ;

namespace QuanNet
{
    public partial class FormOrder : Form
    {
   
        public string ID_CT { get; set; }
        public FormOrder()
        {           
            InitializeComponent();
            ShowOrder("");
        }
        public void ShowOrder(string key)
        {
            dgvOrder.DataSource = BllHoaDon.Instance.GetOrderAdmin("",dtpHDCT.Value.Date,key);
        }
        // Hàm Show(CT) dùng để show các listOrder theo keywork search
        public void ShowList (string CT)
        {
            dgvOrder.DataSource= BllOrderKH.Instance.GetListTPViewByIDCT(CT);
        }
        // Hàm ShowOrder() các món đã liệt kê 
        private void btnXN_Click(object sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count > 0)
            {

                ID_CT = dgvOrder.SelectedRows[0].Cells["IdChiTiet"].Value.ToString();
                    if (!BllHoaDon.Instance.checkVal(ID_CT))
                    {
                        MessageBox.Show("Đã order");
                        //Nếu đã order thì hiện thông báo
                    }
                    else
                    {
                        HoaDon s = new HoaDon()
                        {
                            IdHoaDon = BllHoaDon.Instance.MaHoaDon(),
                            IdTK = ID_CT.Substring(0, 5),
                            IdChiTiet = ID_CT
                        };
                        BllHoaDon.Instance.AddHD(s);
                    }
                    ShowOrder("");
                
            }
            else MessageBox.Show("Vui lòng chọn order cần thanh toán từ menu chính", "Thông báo", MessageBoxButtons.OK);
        }
        // Ấn xác nhận đơn đặt order của khách hàng
        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrder.SelectedRows.Count == 1)
            {
                string id = dgvOrder.SelectedRows[0].Cells["IdChiTiet"].Value.ToString();
                ShowList(id);
            }
            else ShowOrder("");
        }
        // Xem chi tiết mỗi order khách hàng gồm những gì( khi ấn dou-click)
        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowOrder("");
            dgvOrder.ClearSelection();
            dgvOrder.Enabled = true;
        }

        private void dtpHDCT_ValueChanged(object sender, EventArgs e)
        {
            ShowOrder("");
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            ShowOrder(txtSearch.Text);

        }

        // Trở về menu chính
    }
}
