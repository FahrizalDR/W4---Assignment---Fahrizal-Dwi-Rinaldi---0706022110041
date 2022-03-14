
namespace W4Praktikum
{
    partial class FormTampilanData
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
            this.TextBoxAlamatForm2 = new System.Windows.Forms.TextBox();
            this.TextBoxTeleponForm2 = new System.Windows.Forms.TextBox();
            this.TextBoxNamaForm2 = new System.Windows.Forms.TextBox();
            this.LabelTeleponForm2 = new System.Windows.Forms.Label();
            this.LabelAlamatForm2 = new System.Windows.Forms.Label();
            this.LabelNamaForm2 = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonPrev = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxAlamatForm2
            // 
            this.TextBoxAlamatForm2.Enabled = false;
            this.TextBoxAlamatForm2.Location = new System.Drawing.Point(118, 79);
            this.TextBoxAlamatForm2.Name = "TextBoxAlamatForm2";
            this.TextBoxAlamatForm2.Size = new System.Drawing.Size(484, 27);
            this.TextBoxAlamatForm2.TabIndex = 13;
            // 
            // TextBoxTeleponForm2
            // 
            this.TextBoxTeleponForm2.Enabled = false;
            this.TextBoxTeleponForm2.Location = new System.Drawing.Point(118, 121);
            this.TextBoxTeleponForm2.Name = "TextBoxTeleponForm2";
            this.TextBoxTeleponForm2.Size = new System.Drawing.Size(484, 27);
            this.TextBoxTeleponForm2.TabIndex = 12;
            // 
            // TextBoxNamaForm2
            // 
            this.TextBoxNamaForm2.Enabled = false;
            this.TextBoxNamaForm2.Location = new System.Drawing.Point(118, 35);
            this.TextBoxNamaForm2.Name = "TextBoxNamaForm2";
            this.TextBoxNamaForm2.Size = new System.Drawing.Size(484, 27);
            this.TextBoxNamaForm2.TabIndex = 11;
            this.TextBoxNamaForm2.TextChanged += new System.EventHandler(this.TextBoxNama_TextChanged);
            // 
            // LabelTeleponForm2
            // 
            this.LabelTeleponForm2.AutoSize = true;
            this.LabelTeleponForm2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelTeleponForm2.Location = new System.Drawing.Point(36, 124);
            this.LabelTeleponForm2.Name = "LabelTeleponForm2";
            this.LabelTeleponForm2.Size = new System.Drawing.Size(69, 20);
            this.LabelTeleponForm2.TabIndex = 10;
            this.LabelTeleponForm2.Text = "Telepon :";
            // 
            // LabelAlamatForm2
            // 
            this.LabelAlamatForm2.AutoSize = true;
            this.LabelAlamatForm2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelAlamatForm2.Location = new System.Drawing.Point(36, 79);
            this.LabelAlamatForm2.Name = "LabelAlamatForm2";
            this.LabelAlamatForm2.Size = new System.Drawing.Size(64, 20);
            this.LabelAlamatForm2.TabIndex = 9;
            this.LabelAlamatForm2.Text = "Alamat :";
            // 
            // LabelNamaForm2
            // 
            this.LabelNamaForm2.AutoSize = true;
            this.LabelNamaForm2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelNamaForm2.Location = new System.Drawing.Point(36, 38);
            this.LabelNamaForm2.Name = "LabelNamaForm2";
            this.LabelNamaForm2.Size = new System.Drawing.Size(56, 20);
            this.LabelNamaForm2.TabIndex = 8;
            this.LabelNamaForm2.Text = "Nama :";
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(36, 187);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(94, 29);
            this.ButtonBack.TabIndex = 14;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonPrev
            // 
            this.ButtonPrev.Location = new System.Drawing.Point(160, 187);
            this.ButtonPrev.Name = "ButtonPrev";
            this.ButtonPrev.Size = new System.Drawing.Size(94, 29);
            this.ButtonPrev.TabIndex = 15;
            this.ButtonPrev.Text = "Prev Data";
            this.ButtonPrev.UseVisualStyleBackColor = true;
            // 
            // ButtonNext
            // 
            this.ButtonNext.Location = new System.Drawing.Point(280, 187);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(94, 29);
            this.ButtonNext.TabIndex = 16;
            this.ButtonNext.Text = "Next Data";
            this.ButtonNext.UseVisualStyleBackColor = true;
            // 
            // FormTampilanData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 285);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.ButtonPrev);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.TextBoxAlamatForm2);
            this.Controls.Add(this.TextBoxTeleponForm2);
            this.Controls.Add(this.TextBoxNamaForm2);
            this.Controls.Add(this.LabelTeleponForm2);
            this.Controls.Add(this.LabelAlamatForm2);
            this.Controls.Add(this.LabelNamaForm2);
            this.Name = "FormTampilanData";
            this.Text = "Form Tampilan Data";
            this.Load += new System.EventHandler(this.FormTampilanData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxAlamatForm2;
        private System.Windows.Forms.TextBox TextBoxTeleponForm2;
        private System.Windows.Forms.TextBox TextBoxNamaForm2;
        private System.Windows.Forms.Label LabelTeleponForm2;
        private System.Windows.Forms.Label LabelAlamatForm2;
        private System.Windows.Forms.Label LabelNamaForm2;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonPrev;
        private System.Windows.Forms.Button ButtonNext;
    }
}