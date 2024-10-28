using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add_Production
{
    public partial class Form1 : Form
    {

        private List<SinhVien> danhSachSinhVien = new List<SinhVien>();

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
            NhapDuLieuMau();  
            HienThiDanhSachSinhVien();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Mã SV";
            dataGridView1.Columns[1].Name = "Tên SV";
            dataGridView1.Columns[2].Name = "Lớp";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void NhapDuLieuMau()
        {
            danhSachSinhVien.Add(new SinhVien("1", "Nguyễn Văn A", "CNTT1"));
            danhSachSinhVien.Add(new SinhVien("2", "Trần Thị B", "CNTT2"));
            danhSachSinhVien.Add(new SinhVien("3", "Lê Văn C", "CNTT3"));
            danhSachSinhVien.Add(new SinhVien("4", "Phạm Thị D", "CNTT1"));
            danhSachSinhVien.Add(new SinhVien("5", "Vũ Thị E", "CNTT2"));
        }

        private void HienThiDanhSachSinhVien()
        {
            dataGridView1.Rows.Clear();
            foreach (SinhVien sv in danhSachSinhVien)
            {
                dataGridView1.Rows.Add(sv.MaSV, sv.TenSV, sv.Lop);
            }
        }

        private void label4_Click(object sender, EventArgs e) { }

        private void label8_Click(object sender, EventArgs e) { }

        private void label6_Click(object sender, EventArgs e) { }

        private void label9_Click(object sender, EventArgs e) { }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }

        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {
            string maSV = textBox1.Text;
            string tenSV = textBox2.Text;
            string lop = textBox3.Text;

       
            SinhVien sv = new SinhVien(maSV, tenSV, lop);
            danhSachSinhVien.Add(sv);

            HienThiDanhSachSinhVien();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
       
                int index = dataGridView1.SelectedRows[0].Index;
                danhSachSinhVien[index].MaSV = textBox1.Text;
                danhSachSinhVien[index].TenSV = textBox2.Text;
                danhSachSinhVien[index].Lop = textBox3.Text;

         
                HienThiDanhSachSinhVien();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
         
                int index = dataGridView1.SelectedRows[0].Index;
                danhSachSinhVien.RemoveAt(index);

               
                HienThiDanhSachSinhVien();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
           
            string maSinhVien = searchID_txt.Text;

            SinhVien sv = danhSachSinhVien.Find(s => s.MaSV == maSinhVien);

            if (sv != null)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(sv.MaSV, sv.TenSV, sv.Lop);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HienThiDanhSachSinhVien();
        }
    }


    public class SinhVien
    {
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public string Lop { get; set; }

        public SinhVien(string maSV, string tenSV, string lop)
        {
            MaSV = maSV;
            TenSV = tenSV;
            Lop = lop;
        }
    }
}
