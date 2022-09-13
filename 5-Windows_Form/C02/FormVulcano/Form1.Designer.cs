
namespace FormVulcano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtFahrenhit = new System.Windows.Forms.TextBox();
            this.txtKelvinACelsius = new System.Windows.Forms.TextBox();
            this.txtKelvin = new System.Windows.Forms.TextBox();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtCelsiusACelsius = new System.Windows.Forms.TextBox();
            this.txtKelvinAKelvin = new System.Windows.Forms.TextBox();
            this.txtCelsiusAKelvin = new System.Windows.Forms.TextBox();
            this.txtFahrenhitACelsius = new System.Windows.Forms.TextBox();
            this.txtFahremhitAKelvin = new System.Windows.Forms.TextBox();
            this.txtFahrenhitAFahrenhit = new System.Windows.Forms.TextBox();
            this.txtCelsiusAFahrenhit = new System.Windows.Forms.TextBox();
            this.txtKelvinAFahrenhit = new System.Windows.Forms.TextBox();
            this.lblFahrenhit = new System.Windows.Forms.Label();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblKelvin = new System.Windows.Forms.Label();
            this.btnConvertFahrenhit = new System.Windows.Forms.Button();
            this.btnConvertCelsius = new System.Windows.Forms.Button();
            this.btnConvertKelvin = new System.Windows.Forms.Button();
            this.lblFahrenhitDos = new System.Windows.Forms.Label();
            this.lblCelciusDos = new System.Windows.Forms.Label();
            this.lblKelvinDos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFahrenhit
            // 
            this.txtFahrenhit.Location = new System.Drawing.Point(128, 87);
            this.txtFahrenhit.Name = "txtFahrenhit";
            this.txtFahrenhit.Size = new System.Drawing.Size(100, 23);
            this.txtFahrenhit.TabIndex = 0;
            // 
            // txtKelvinACelsius
            // 
            this.txtKelvinACelsius.Location = new System.Drawing.Point(558, 178);
            this.txtKelvinACelsius.Name = "txtKelvinACelsius";
            this.txtKelvinACelsius.Size = new System.Drawing.Size(112, 23);
            this.txtKelvinACelsius.TabIndex = 1;
            this.txtKelvinACelsius.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtKelvin
            // 
            this.txtKelvin.Location = new System.Drawing.Point(128, 178);
            this.txtKelvin.Name = "txtKelvin";
            this.txtKelvin.Size = new System.Drawing.Size(100, 23);
            this.txtKelvin.TabIndex = 2;
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(128, 133);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 23);
            this.txtCelsius.TabIndex = 3;
            // 
            // txtCelsiusACelsius
            // 
            this.txtCelsiusACelsius.Location = new System.Drawing.Point(558, 133);
            this.txtCelsiusACelsius.Name = "txtCelsiusACelsius";
            this.txtCelsiusACelsius.Size = new System.Drawing.Size(112, 23);
            this.txtCelsiusACelsius.TabIndex = 4;
            this.txtCelsiusACelsius.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtKelvinAKelvin
            // 
            this.txtKelvinAKelvin.Location = new System.Drawing.Point(709, 178);
            this.txtKelvinAKelvin.Name = "txtKelvinAKelvin";
            this.txtKelvinAKelvin.Size = new System.Drawing.Size(112, 23);
            this.txtKelvinAKelvin.TabIndex = 5;
            this.txtKelvinAKelvin.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtCelsiusAKelvin
            // 
            this.txtCelsiusAKelvin.Location = new System.Drawing.Point(709, 133);
            this.txtCelsiusAKelvin.Name = "txtCelsiusAKelvin";
            this.txtCelsiusAKelvin.Size = new System.Drawing.Size(112, 23);
            this.txtCelsiusAKelvin.TabIndex = 6;
            this.txtCelsiusAKelvin.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtFahrenhitACelsius
            // 
            this.txtFahrenhitACelsius.Location = new System.Drawing.Point(558, 87);
            this.txtFahrenhitACelsius.Name = "txtFahrenhitACelsius";
            this.txtFahrenhitACelsius.Size = new System.Drawing.Size(112, 23);
            this.txtFahrenhitACelsius.TabIndex = 7;
            this.txtFahrenhitACelsius.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtFahremhitAKelvin
            // 
            this.txtFahremhitAKelvin.Location = new System.Drawing.Point(709, 86);
            this.txtFahremhitAKelvin.Name = "txtFahremhitAKelvin";
            this.txtFahremhitAKelvin.Size = new System.Drawing.Size(112, 23);
            this.txtFahremhitAKelvin.TabIndex = 8;
            // 
            // txtFahrenhitAFahrenhit
            // 
            this.txtFahrenhitAFahrenhit.Location = new System.Drawing.Point(398, 87);
            this.txtFahrenhitAFahrenhit.Name = "txtFahrenhitAFahrenhit";
            this.txtFahrenhitAFahrenhit.Size = new System.Drawing.Size(113, 23);
            this.txtFahrenhitAFahrenhit.TabIndex = 9;
            this.txtFahrenhitAFahrenhit.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // txtCelsiusAFahrenhit
            // 
            this.txtCelsiusAFahrenhit.Location = new System.Drawing.Point(398, 133);
            this.txtCelsiusAFahrenhit.Name = "txtCelsiusAFahrenhit";
            this.txtCelsiusAFahrenhit.Size = new System.Drawing.Size(113, 23);
            this.txtCelsiusAFahrenhit.TabIndex = 10;
            this.txtCelsiusAFahrenhit.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // txtKelvinAFahrenhit
            // 
            this.txtKelvinAFahrenhit.Location = new System.Drawing.Point(398, 178);
            this.txtKelvinAFahrenhit.Name = "txtKelvinAFahrenhit";
            this.txtKelvinAFahrenhit.Size = new System.Drawing.Size(113, 23);
            this.txtKelvinAFahrenhit.TabIndex = 11;
            this.txtKelvinAFahrenhit.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // lblFahrenhit
            // 
            this.lblFahrenhit.AutoSize = true;
            this.lblFahrenhit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFahrenhit.Location = new System.Drawing.Point(12, 89);
            this.lblFahrenhit.Name = "lblFahrenhit";
            this.lblFahrenhit.Size = new System.Drawing.Size(75, 21);
            this.lblFahrenhit.TabIndex = 12;
            this.lblFahrenhit.Text = "Fahrenhit";
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCelsius.Location = new System.Drawing.Point(12, 135);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(63, 21);
            this.lblCelsius.TabIndex = 13;
            this.lblCelsius.Text = "Ceksius";
            // 
            // lblKelvin
            // 
            this.lblKelvin.AutoSize = true;
            this.lblKelvin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKelvin.Location = new System.Drawing.Point(12, 178);
            this.lblKelvin.Name = "lblKelvin";
            this.lblKelvin.Size = new System.Drawing.Size(52, 21);
            this.lblKelvin.TabIndex = 14;
            this.lblKelvin.Text = "Kelvin";
            // 
            // btnConvertFahrenhit
            // 
            this.btnConvertFahrenhit.Image = ((System.Drawing.Image)(resources.GetObject("btnConvertFahrenhit.Image")));
            this.btnConvertFahrenhit.Location = new System.Drawing.Point(267, 86);
            this.btnConvertFahrenhit.Name = "btnConvertFahrenhit";
            this.btnConvertFahrenhit.Size = new System.Drawing.Size(104, 23);
            this.btnConvertFahrenhit.TabIndex = 15;
            this.btnConvertFahrenhit.UseVisualStyleBackColor = true;
            this.btnConvertFahrenhit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConvertCelsius
            // 
            this.btnConvertCelsius.Image = ((System.Drawing.Image)(resources.GetObject("btnConvertCelsius.Image")));
            this.btnConvertCelsius.Location = new System.Drawing.Point(267, 135);
            this.btnConvertCelsius.Name = "btnConvertCelsius";
            this.btnConvertCelsius.Size = new System.Drawing.Size(104, 23);
            this.btnConvertCelsius.TabIndex = 16;
            this.btnConvertCelsius.UseVisualStyleBackColor = true;
            this.btnConvertCelsius.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConvertKelvin
            // 
            this.btnConvertKelvin.Image = ((System.Drawing.Image)(resources.GetObject("btnConvertKelvin.Image")));
            this.btnConvertKelvin.Location = new System.Drawing.Point(267, 177);
            this.btnConvertKelvin.Name = "btnConvertKelvin";
            this.btnConvertKelvin.Size = new System.Drawing.Size(104, 23);
            this.btnConvertKelvin.TabIndex = 17;
            this.btnConvertKelvin.UseVisualStyleBackColor = true;
            this.btnConvertKelvin.Click += new System.EventHandler(this.btnConvertKelvin_Click);
            // 
            // lblFahrenhitDos
            // 
            this.lblFahrenhitDos.AutoSize = true;
            this.lblFahrenhitDos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFahrenhitDos.Location = new System.Drawing.Point(418, 46);
            this.lblFahrenhitDos.Name = "lblFahrenhitDos";
            this.lblFahrenhitDos.Size = new System.Drawing.Size(75, 21);
            this.lblFahrenhitDos.TabIndex = 18;
            this.lblFahrenhitDos.Text = "Fahrenhit";
            // 
            // lblCelciusDos
            // 
            this.lblCelciusDos.AutoSize = true;
            this.lblCelciusDos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCelciusDos.Location = new System.Drawing.Point(584, 46);
            this.lblCelciusDos.Name = "lblCelciusDos";
            this.lblCelciusDos.Size = new System.Drawing.Size(59, 21);
            this.lblCelciusDos.TabIndex = 19;
            this.lblCelciusDos.Text = "Celsius";
            // 
            // lblKelvinDos
            // 
            this.lblKelvinDos.AutoSize = true;
            this.lblKelvinDos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKelvinDos.Location = new System.Drawing.Point(738, 46);
            this.lblKelvinDos.Name = "lblKelvinDos";
            this.lblKelvinDos.Size = new System.Drawing.Size(52, 21);
            this.lblKelvinDos.TabIndex = 20;
            this.lblKelvinDos.Text = "Kelvin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(871, 255);
            this.Controls.Add(this.lblKelvinDos);
            this.Controls.Add(this.lblCelciusDos);
            this.Controls.Add(this.lblFahrenhitDos);
            this.Controls.Add(this.btnConvertKelvin);
            this.Controls.Add(this.btnConvertCelsius);
            this.Controls.Add(this.btnConvertFahrenhit);
            this.Controls.Add(this.lblKelvin);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.lblFahrenhit);
            this.Controls.Add(this.txtKelvinAFahrenhit);
            this.Controls.Add(this.txtCelsiusAFahrenhit);
            this.Controls.Add(this.txtFahrenhitAFahrenhit);
            this.Controls.Add(this.txtFahremhitAKelvin);
            this.Controls.Add(this.txtFahrenhitACelsius);
            this.Controls.Add(this.txtCelsiusAKelvin);
            this.Controls.Add(this.txtKelvinAKelvin);
            this.Controls.Add(this.txtCelsiusACelsius);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.txtKelvin);
            this.Controls.Add(this.txtKelvinACelsius);
            this.Controls.Add(this.txtFahrenhit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFahrenhit;
        private System.Windows.Forms.TextBox txtKelvinACelsius;
        private System.Windows.Forms.TextBox txtKelvin;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtCelsiusACelsius;
        private System.Windows.Forms.TextBox txtKelvinAKelvin;
        private System.Windows.Forms.TextBox txtCelsiusAKelvin;
        private System.Windows.Forms.TextBox txtFahrenhitACelsius;
        private System.Windows.Forms.TextBox txtFahremhitAKelvin;
        private System.Windows.Forms.TextBox txtFahrenhitAFahrenhit;
        private System.Windows.Forms.TextBox txtCelsiusAFahrenhit;
        private System.Windows.Forms.TextBox txtKelvinAFahrenhit;
        private System.Windows.Forms.Label lblFahrenhit;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label lblKelvin;
        private System.Windows.Forms.Button btnConvertFahrenhit;
        private System.Windows.Forms.Button btnConvertCelsius;
        private System.Windows.Forms.Button btnConvertKelvin;
        private System.Windows.Forms.Label lblFahrenhitDos;
        private System.Windows.Forms.Label lblCelciusDos;
        private System.Windows.Forms.Label lblKelvinDos;
    }
}

