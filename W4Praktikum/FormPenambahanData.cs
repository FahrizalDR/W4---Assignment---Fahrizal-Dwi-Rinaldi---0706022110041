using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W4Praktikum
{
    public partial class FormPenambahanData : Form
    {
        public FormPenambahanData()
        {
            InitializeComponent();
        }

        public DataTable PersonalDetails = new DataTable();
        
        private void FormPenambahanData_Load(object sender, EventArgs e)
        {
            PersonalDetails.Columns.Add("Nama");
            PersonalDetails.Columns.Add("Alamat");
            PersonalDetails.Columns.Add("Telepon");
        }
        private void ButtonLihatData_Click(object sender, EventArgs e)
        {
            FormTampilanData formTampilanData = new FormTampilanData();            
            formTampilanData.Show();
            this.Hide();              
        }
        private void ButtonSimpan_Click(object sender, EventArgs e)
        {
            PersonalDetails.Rows.Add(TextBoxNama.Text, TextBoxAlamat.Text, TextBoxTelepon.Text);            
        }
        private void TextBoxTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
