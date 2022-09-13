
namespace FormConvertorBinario
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
            this.lblBinToDec = new System.Windows.Forms.Label();
            this.lblDecToBin = new System.Windows.Forms.Label();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.txtResultadoBin = new System.Windows.Forms.TextBox();
            this.txtResultadoDec = new System.Windows.Forms.TextBox();
            this.btnBinToDec = new System.Windows.Forms.Button();
            this.btnDecToBin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBinToDec
            // 
            this.lblBinToDec.AutoSize = true;
            this.lblBinToDec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBinToDec.Location = new System.Drawing.Point(58, 26);
            this.lblBinToDec.Name = "lblBinToDec";
            this.lblBinToDec.Size = new System.Drawing.Size(131, 21);
            this.lblBinToDec.TabIndex = 0;
            this.lblBinToDec.Text = "Binario a Decimal";
            // 
            // lblDecToBin
            // 
            this.lblDecToBin.AutoSize = true;
            this.lblDecToBin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDecToBin.Location = new System.Drawing.Point(58, 103);
            this.lblDecToBin.Name = "lblDecToBin";
            this.lblDecToBin.Size = new System.Drawing.Size(131, 21);
            this.lblDecToBin.TabIndex = 1;
            this.lblDecToBin.Text = "Decimal a Binario";
            this.lblDecToBin.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBinario
            // 
            this.txtBinario.Location = new System.Drawing.Point(258, 23);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(100, 23);
            this.txtBinario.TabIndex = 2;
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(258, 100);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(100, 23);
            this.txtDecimal.TabIndex = 3;
            // 
            // txtResultadoBin
            // 
            this.txtResultadoBin.Location = new System.Drawing.Point(530, 100);
            this.txtResultadoBin.Name = "txtResultadoBin";
            this.txtResultadoBin.ReadOnly = true;
            this.txtResultadoBin.Size = new System.Drawing.Size(100, 23);
            this.txtResultadoBin.TabIndex = 4;
            this.txtResultadoBin.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtResultadoDec
            // 
            this.txtResultadoDec.Location = new System.Drawing.Point(530, 23);
            this.txtResultadoDec.Name = "txtResultadoDec";
            this.txtResultadoDec.ReadOnly = true;
            this.txtResultadoDec.Size = new System.Drawing.Size(100, 23);
            this.txtResultadoDec.TabIndex = 5;
            // 
            // btnBinToDec
            // 
            this.btnBinToDec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBinToDec.BackgroundImage")));
            this.btnBinToDec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBinToDec.Location = new System.Drawing.Point(406, 24);
            this.btnBinToDec.Name = "btnBinToDec";
            this.btnBinToDec.Size = new System.Drawing.Size(94, 23);
            this.btnBinToDec.TabIndex = 6;
            this.btnBinToDec.UseVisualStyleBackColor = true;
            this.btnBinToDec.Click += new System.EventHandler(this.btnBinToDec_Click);
            // 
            // btnDecToBin
            // 
            this.btnDecToBin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDecToBin.BackgroundImage")));
            this.btnDecToBin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDecToBin.Location = new System.Drawing.Point(406, 99);
            this.btnDecToBin.Name = "btnDecToBin";
            this.btnDecToBin.Size = new System.Drawing.Size(94, 23);
            this.btnDecToBin.TabIndex = 7;
            this.btnDecToBin.UseVisualStyleBackColor = true;
            this.btnDecToBin.Click += new System.EventHandler(this.btnDecToBin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(686, 179);
            this.Controls.Add(this.btnDecToBin);
            this.Controls.Add(this.btnBinToDec);
            this.Controls.Add(this.txtResultadoDec);
            this.Controls.Add(this.txtResultadoBin);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtBinario);
            this.Controls.Add(this.lblDecToBin);
            this.Controls.Add(this.lblBinToDec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor numerico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBinToDec;
        private System.Windows.Forms.Label lblDecToBin;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.TextBox txtResultadoBin;
        private System.Windows.Forms.TextBox txtResultadoDec;
        private System.Windows.Forms.Button btnBinToDec;
        private System.Windows.Forms.Button btnDecToBin;
    }
}

