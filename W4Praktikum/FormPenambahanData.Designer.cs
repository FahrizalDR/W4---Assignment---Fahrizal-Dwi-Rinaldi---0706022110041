
namespace W4Praktikum
{
    partial class FormPenambahanData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPenambahanData));
            this.LabelNama = new System.Windows.Forms.Label();
            this.LabelAlamat = new System.Windows.Forms.Label();
            this.LabelTelepon = new System.Windows.Forms.Label();
            this.ButtonSimpan = new System.Windows.Forms.Button();
            this.ButtonLihatData = new System.Windows.Forms.Button();
            this.TextBoxNama = new System.Windows.Forms.TextBox();
            this.TextBoxTelepon = new System.Windows.Forms.TextBox();
            this.TextBoxAlamat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelNama
            // 
            resources.ApplyResources(this.LabelNama, "LabelNama");
            this.LabelNama.Name = "LabelNama";
            // 
            // LabelAlamat
            // 
            resources.ApplyResources(this.LabelAlamat, "LabelAlamat");
            this.LabelAlamat.Name = "LabelAlamat";
            // 
            // LabelTelepon
            // 
            resources.ApplyResources(this.LabelTelepon, "LabelTelepon");
            this.LabelTelepon.Name = "LabelTelepon";
            // 
            // ButtonSimpan
            // 
            resources.ApplyResources(this.ButtonSimpan, "ButtonSimpan");
            this.ButtonSimpan.Name = "ButtonSimpan";
            this.ButtonSimpan.UseVisualStyleBackColor = true;
            this.ButtonSimpan.Click += new System.EventHandler(this.ButtonSimpan_Click);
            // 
            // ButtonLihatData
            // 
            resources.ApplyResources(this.ButtonLihatData, "ButtonLihatData");
            this.ButtonLihatData.Name = "ButtonLihatData";
            this.ButtonLihatData.UseVisualStyleBackColor = true;
            this.ButtonLihatData.Click += new System.EventHandler(this.ButtonLihatData_Click);
            // 
            // TextBoxNama
            // 
            resources.ApplyResources(this.TextBoxNama, "TextBoxNama");
            this.TextBoxNama.Name = "TextBoxNama";
            // 
            // TextBoxTelepon
            // 
            resources.ApplyResources(this.TextBoxTelepon, "TextBoxTelepon");
            this.TextBoxTelepon.Name = "TextBoxTelepon";
            this.TextBoxTelepon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxTelepon_KeyPress);
            // 
            // TextBoxAlamat
            // 
            resources.ApplyResources(this.TextBoxAlamat, "TextBoxAlamat");
            this.TextBoxAlamat.Name = "TextBoxAlamat";
            // 
            // FormPenambahanData
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBoxAlamat);
            this.Controls.Add(this.TextBoxTelepon);
            this.Controls.Add(this.TextBoxNama);
            this.Controls.Add(this.ButtonLihatData);
            this.Controls.Add(this.ButtonSimpan);
            this.Controls.Add(this.LabelTelepon);
            this.Controls.Add(this.LabelAlamat);
            this.Controls.Add(this.LabelNama);
            this.Name = "FormPenambahanData";
            this.Load += new System.EventHandler(this.FormPenambahanData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNama;
        private System.Windows.Forms.Label LabelAlamat;
        private System.Windows.Forms.Label LabelTelepon;
        private System.Windows.Forms.Button ButtonSimpan;
        private System.Windows.Forms.Button ButtonLihatData;
        private System.Windows.Forms.TextBox TextBoxNama;
        private System.Windows.Forms.TextBox TextBoxTelepon;
        private System.Windows.Forms.TextBox TextBoxAlamat;
    }
}

