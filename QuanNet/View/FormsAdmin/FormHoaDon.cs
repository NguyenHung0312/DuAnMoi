﻿using QuanNet.BLL;
using QuanNet.LinQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanNet
{
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
            ShowListHD("");
            TongHoaDon();
            sort.Items.AddRange(new object[] {"All","Tên khách hàng","Ngày xuất","Tổng tiền" });
            sort.SelectedIndex = 0;
        }
        public void TongHoaDon()
        {   
            int dem=0;
            foreach (DataGridViewRow i in dgvHoaDon.Rows)
            {
                dem += 1; 
            }
            label3.Text =dem.ToString();
        }
        public void ShowListHD(string i,string Key="")
        {
            dgvHoaDon.DataSource = BllHoaDon.Instance.GetView(i,Key);
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            ShowListHD("", txtSearch.Text);
            TongHoaDon();
        }

        private void dateStart_ValueChanged(object sender, EventArgs e)
        {
            DateTime start=dateStart.Value.Date;
            DateTime end = dateEnd.Value.Date;
            if (end>= start)
            {

                dgvHoaDon.DataSource = BllHoaDon.Instance.SearchByDay(start, end);
            }else
            {
                dateEnd.Value = DateTime.Now.Date;
                dgvHoaDon.DataSource = BllHoaDon.Instance.SearchByDay(start, end);
            }

        }

        private void sort_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = BllHoaDon.Instance.Sort(sort.SelectedIndex);
        }
    }
}
