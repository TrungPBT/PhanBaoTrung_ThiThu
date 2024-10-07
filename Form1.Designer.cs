namespace PhanBaoTrung_ThiThu
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
            label1 = new Label();
            txt_hx = new TextBox();
            button1 = new Button();
            txt_bs = new TextBox();
            label2 = new Label();
            txt_nsx = new TextBox();
            label3 = new Label();
            txt_gb = new TextBox();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txt_ten = new TextBox();
            txt_mnv = new TextBox();
            txt_cv = new TextBox();
            txt_lcb = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            dataGridView2 = new DataGridView();
            textBox5 = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 72);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 0;
            label1.Text = "Hãng Xe:";
            // 
            // txt_hx
            // 
            txt_hx.Location = new Point(114, 70);
            txt_hx.Name = "txt_hx";
            txt_hx.Size = new Size(206, 23);
            txt_hx.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(29, 261);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 2;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_bs
            // 
            txt_bs.Location = new Point(114, 113);
            txt_bs.Name = "txt_bs";
            txt_bs.Size = new Size(206, 23);
            txt_bs.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 115);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 3;
            label2.Text = "Biển Số:";
            // 
            // txt_nsx
            // 
            txt_nsx.Location = new Point(152, 154);
            txt_nsx.Name = "txt_nsx";
            txt_nsx.Size = new Size(168, 23);
            txt_nsx.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 156);
            label3.Name = "label3";
            label3.Size = new Size(122, 21);
            label3.TabIndex = 5;
            label3.Text = "Năm Sản Xuất:";
            // 
            // txt_gb
            // 
            txt_gb.Location = new Point(114, 193);
            txt_gb.Name = "txt_gb";
            txt_gb.Size = new Size(206, 23);
            txt_gb.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 195);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 7;
            label4.Text = "Giá Bán:";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Lime;
            button2.Location = new Point(128, 261);
            button2.Name = "button2";
            button2.Size = new Size(75, 34);
            button2.TabIndex = 9;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Lime;
            button3.Location = new Point(228, 261);
            button3.Name = "button3";
            button3.Size = new Size(75, 34);
            button3.TabIndex = 12;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(87, 30);
            label5.Name = "label5";
            label5.Size = new Size(167, 30);
            label5.TabIndex = 13;
            label5.Text = "Quản Lý Xe Oto";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 301);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(319, 150);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(505, 30);
            label6.Name = "label6";
            label6.Size = new Size(203, 30);
            label6.TabIndex = 15;
            label6.Text = "Quản Lý Nhân Viên";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(446, 218);
            label7.Name = "label7";
            label7.Size = new Size(87, 21);
            label7.TabIndex = 19;
            label7.Text = "Lương CB:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(446, 179);
            label8.Name = "label8";
            label8.Size = new Size(78, 21);
            label8.TabIndex = 18;
            label8.Text = "Chức Vụ:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(446, 138);
            label9.Name = "label9";
            label9.Size = new Size(66, 21);
            label9.TabIndex = 17;
            label9.Text = "Mã NV:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(446, 95);
            label10.Name = "label10";
            label10.Size = new Size(41, 21);
            label10.TabIndex = 16;
            label10.Text = "Tên:";
            // 
            // txt_ten
            // 
            txt_ten.Location = new Point(530, 93);
            txt_ten.Name = "txt_ten";
            txt_ten.Size = new Size(221, 23);
            txt_ten.TabIndex = 20;
            // 
            // txt_mnv
            // 
            txt_mnv.Location = new Point(530, 138);
            txt_mnv.Name = "txt_mnv";
            txt_mnv.Size = new Size(221, 23);
            txt_mnv.TabIndex = 21;
            // 
            // txt_cv
            // 
            txt_cv.Location = new Point(530, 177);
            txt_cv.Name = "txt_cv";
            txt_cv.Size = new Size(221, 23);
            txt_cv.TabIndex = 22;
            // 
            // txt_lcb
            // 
            txt_lcb.Location = new Point(539, 220);
            txt_lcb.Name = "txt_lcb";
            txt_lcb.Size = new Size(212, 23);
            txt_lcb.TabIndex = 23;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Lime;
            button4.Location = new Point(663, 261);
            button4.Name = "button4";
            button4.Size = new Size(75, 34);
            button4.TabIndex = 26;
            button4.Text = "Sửa";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Lime;
            button5.Location = new Point(563, 261);
            button5.Name = "button5";
            button5.Size = new Size(75, 34);
            button5.TabIndex = 25;
            button5.Text = "Xóa";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Lime;
            button6.Location = new Point(464, 261);
            button6.Name = "button6";
            button6.Size = new Size(75, 34);
            button6.TabIndex = 24;
            button6.Text = "Thêm";
            button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(446, 313);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(305, 150);
            dataGridView2.TabIndex = 27;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(114, 232);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(206, 23);
            textBox5.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(30, 234);
            label11.Name = "label11";
            label11.Size = new Size(34, 21);
            label11.TabIndex = 28;
            label11.Text = "BC:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(label11);
            Controls.Add(dataGridView2);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(txt_lcb);
            Controls.Add(txt_cv);
            Controls.Add(txt_mnv);
            Controls.Add(txt_ten);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txt_gb);
            Controls.Add(label4);
            Controls.Add(txt_nsx);
            Controls.Add(label3);
            Controls.Add(txt_bs);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txt_hx);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_hx;
        private Button button1;
        private TextBox txt_bs;
        private Label label2;
        private TextBox txt_nsx;
        private Label label3;
        private TextBox txt_gb;
        private Label label4;
        private Button button2;
        private Button button3;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txt_ten;
        private TextBox txt_mnv;
        private TextBox txt_cv;
        private TextBox txt_lcb;
        private Button button4;
        private Button button5;
        private Button button6;
        private DataGridView dataGridView2;
        private TextBox textBox5;
        private Label label11;
    }
}
