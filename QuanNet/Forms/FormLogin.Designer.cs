﻿namespace QuanNet
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLoginKhach = new FontAwesome.Sharp.IconButton();
            this.btnLoginQL = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.cusBtn1 = new QuanNet.CustomsDetail.CusBtn();
            this.txtMKQL = new QuanNet.CustomsDetail.CustomTextbox();
            this.txtTKQL = new QuanNet.CustomsDetail.CustomTextbox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnLoginKhach);
            this.panelMenu.Controls.Add(this.btnLoginQL);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(258, 543);
            this.panelMenu.TabIndex = 0;
            // 
            // btnLoginKhach
            // 
            this.btnLoginKhach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoginKhach.FlatAppearance.BorderSize = 0;
            this.btnLoginKhach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginKhach.ForeColor = System.Drawing.Color.Transparent;
            this.btnLoginKhach.IconChar = FontAwesome.Sharp.IconChar.Tv;
            this.btnLoginKhach.IconColor = System.Drawing.Color.White;
            this.btnLoginKhach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoginKhach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoginKhach.Location = new System.Drawing.Point(0, 320);
            this.btnLoginKhach.Name = "btnLoginKhach";
            this.btnLoginKhach.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLoginKhach.Size = new System.Drawing.Size(258, 110);
            this.btnLoginKhach.TabIndex = 2;
            this.btnLoginKhach.Text = "Khách Hàng";
            this.btnLoginKhach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoginKhach.UseVisualStyleBackColor = true;
            this.btnLoginKhach.Click += new System.EventHandler(this.btnLoginKhach_Click);
            // 
            // btnLoginQL
            // 
            this.btnLoginQL.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoginQL.FlatAppearance.BorderSize = 0;
            this.btnLoginQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginQL.ForeColor = System.Drawing.Color.Transparent;
            this.btnLoginQL.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnLoginQL.IconColor = System.Drawing.Color.White;
            this.btnLoginQL.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoginQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoginQL.Location = new System.Drawing.Point(0, 210);
            this.btnLoginQL.Name = "btnLoginQL";
            this.btnLoginQL.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLoginQL.Size = new System.Drawing.Size(258, 110);
            this.btnLoginQL.TabIndex = 1;
            this.btnLoginQL.Text = "Quản Lý";
            this.btnLoginQL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoginQL.UseVisualStyleBackColor = true;
            this.btnLoginQL.Click += new System.EventHandler(this.btnLoginQL_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(258, 210);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::QuanNet.Properties.Resources.Hoc_Them_removebg_preview__1__removebg_preview;
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(212, 185);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(258, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(620, 75);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.lblTitle.Location = new System.Drawing.Point(67, 23);
            this.lblTitle.MinimumSize = new System.Drawing.Size(200, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "LOGIN";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(30, 27);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(258, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(620, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.cusBtn1);
            this.panelDesktop.Controls.Add(this.txtMKQL);
            this.panelDesktop.Controls.Add(this.txtTKQL);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(258, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(620, 459);
            this.panelDesktop.TabIndex = 3;
            // 
            // cusBtn1
            // 
            this.cusBtn1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cusBtn1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cusBtn1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cusBtn1.BorderRadius = 20;
            this.cusBtn1.BorderSize = 0;
            this.cusBtn1.FlatAppearance.BorderSize = 0;
            this.cusBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cusBtn1.ForeColor = System.Drawing.Color.White;
            this.cusBtn1.Location = new System.Drawing.Point(226, 260);
            this.cusBtn1.Name = "cusBtn1";
            this.cusBtn1.Size = new System.Drawing.Size(171, 62);
            this.cusBtn1.TabIndex = 2;
            this.cusBtn1.Text = "Đăng nhập";
            this.cusBtn1.TextColor = System.Drawing.Color.White;
            this.cusBtn1.UseVisualStyleBackColor = false;
            this.cusBtn1.Click += new System.EventHandler(this.cusBtn1_Click);
            this.cusBtn1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cusBtn1_KeyPress);
            // 
            // txtMKQL
            // 
            this.txtMKQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtMKQL.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMKQL.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMKQL.BorderRadius = 0;
            this.txtMKQL.BorderSize = 2;
            this.txtMKQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKQL.ForeColor = System.Drawing.Color.White;
            this.txtMKQL.Location = new System.Drawing.Point(197, 167);
            this.txtMKQL.Margin = new System.Windows.Forms.Padding(4);
            this.txtMKQL.Multiline = false;
            this.txtMKQL.Name = "txtMKQL";
            this.txtMKQL.Padding = new System.Windows.Forms.Padding(7);
            this.txtMKQL.PasswordChar = true;
            this.txtMKQL.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtMKQL.PlaceholderText = "Mật khẩu...";
            this.txtMKQL.Size = new System.Drawing.Size(250, 35);
            this.txtMKQL.TabIndex = 1;
            this.txtMKQL.Texts = "";
            this.txtMKQL.UnderlinedStyle = true;
            this.txtMKQL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cusBtn1_KeyPress);
            // 
            // txtTKQL
            // 
            this.txtTKQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtTKQL.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTKQL.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTKQL.BorderRadius = 0;
            this.txtTKQL.BorderSize = 2;
            this.txtTKQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTKQL.ForeColor = System.Drawing.Color.White;
            this.txtTKQL.Location = new System.Drawing.Point(197, 103);
            this.txtTKQL.Margin = new System.Windows.Forms.Padding(4);
            this.txtTKQL.Multiline = false;
            this.txtTKQL.Name = "txtTKQL";
            this.txtTKQL.Padding = new System.Windows.Forms.Padding(7);
            this.txtTKQL.PasswordChar = false;
            this.txtTKQL.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtTKQL.PlaceholderText = "ID...";
            this.txtTKQL.Size = new System.Drawing.Size(250, 35);
            this.txtTKQL.TabIndex = 0;
            this.txtTKQL.Texts = "";
            this.txtTKQL.UnderlinedStyle = true;
            this.txtTKQL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cusBtn1_KeyPress);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 543);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MaximumSize = new System.Drawing.Size(1410, 800);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cusBtn1_KeyPress);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private FontAwesome.Sharp.IconButton btnLoginKhach;
        private FontAwesome.Sharp.IconButton btnLoginQL;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private CustomsDetail.CustomTextbox txtTKQL;
        private CustomsDetail.CusBtn cusBtn1;
        private CustomsDetail.CustomTextbox txtMKQL;
    }
}

