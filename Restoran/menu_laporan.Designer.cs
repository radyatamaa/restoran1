﻿namespace Restoran
{
    partial class menu_laporan
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTableLaporanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Billing = new Restoran.DataSet_Billing();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cetak = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_biling = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_laporan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_pembayaran = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableLaporanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Billing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTableLaporanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Restoran.Report_Laporan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(234, 172);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(592, 348);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataTableLaporanBindingSource
            // 
            this.DataTableLaporanBindingSource.DataMember = "DataTableLaporan";
            this.DataTableLaporanBindingSource.DataSource = this.DataSet_Billing;
            // 
            // DataSet_Billing
            // 
            this.DataSet_Billing.DataSetName = "DataSet_Billing";
            this.DataSet_Billing.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(412, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(277, 27);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tanggal Order";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_cetak
            // 
            this.btn_cetak.Location = new System.Drawing.Point(412, 137);
            this.btn_cetak.Name = "btn_cetak";
            this.btn_cetak.Size = new System.Drawing.Size(75, 29);
            this.btn_cetak.TabIndex = 3;
            this.btn_cetak.Text = "Cetak";
            this.btn_cetak.UseVisualStyleBackColor = true;
            this.btn_cetak.Click += new System.EventHandler(this.btn_cetak_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restoran.Properties.Resources.sushi1dalam;
            this.pictureBox1.Location = new System.Drawing.Point(38, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.btn_biling);
            this.panel2.Controls.Add(this.btn_logout);
            this.panel2.Controls.Add(this.btn_laporan);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btn_pembayaran);
            this.panel2.Controls.Add(this.btn_menu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(6, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 529);
            this.panel2.TabIndex = 5;
            // 
            // btn_biling
            // 
            this.btn_biling.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_biling.FlatAppearance.BorderSize = 0;
            this.btn_biling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_biling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_biling.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_biling.ForeColor = System.Drawing.Color.White;
            this.btn_biling.Image = global::Restoran.Properties.Resources.pay;
            this.btn_biling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_biling.Location = new System.Drawing.Point(-2, 277);
            this.btn_biling.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_biling.Name = "btn_biling";
            this.btn_biling.Size = new System.Drawing.Size(228, 64);
            this.btn_biling.TabIndex = 7;
            this.btn_biling.Text = "Cetak Billing";
            this.btn_biling.UseVisualStyleBackColor = true;
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Image = global::Restoran.Properties.Resources.analytics;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(-2, 420);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_logout.Size = new System.Drawing.Size(228, 64);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            // 
            // btn_laporan
            // 
            this.btn_laporan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_laporan.FlatAppearance.BorderSize = 0;
            this.btn_laporan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_laporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_laporan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_laporan.ForeColor = System.Drawing.Color.White;
            this.btn_laporan.Image = global::Restoran.Properties.Resources.analytics;
            this.btn_laporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_laporan.Location = new System.Drawing.Point(0, 346);
            this.btn_laporan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_laporan.Name = "btn_laporan";
            this.btn_laporan.Size = new System.Drawing.Size(228, 64);
            this.btn_laporan.TabIndex = 5;
            this.btn_laporan.Text = "Laporan Penjualan\r\nHarian";
            this.btn_laporan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Restoran Sushi Sherilyn";
            // 
            // btn_pembayaran
            // 
            this.btn_pembayaran.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pembayaran.FlatAppearance.BorderSize = 0;
            this.btn_pembayaran.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_pembayaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pembayaran.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pembayaran.ForeColor = System.Drawing.Color.White;
            this.btn_pembayaran.Image = global::Restoran.Properties.Resources.pay;
            this.btn_pembayaran.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pembayaran.Location = new System.Drawing.Point(0, 213);
            this.btn_pembayaran.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_pembayaran.Name = "btn_pembayaran";
            this.btn_pembayaran.Size = new System.Drawing.Size(228, 64);
            this.btn_pembayaran.TabIndex = 4;
            this.btn_pembayaran.Text = "Pembayaran";
            this.btn_pembayaran.UseVisualStyleBackColor = true;
            // 
            // btn_menu
            // 
            this.btn_menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.Image = global::Restoran.Properties.Resources.food_serving;
            this.btn_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu.Location = new System.Drawing.Point(0, 140);
            this.btn_menu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(228, 64);
            this.btn_menu.TabIndex = 3;
            this.btn_menu.Text = "Kelola Data Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 529);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(238, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Restoran Sushi Sherilyn";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(234, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(597, 31);
            this.panel3.TabIndex = 6;
            // 
            // menu_laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 529);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cetak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "menu_laporan";
            this.Text = "menu_laporan";
            this.Load += new System.EventHandler(this.menu_laporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableLaporanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Billing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTableLaporanBindingSource;
        private DataSet_Billing DataSet_Billing;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cetak;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_biling;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_laporan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_pembayaran;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
    }
}