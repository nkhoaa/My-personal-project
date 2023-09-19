using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btbuoi4
{
    public partial class SinhVien : Form
    {
        List<classSV> list = new List<classSV>();
        //public DataGridView Dgv { get; set; }
        //SinhVien f = new SinhVien();
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Form1"];

        public SinhVien()
        {
            InitializeComponent();
            cbKhoa.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //students.Add(new Student() { MSSV = txtMSSV.Text, HoTen = txtHoTen.Text, DTB = Convert.ToDouble(txtDTB.Text), Khoa = cbmKhoa.Text });
            //var source = new BindingSource(students, null);
            //((Form1)f).dgvData.DataSource = source;
            if (this.MdiParent is Form1 mdiParentForm)
            {
                // Replace with your data
                string dataMSSV = txtMSSV.Text;
                string dataHoTen = txtTenSV.Text;
                string dataDTB = txtDiemTB.Text;
                string dataKhoa = cbKhoa.Text;
                if(txtMSSV.Text == "" || txtTenSV.Text == "" || txtDiemTB.Text == "" || cbKhoa.Text == "")
                {
                    MessageBox.Show("Nhap lai");
                }
                else
                {
                    mdiParentForm.SetDataFromForm2(dataMSSV, dataHoTen, dataDTB, dataKhoa); // Call the method in Form1
                }
            }
        }
    }
}
