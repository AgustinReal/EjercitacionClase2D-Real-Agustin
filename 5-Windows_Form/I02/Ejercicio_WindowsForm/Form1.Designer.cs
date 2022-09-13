
namespace Ejercicio_WindowsForm
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
            this.grpUsuario = new System.Windows.Forms.GroupBox();
            this.edadNumeric = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.rdbNoBinario = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.grpCursos = new System.Windows.Forms.GroupBox();
            this.checkBoxCMasMas = new System.Windows.Forms.CheckBox();
            this.checkBoxJavaScript = new System.Windows.Forms.CheckBox();
            this.checkBoxCsharp = new System.Windows.Forms.CheckBox();
            this.Pais = new System.Windows.Forms.ListBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.grpUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edadNumeric)).BeginInit();
            this.grpGenero.SuspendLayout();
            this.grpCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUsuario
            // 
            this.grpUsuario.Controls.Add(this.edadNumeric);
            this.grpUsuario.Controls.Add(this.txtDireccion);
            this.grpUsuario.Controls.Add(this.txtNombre);
            this.grpUsuario.Controls.Add(this.lblEdad);
            this.grpUsuario.Controls.Add(this.lblDireccion);
            this.grpUsuario.Controls.Add(this.lblNombre);
            this.grpUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpUsuario.Location = new System.Drawing.Point(48, 47);
            this.grpUsuario.Name = "grpUsuario";
            this.grpUsuario.Size = new System.Drawing.Size(285, 164);
            this.grpUsuario.TabIndex = 0;
            this.grpUsuario.TabStop = false;
            this.grpUsuario.Text = "Detalles del usuario";
            // 
            // edadNumeric
            // 
            this.edadNumeric.Location = new System.Drawing.Point(123, 120);
            this.edadNumeric.Name = "edadNumeric";
            this.edadNumeric.Size = new System.Drawing.Size(141, 29);
            this.edadNumeric.TabIndex = 5;
            this.edadNumeric.ValueChanged += new System.EventHandler(this.edad_ValueChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(123, 68);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(141, 29);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(141, 29);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEdad.Location = new System.Drawing.Point(25, 120);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(48, 21);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDireccion.Location = new System.Drawing.Point(25, 76);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(83, 21);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(25, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 21);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.rdbNoBinario);
            this.grpGenero.Controls.Add(this.rdbFemenino);
            this.grpGenero.Controls.Add(this.rdbMasculino);
            this.grpGenero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpGenero.Location = new System.Drawing.Point(377, 38);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(201, 158);
            this.grpGenero.TabIndex = 1;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Genero";
            // 
            // rdbNoBinario
            // 
            this.rdbNoBinario.AutoSize = true;
            this.rdbNoBinario.Location = new System.Drawing.Point(31, 105);
            this.rdbNoBinario.Name = "rdbNoBinario";
            this.rdbNoBinario.Size = new System.Drawing.Size(110, 25);
            this.rdbNoBinario.TabIndex = 2;
            this.rdbNoBinario.TabStop = true;
            this.rdbNoBinario.Text = "No binario";
            this.rdbNoBinario.UseVisualStyleBackColor = true;
            this.rdbNoBinario.CheckedChanged += new System.EventHandler(this.rdbNoBinario_CheckedChanged);
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(31, 65);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(104, 25);
            this.rdbFemenino.TabIndex = 1;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            this.rdbFemenino.CheckedChanged += new System.EventHandler(this.rdbFemenino_CheckedChanged);
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(31, 27);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(107, 25);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            this.rdbMasculino.CheckedChanged += new System.EventHandler(this.rdbMasculino_CheckedChanged);
            // 
            // grpCursos
            // 
            this.grpCursos.Controls.Add(this.checkBoxCMasMas);
            this.grpCursos.Controls.Add(this.checkBoxJavaScript);
            this.grpCursos.Controls.Add(this.checkBoxCsharp);
            this.grpCursos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpCursos.Location = new System.Drawing.Point(378, 235);
            this.grpCursos.Name = "grpCursos";
            this.grpCursos.Size = new System.Drawing.Size(200, 133);
            this.grpCursos.TabIndex = 2;
            this.grpCursos.TabStop = false;
            this.grpCursos.Text = "Cursos";
            // 
            // checkBoxCMasMas
            // 
            this.checkBoxCMasMas.AutoSize = true;
            this.checkBoxCMasMas.Location = new System.Drawing.Point(23, 57);
            this.checkBoxCMasMas.Name = "checkBoxCMasMas";
            this.checkBoxCMasMas.Size = new System.Drawing.Size(61, 25);
            this.checkBoxCMasMas.TabIndex = 2;
            this.checkBoxCMasMas.Text = "C++";
            this.checkBoxCMasMas.UseVisualStyleBackColor = true;
            this.checkBoxCMasMas.CheckedChanged += new System.EventHandler(this.checkBoxCMasMas_CheckedChanged);
            // 
            // checkBoxJavaScript
            // 
            this.checkBoxJavaScript.AutoSize = true;
            this.checkBoxJavaScript.Location = new System.Drawing.Point(23, 83);
            this.checkBoxJavaScript.Name = "checkBoxJavaScript";
            this.checkBoxJavaScript.Size = new System.Drawing.Size(107, 25);
            this.checkBoxJavaScript.TabIndex = 1;
            this.checkBoxJavaScript.Text = "JavaScript";
            this.checkBoxJavaScript.UseVisualStyleBackColor = true;
            this.checkBoxJavaScript.CheckedChanged += new System.EventHandler(this.checkBoxJavaScript_CheckedChanged);
            // 
            // checkBoxCsharp
            // 
            this.checkBoxCsharp.AutoSize = true;
            this.checkBoxCsharp.Location = new System.Drawing.Point(23, 31);
            this.checkBoxCsharp.Name = "checkBoxCsharp";
            this.checkBoxCsharp.Size = new System.Drawing.Size(48, 25);
            this.checkBoxCsharp.TabIndex = 0;
            this.checkBoxCsharp.Text = "C#";
            this.checkBoxCsharp.UseVisualStyleBackColor = true;
            this.checkBoxCsharp.CheckedChanged += new System.EventHandler(this.checkBoxCsharp_CheckedChanged);
            // 
            // Pais
            // 
            this.Pais.FormattingEnabled = true;
            this.Pais.ItemHeight = 15;
            this.Pais.Location = new System.Drawing.Point(48, 242);
            this.Pais.Name = "Pais";
            this.Pais.Size = new System.Drawing.Size(285, 94);
            this.Pais.TabIndex = 3;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonIngresar.Location = new System.Drawing.Point(401, 391);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(125, 34);
            this.buttonIngresar.TabIndex = 4;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.Pais);
            this.Controls.Add(this.grpCursos);
            this.Controls.Add(this.grpGenero);
            this.Controls.Add(this.grpUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpUsuario.ResumeLayout(false);
            this.grpUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edadNumeric)).EndInit();
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.grpCursos.ResumeLayout(false);
            this.grpCursos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUsuario;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbNoBinario;
        private System.Windows.Forms.GroupBox grpCursos;
        private System.Windows.Forms.CheckBox checkBoxCMasMas;
        private System.Windows.Forms.CheckBox checkBoxJavaScript;
        private System.Windows.Forms.CheckBox checkBoxCsharp;
        private System.Windows.Forms.ListBox Pais;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.NumericUpDown edadNumeric;
    }
}

