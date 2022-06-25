﻿using FontAwesome.Sharp;
using QuanNet.BLL;
using QuanNet.LinQ;
using QuanNet.Properties;
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
    public partial class FormLogin : Form
    {
        //----
        public string time { get; set; }
      
        private string PasswordAdmin = "123";
        private string IDAdmin = "admin";
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form thisChildForm;
        public FormLogin()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 166);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = true;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //====  
            cbbMay.Items.AddRange(BllMayTinh.Instance.GetCBB().ToArray());
        }
        public void ShowDB(bool a)
        {
            if (a)
            {
                panelQL.Visible = true;
                panelKHmain.Visible = false;
            }
            else
            {
                panelQL.Visible=false;
                panelKHmain.Visible = true;
            }
        }
        //-----------------Code UI Form---------------------------------------------------
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(34, 33, 74);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconForm.IconChar = currentBtn.IconChar;
                iconForm.IconColor = color;
                lblTitle.ForeColor = iconForm.IconColor;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            if (thisChildForm != null)
            {
                thisChildForm.Close();
            }
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconForm.IconChar = IconChar.Home;
            iconForm.IconColor = Color.MediumPurple;
            lblTitle.Text = "Home";
        }

        //---------End Code UI------------------------------------------------------------
        private void btnLoginQL_Click(object sender, EventArgs e)
        {   
            ActivateButton(sender, RGBColors.color1);
            ShowDB(true);
            
        }

        private void btnLoginKhach_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            ShowDB(false);

        }
        public void MoMayAdmin()
        {
            try
            {
                if (txtTKQL.Text == IDAdmin && txtMKQL.Text == PasswordAdmin)
                {
                    Form1 f = new Form1();
                    f.Show();

                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK);
            }
            txtMKQL.Text = "";
            txtTKQL.Text = "";

        }
        public void MoMayKhachHang()
        {
            string tk = BllKhachHang.Instance.GetIDTKByUSERNAME(txtTKKH.Text.ToString());
            foreach (TaiKhoan i in BllKhachHang.Instance.GetListTKByIDTK(tk))
            {
                if (txtTKKH.Text.ToString() == i.TenDN && txtMKKH.Text.ToString() == i.MatKhau)
                {

                        if (cbbMay.SelectedIndex != -1)
                        {
                            if ((int)i.Sodu >= 2000)
                            {
                                bool tt = BllMayTinh.Instance.GetMayByIDMay(cbbMay.SelectedItem.ToString()).TrangThai;
                                if (tt == false)
                                {
                                    string may = cbbMay.SelectedItem.ToString();
                                    BllMayTinh.Instance.addTKinMay(may, tk, "");
                                    FormsUser.FormUsers f = new FormsUser.FormUsers(may, tk);
                                    f.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Máy bận! Xin vui lòng chọn máy khác. ", "Thông báo", MessageBoxButtons.OK);

                                }
                            }else MessageBox.Show("Số dư không đủ", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn máy ", "Thông báo", MessageBoxButtons.OK);
                        }
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK);
                }

            }

            txtTKKH.Text = "";
            txtMKKH.Text = "";
            cbbMay.SelectedIndex = -1;
        }
        private void cusBtn1_Click(object sender, EventArgs e)
        {
            MoMayAdmin();
        }

        private void cusBtn1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter)
            {
                MoMayAdmin();
                e.Handled = true;              
            }
        }

        private void cusBtnKH_Click(object sender, EventArgs e)
        {
            MoMayKhachHang();
        }

        private void BtnKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MoMayKhachHang();
                e.Handled = true;
            }
        }
    }
}
