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
    public partial class FormTampilanData : Form
    {
        public FormTampilanData()
        {
            InitializeComponent();
        }
      
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            FormPenambahanData formPenambahanData = new FormPenambahanData();
            formPenambahanData.Show();
            this.Hide();
        }

        private void TextBoxNama_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FormTampilanData_Load(object sender, EventArgs e)
        {
            
        }
    }
}
