namespace PhanBaoTrung_ThiThu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<QuanLyXeOto> ds1 = new List<QuanLyXeOto>();

        private void button1_Click(object sender, EventArgs e)
        {
            double giaBan;
            if (double.TryParse(txt_gb.Text, out giaBan))
            {
                QuanLyXeOto quanLyXeOto = new QuanLyXeOto();
                ds1.Add(quanLyXeOto);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ds1;
            }
            else
            {
                MessageBox.Show("Cần Điền Đầy Đủ Thông Tin");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (QuanLyXeOto i in ds1)
            {
                if (i.HangXe == txt_hx.Text)
                {
                    ds1.Remove(i);
                    break;
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (QuanLyXeOto i in ds1)
            {
                if (i.HangXe == txt_hx.Text)
                {
                    i.BienSo = txt_bs.Text;
                    i.NamSanXuat = txt_nsx.Text;
                    i.GiaBan = double.Parse(txt_gb.Text);
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
