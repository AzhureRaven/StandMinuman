﻿
namespace StandMinuman
{
	partial class FormReport
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sellerpenjualanTertinggiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellerpenjualanTerendahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minumanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokMinumanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toppingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kembaliKeMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tampilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dateTimePickerAwal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerAkhir = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellerpenjualanTertinggiToolStripMenuItem,
            this.sellerpenjualanTerendahToolStripMenuItem,
            this.minumanToolStripMenuItem,
            this.stokMinumanToolStripMenuItem,
            this.toppingToolStripMenuItem,
            this.kembaliKeMenuToolStripMenuItem,
            this.toolStripMenuItem1,
            this.tampilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sellerpenjualanTertinggiToolStripMenuItem
            // 
            this.sellerpenjualanTertinggiToolStripMenuItem.Name = "sellerpenjualanTertinggiToolStripMenuItem";
            this.sellerpenjualanTertinggiToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.sellerpenjualanTertinggiToolStripMenuItem.Text = "Seller (penjualan tertinggi)";
            // 
            // sellerpenjualanTerendahToolStripMenuItem
            // 
            this.sellerpenjualanTerendahToolStripMenuItem.Name = "sellerpenjualanTerendahToolStripMenuItem";
            this.sellerpenjualanTerendahToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.sellerpenjualanTerendahToolStripMenuItem.Text = "Seller (penjualan terendah)";
            // 
            // minumanToolStripMenuItem
            // 
            this.minumanToolStripMenuItem.Name = "minumanToolStripMenuItem";
            this.minumanToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.minumanToolStripMenuItem.Text = "Penjualan Minuman";
            // 
            // stokMinumanToolStripMenuItem
            // 
            this.stokMinumanToolStripMenuItem.Name = "stokMinumanToolStripMenuItem";
            this.stokMinumanToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.stokMinumanToolStripMenuItem.Text = "Stok Minuman";
            // 
            // toppingToolStripMenuItem
            // 
            this.toppingToolStripMenuItem.Name = "toppingToolStripMenuItem";
            this.toppingToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.toppingToolStripMenuItem.Text = "Topping";
            this.toppingToolStripMenuItem.Click += new System.EventHandler(this.toppingToolStripMenuItem_Click);
            // 
            // kembaliKeMenuToolStripMenuItem
            // 
            this.kembaliKeMenuToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.kembaliKeMenuToolStripMenuItem.Name = "kembaliKeMenuToolStripMenuItem";
            this.kembaliKeMenuToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.kembaliKeMenuToolStripMenuItem.Text = "Kembali ke Menu";
            this.kembaliKeMenuToolStripMenuItem.Click += new System.EventHandler(this.kembaliKeMenuToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 22);
            this.toolStripMenuItem1.Text = "|";
            // 
            // tampilToolStripMenuItem
            // 
            this.tampilToolStripMenuItem.Enabled = false;
            this.tampilToolStripMenuItem.Name = "tampilToolStripMenuItem";
            this.tampilToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.tampilToolStripMenuItem.Text = "Tampil";
            this.tampilToolStripMenuItem.Click += new System.EventHandler(this.tampilToolStripMenuItem_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 59);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(856, 396);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // dateTimePickerAwal
            // 
            this.dateTimePickerAwal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerAwal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAwal.Location = new System.Drawing.Point(113, 30);
            this.dateTimePickerAwal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerAwal.Name = "dateTimePickerAwal";
            this.dateTimePickerAwal.Size = new System.Drawing.Size(135, 23);
            this.dateTimePickerAwal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tanggal Awal :";
            // 
            // dateTimePickerAkhir
            // 
            this.dateTimePickerAkhir.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerAkhir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAkhir.Location = new System.Drawing.Point(360, 30);
            this.dateTimePickerAkhir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerAkhir.Name = "dateTimePickerAkhir";
            this.dateTimePickerAkhir.Size = new System.Drawing.Size(135, 23);
            this.dateTimePickerAkhir.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(252, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tanggal Akhir :";
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(856, 456);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerAkhir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerAwal);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReport";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem sellerpenjualanTertinggiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sellerpenjualanTerendahToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem minumanToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stokMinumanToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toppingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kembaliKeMenuToolStripMenuItem;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.DateTimePicker dateTimePickerAwal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerAkhir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tampilToolStripMenuItem;
    }
}