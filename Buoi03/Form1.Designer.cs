namespace Buoi03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            gbDichVu = new GroupBox();
            checkedListBox2 = new CheckedListBox();
            gbTienNghi = new GroupBox();
            checkedListBox1 = new CheckedListBox();
            gbLoaiPhong = new GroupBox();
            tbNumOfStay = new TextBox();
            tbAddress = new TextBox();
            tbName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnThanhToan = new Button();
            btnNhapMoi = new Button();
            lbThanhTien = new Label();
            groupBox1 = new GroupBox();
            lbSoLuotNguoi = new Label();
            lbTongSoTien = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnTongKet = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            gbDichVu.SuspendLayout();
            gbTienNghi.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Bottom;
            splitContainer1.Location = new Point(0, 60);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(gbDichVu);
            splitContainer1.Panel1.Controls.Add(gbTienNghi);
            splitContainer1.Panel1.Controls.Add(gbLoaiPhong);
            splitContainer1.Panel1.Controls.Add(tbNumOfStay);
            splitContainer1.Panel1.Controls.Add(tbAddress);
            splitContainer1.Panel1.Controls.Add(tbName);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnExit);
            splitContainer1.Panel2.Controls.Add(btnTongKet);
            splitContainer1.Panel2.Controls.Add(textBox3);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Panel2.Controls.Add(lbThanhTien);
            splitContainer1.Panel2.Controls.Add(btnNhapMoi);
            splitContainer1.Panel2.Controls.Add(btnThanhToan);
            splitContainer1.Panel2.ForeColor = Color.Black;
            splitContainer1.Size = new Size(800, 390);
            splitContainer1.SplitterDistance = 500;
            splitContainer1.TabIndex = 0;
            // 
            // gbDichVu
            // 
            gbDichVu.Controls.Add(checkedListBox2);
            gbDichVu.Location = new Point(352, 165);
            gbDichVu.Name = "gbDichVu";
            gbDichVu.Size = new Size(145, 197);
            gbDichVu.TabIndex = 8;
            gbDichVu.TabStop = false;
            gbDichVu.Text = "Dịch Vụ";
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(6, 28);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(139, 136);
            checkedListBox2.TabIndex = 0;
            // 
            // gbTienNghi
            // 
            gbTienNghi.Controls.Add(checkedListBox1);
            gbTienNghi.Location = new Point(185, 165);
            gbTienNghi.Name = "gbTienNghi";
            gbTienNghi.Size = new Size(152, 197);
            gbTienNghi.TabIndex = 7;
            gbTienNghi.TabStop = false;
            gbTienNghi.Text = "Tiện Nghi";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 26);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(140, 136);
            checkedListBox1.TabIndex = 9;
            // 
            // gbLoaiPhong
            // 
            gbLoaiPhong.Location = new Point(20, 165);
            gbLoaiPhong.Name = "gbLoaiPhong";
            gbLoaiPhong.Size = new Size(148, 197);
            gbLoaiPhong.TabIndex = 6;
            gbLoaiPhong.TabStop = false;
            gbLoaiPhong.Text = "Loại phòng";
            // 
            // tbNumOfStay
            // 
            tbNumOfStay.Location = new Point(113, 93);
            tbNumOfStay.Name = "tbNumOfStay";
            tbNumOfStay.Size = new Size(165, 27);
            tbNumOfStay.TabIndex = 5;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(113, 53);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(165, 27);
            tbAddress.TabIndex = 4;
            // 
            // tbName
            // 
            tbName.Location = new Point(113, 15);
            tbName.Name = "tbName";
            tbName.Size = new Size(165, 27);
            tbName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 93);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "Số ngày ở:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 53);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Địa chỉ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên:";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Cursor = Cursors.Hand;
            btnThanhToan.Location = new Point(17, 11);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(94, 29);
            btnThanhToan.TabIndex = 0;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnNhapMoi
            // 
            btnNhapMoi.BackColor = SystemColors.Control;
            btnNhapMoi.Cursor = Cursors.Hand;
            btnNhapMoi.ImageAlign = ContentAlignment.TopCenter;
            btnNhapMoi.Location = new Point(134, 11);
            btnNhapMoi.Name = "btnNhapMoi";
            btnNhapMoi.Size = new Size(94, 29);
            btnNhapMoi.TabIndex = 1;
            btnNhapMoi.Text = "Nhập Mới";
            btnNhapMoi.UseVisualStyleBackColor = false;
            // 
            // lbThanhTien
            // 
            lbThanhTien.AutoSize = true;
            lbThanhTien.Location = new Point(17, 60);
            lbThanhTien.Name = "lbThanhTien";
            lbThanhTien.Size = new Size(81, 20);
            lbThanhTien.TabIndex = 2;
            lbThanhTien.Text = "Thành Tiền";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(lbTongSoTien);
            groupBox1.Controls.Add(lbSoLuotNguoi);
            groupBox1.Location = new Point(17, 176);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin tổng kết";
            // 
            // lbSoLuotNguoi
            // 
            lbSoLuotNguoi.AutoSize = true;
            lbSoLuotNguoi.Location = new Point(6, 23);
            lbSoLuotNguoi.Name = "lbSoLuotNguoi";
            lbSoLuotNguoi.Size = new Size(106, 20);
            lbSoLuotNguoi.TabIndex = 0;
            lbSoLuotNguoi.Text = "Số Lượt Người";
            // 
            // lbTongSoTien
            // 
            lbTongSoTien.AutoSize = true;
            lbTongSoTien.Location = new Point(6, 69);
            lbTongSoTien.Name = "lbTongSoTien";
            lbTongSoTien.Size = new Size(91, 20);
            lbTongSoTien.TabIndex = 1;
            lbTongSoTien.Text = "Tổng số tiền";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(122, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(113, 60);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 4;
            // 
            // btnTongKet
            // 
            btnTongKet.Location = new Point(17, 109);
            btnTongKet.Name = "btnTongKet";
            btnTongKet.Size = new Size(94, 29);
            btnTongKet.TabIndex = 5;
            btnTongKet.Text = "Tổng Kết";
            btnTongKet.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(17, 322);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            gbDichVu.ResumeLayout(false);
            gbTienNghi.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbName;
        private TextBox tbNumOfStay;
        private TextBox tbAddress;
        private GroupBox gbDichVu;
        private GroupBox gbTienNghi;
        private GroupBox gbLoaiPhong;
        private CheckedListBox checkedListBox2;
        private CheckedListBox checkedListBox1;
        private Button btnNhapMoi;
        private Button btnThanhToan;
        private Button btnExit;
        private Button btnTongKet;
        private TextBox textBox3;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lbTongSoTien;
        private Label lbSoLuotNguoi;
        private Label lbThanhTien;
    }
}
