using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btbuoi4
{
    public partial class Form1 : Form
    {
        List<classSV> list = new List<classSV>();
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Form1"];
        //((Form1) f).dtgvTTSV.DataSource = source;
        public DataGridView Dgv { get; set; }
        //private void DoSomething()
        //{
        //    var anotherForm = new SinhVien();
        //    anotherForm.(this);
        //}

        public Form1()
        {
            InitializeComponent();
        }

        private void themMoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.MdiParent = this;
            sv.Dock = DockStyle.Right;
            sv.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.MdiParent = this;
            sv.Dock = DockStyle.Right;
            sv.Show();
        }

        //private void BindingData(List<classSV> list)
        //{
        //    foreach (var item in list)
        //    {
        //        int index = dtgvTTSV.Rows.Add();
        //        dtgvTTSV.Rows[index].Cells[0].Value = item.Stt;
        //        dtgvTTSV.Rows[index].Cells[1].Value = item.MSSV;
        //        dtgvTTSV.Rows[index].Cells[2].Value = item.TenSV;
        //        dtgvTTSV.Rows[index].Cells[3].Value = item.Khoa;
        //        dtgvTTSV.Rows[index].Cells[4].Value = item.DTB;
        //    }
        //}

        public void SetDataFromForm2(string dataMSSV, string dataHoTen, string dataDTB, string dataKhoa)
        {
            // Process the data from Form2 here
            // Set the data in a control on Form1
            List<classSV> list = new List<classSV>();
            list.Add(new classSV() { MSSV = dataMSSV, TenSV = dataHoTen, DTB = dataDTB, Khoa = dataKhoa });
            var source = new BindingSource(list,null);
            dtgvTTSV.DataSource = source;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dtgvTTSV.DataSource = ;
            //List<classSV> list = new List<classSV>();
            //classSV sv;
            //sv = new classSV { Stt = "1", MSSV = "13343", TenSV = "Khoa", Khoa = "CNTT", DTB = "8" };
            //list.Add(sv);
            //BindingData(list);
        }
    }
}
