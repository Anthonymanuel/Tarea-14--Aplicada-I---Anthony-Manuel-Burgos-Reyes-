namespace RegistroPelicula
{
    partial class RegistroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TituloTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.AnoTextBox = new System.Windows.Forms.TextBox();
            this.IMDBTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CalificacionTextBox = new System.Windows.Forms.TextBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.PeliculaIdTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SeleccionarButton = new System.Windows.Forms.Button();
            this.FotoPictureBox = new System.Windows.Forms.PictureBox();
            this.ReproductorAxWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.SeleccionarVideoButton = new System.Windows.Forms.Button();
            this.PeliculaGroupBox = new System.Windows.Forms.GroupBox();
            this.CategoriaIdComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReproductorAxWindowsMediaPlayer1)).BeginInit();
            this.PeliculaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ano";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "IMDB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoria ID";
            // 
            // TituloTextBox
            // 
            this.TituloTextBox.Location = new System.Drawing.Point(126, 35);
            this.TituloTextBox.Name = "TituloTextBox";
            this.TituloTextBox.Size = new System.Drawing.Size(100, 20);
            this.TituloTextBox.TabIndex = 1;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(126, 68);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(100, 20);
            this.DescripcionTextBox.TabIndex = 2;
            // 
            // AnoTextBox
            // 
            this.AnoTextBox.Location = new System.Drawing.Point(126, 98);
            this.AnoTextBox.Name = "AnoTextBox";
            this.AnoTextBox.Size = new System.Drawing.Size(100, 20);
            this.AnoTextBox.TabIndex = 3;
            // 
            // IMDBTextBox
            // 
            this.IMDBTextBox.Location = new System.Drawing.Point(126, 157);
            this.IMDBTextBox.Name = "IMDBTextBox";
            this.IMDBTextBox.Size = new System.Drawing.Size(100, 20);
            this.IMDBTextBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Calificacion";
            // 
            // CalificacionTextBox
            // 
            this.CalificacionTextBox.Location = new System.Drawing.Point(126, 127);
            this.CalificacionTextBox.Name = "CalificacionTextBox";
            this.CalificacionTextBox.Size = new System.Drawing.Size(100, 20);
            this.CalificacionTextBox.TabIndex = 4;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::RegistroPelicula.Properties.Resources._1443950518_Remove;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(211, 229);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(79, 33);
            this.EliminarButton.TabIndex = 9;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::RegistroPelicula.Properties.Resources._1444509101_document_new;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(42, 229);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 33);
            this.NuevoButton.TabIndex = 7;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::RegistroPelicula.Properties.Resources._1444509221_Save_as;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(123, 229);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(82, 33);
            this.GuardarButton.TabIndex = 8;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Pelicula ID";
            // 
            // PeliculaIdTextBox
            // 
            this.PeliculaIdTextBox.Location = new System.Drawing.Point(126, 6);
            this.PeliculaIdTextBox.Name = "PeliculaIdTextBox";
            this.PeliculaIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.PeliculaIdTextBox.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Imagen";
            // 
            // SeleccionarButton
            // 
            this.SeleccionarButton.Location = new System.Drawing.Point(296, 184);
            this.SeleccionarButton.Name = "SeleccionarButton";
            this.SeleccionarButton.Size = new System.Drawing.Size(75, 23);
            this.SeleccionarButton.TabIndex = 14;
            this.SeleccionarButton.Text = "Seleccionar";
            this.SeleccionarButton.UseVisualStyleBackColor = true;
            this.SeleccionarButton.Click += new System.EventHandler(this.SeleccionarButton_Click);
            // 
            // FotoPictureBox
            // 
            this.FotoPictureBox.Location = new System.Drawing.Point(296, 12);
            this.FotoPictureBox.Name = "FotoPictureBox";
            this.FotoPictureBox.Size = new System.Drawing.Size(145, 165);
            this.FotoPictureBox.TabIndex = 15;
            this.FotoPictureBox.TabStop = false;
            // 
            // ReproductorAxWindowsMediaPlayer1
            // 
            this.ReproductorAxWindowsMediaPlayer1.Enabled = true;
            this.ReproductorAxWindowsMediaPlayer1.Location = new System.Drawing.Point(7, 19);
            this.ReproductorAxWindowsMediaPlayer1.Name = "ReproductorAxWindowsMediaPlayer1";
            this.ReproductorAxWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ReproductorAxWindowsMediaPlayer1.OcxState")));
            this.ReproductorAxWindowsMediaPlayer1.Size = new System.Drawing.Size(279, 132);
            this.ReproductorAxWindowsMediaPlayer1.TabIndex = 16;
            // 
            // SeleccionarVideoButton
            // 
            this.SeleccionarVideoButton.Location = new System.Drawing.Point(447, 184);
            this.SeleccionarVideoButton.Name = "SeleccionarVideoButton";
            this.SeleccionarVideoButton.Size = new System.Drawing.Size(75, 23);
            this.SeleccionarVideoButton.TabIndex = 17;
            this.SeleccionarVideoButton.Text = "Seleccionar";
            this.SeleccionarVideoButton.UseVisualStyleBackColor = true;
            this.SeleccionarVideoButton.Click += new System.EventHandler(this.SeleccionarVideoButton_Click);
            // 
            // PeliculaGroupBox
            // 
            this.PeliculaGroupBox.Controls.Add(this.ReproductorAxWindowsMediaPlayer1);
            this.PeliculaGroupBox.Location = new System.Drawing.Point(447, 18);
            this.PeliculaGroupBox.Name = "PeliculaGroupBox";
            this.PeliculaGroupBox.Size = new System.Drawing.Size(292, 159);
            this.PeliculaGroupBox.TabIndex = 18;
            this.PeliculaGroupBox.TabStop = false;
            this.PeliculaGroupBox.Text = "Pelicula";
            // 
            // CategoriaIdComboBox
            // 
            this.CategoriaIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriaIdComboBox.FormattingEnabled = true;
            this.CategoriaIdComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CategoriaIdComboBox.Location = new System.Drawing.Point(126, 191);
            this.CategoriaIdComboBox.Name = "CategoriaIdComboBox";
            this.CategoriaIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoriaIdComboBox.TabIndex = 19;
            // 
            // RegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::RegistroPelicula.Properties.Resources.result;
            this.ClientSize = new System.Drawing.Size(772, 278);
            this.Controls.Add(this.CategoriaIdComboBox);
            this.Controls.Add(this.PeliculaGroupBox);
            this.Controls.Add(this.SeleccionarVideoButton);
            this.Controls.Add(this.FotoPictureBox);
            this.Controls.Add(this.SeleccionarButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PeliculaIdTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.CalificacionTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IMDBTextBox);
            this.Controls.Add(this.AnoTextBox);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.TituloTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroForm";
            this.Text = "Registrar";
            ((System.ComponentModel.ISupportInitialize)(this.FotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReproductorAxWindowsMediaPlayer1)).EndInit();
            this.PeliculaGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TituloTextBox;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.TextBox AnoTextBox;
        private System.Windows.Forms.TextBox IMDBTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CalificacionTextBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PeliculaIdTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SeleccionarButton;
        private System.Windows.Forms.PictureBox FotoPictureBox;
        private AxWMPLib.AxWindowsMediaPlayer ReproductorAxWindowsMediaPlayer1;
        private System.Windows.Forms.Button SeleccionarVideoButton;
        private System.Windows.Forms.GroupBox PeliculaGroupBox;
        private System.Windows.Forms.ComboBox CategoriaIdComboBox;
    }
}