
namespace PraktikumWeek7
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
            this.labelInputKalimat = new System.Windows.Forms.Label();
            this.labelInputHuruf = new System.Windows.Forms.Label();
            this.labelHasil = new System.Windows.Forms.Label();
            this.labelMenjadi = new System.Windows.Forms.Label();
            this.tBoxInputKalimat = new System.Windows.Forms.TextBox();
            this.tBoxInputHuruf = new System.Windows.Forms.TextBox();
            this.tBoxMenjadi = new System.Windows.Forms.TextBox();
            this.btnKonversi = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInputKalimat
            // 
            this.labelInputKalimat.AutoSize = true;
            this.labelInputKalimat.Location = new System.Drawing.Point(12, 22);
            this.labelInputKalimat.Name = "labelInputKalimat";
            this.labelInputKalimat.Size = new System.Drawing.Size(110, 15);
            this.labelInputKalimat.TabIndex = 0;
            this.labelInputKalimat.Text = "Masukkan Kalimat :";
            // 
            // labelInputHuruf
            // 
            this.labelInputHuruf.AutoSize = true;
            this.labelInputHuruf.Location = new System.Drawing.Point(13, 63);
            this.labelInputHuruf.Name = "labelInputHuruf";
            this.labelInputHuruf.Size = new System.Drawing.Size(110, 15);
            this.labelInputHuruf.TabIndex = 1;
            this.labelInputHuruf.Text = "Masukkan Huruf    :";
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Location = new System.Drawing.Point(13, 134);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(108, 15);
            this.labelHasil.TabIndex = 2;
            this.labelHasil.Text = "Hasil                        :";
            // 
            // labelMenjadi
            // 
            this.labelMenjadi.AutoSize = true;
            this.labelMenjadi.Location = new System.Drawing.Point(196, 63);
            this.labelMenjadi.Name = "labelMenjadi";
            this.labelMenjadi.Size = new System.Drawing.Size(56, 15);
            this.labelMenjadi.TabIndex = 3;
            this.labelMenjadi.Text = "Menjadi :";
            // 
            // tBoxInputKalimat
            // 
            this.tBoxInputKalimat.Location = new System.Drawing.Point(120, 19);
            this.tBoxInputKalimat.Name = "tBoxInputKalimat";
            this.tBoxInputKalimat.Size = new System.Drawing.Size(216, 23);
            this.tBoxInputKalimat.TabIndex = 4;
            // 
            // tBoxInputHuruf
            // 
            this.tBoxInputHuruf.Location = new System.Drawing.Point(120, 60);
            this.tBoxInputHuruf.Name = "tBoxInputHuruf";
            this.tBoxInputHuruf.Size = new System.Drawing.Size(67, 23);
            this.tBoxInputHuruf.TabIndex = 5;
            // 
            // tBoxMenjadi
            // 
            this.tBoxMenjadi.Location = new System.Drawing.Point(258, 63);
            this.tBoxMenjadi.Name = "tBoxMenjadi";
            this.tBoxMenjadi.Size = new System.Drawing.Size(78, 23);
            this.tBoxMenjadi.TabIndex = 6;
            // 
            // btnKonversi
            // 
            this.btnKonversi.Location = new System.Drawing.Point(120, 102);
            this.btnKonversi.Name = "btnKonversi";
            this.btnKonversi.Size = new System.Drawing.Size(216, 23);
            this.btnKonversi.TabIndex = 7;
            this.btnKonversi.Text = "Konversi";
            this.btnKonversi.UseVisualStyleBackColor = true;
            this.btnKonversi.Click += new System.EventHandler(this.btnKonversi_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(120, 134);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(0, 15);
            this.labelOutput.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 169);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.btnKonversi);
            this.Controls.Add(this.tBoxMenjadi);
            this.Controls.Add(this.tBoxInputHuruf);
            this.Controls.Add(this.tBoxInputKalimat);
            this.Controls.Add(this.labelMenjadi);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.labelInputHuruf);
            this.Controls.Add(this.labelInputKalimat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInputKalimat;
        private System.Windows.Forms.Label labelInputHuruf;
        private System.Windows.Forms.Label labelHasil;
        private System.Windows.Forms.Label labelMenjadi;
        private System.Windows.Forms.TextBox tBoxInputKalimat;
        private System.Windows.Forms.TextBox tBoxInputHuruf;
        private System.Windows.Forms.TextBox tBoxMenjadi;
        private System.Windows.Forms.Button btnKonversi;
        private System.Windows.Forms.Label labelOutput;
    }
}

