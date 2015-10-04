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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TituloTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.AnoTextBox = new System.Windows.Forms.TextBox();
            this.IMDBTextBox = new System.Windows.Forms.TextBox();
            this.CategoriaIdTexBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CalificacionTextBox = new System.Windows.Forms.TextBox();
            this.RegistrarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ano";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "IMDB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoria ID";
            // 
            // TituloTextBox
            // 
            this.TituloTextBox.Location = new System.Drawing.Point(258, 29);
            this.TituloTextBox.Name = "TituloTextBox";
            this.TituloTextBox.Size = new System.Drawing.Size(100, 20);
            this.TituloTextBox.TabIndex = 0;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(258, 62);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(100, 20);
            this.DescripcionTextBox.TabIndex = 1;
            // 
            // AnoTextBox
            // 
            this.AnoTextBox.Location = new System.Drawing.Point(258, 92);
            this.AnoTextBox.Name = "AnoTextBox";
            this.AnoTextBox.Size = new System.Drawing.Size(100, 20);
            this.AnoTextBox.TabIndex = 2;
            // 
            // IMDBTextBox
            // 
            this.IMDBTextBox.Location = new System.Drawing.Point(258, 151);
            this.IMDBTextBox.Name = "IMDBTextBox";
            this.IMDBTextBox.Size = new System.Drawing.Size(100, 20);
            this.IMDBTextBox.TabIndex = 4;
            // 
            // CategoriaIdTexBox
            // 
            this.CategoriaIdTexBox.Location = new System.Drawing.Point(258, 185);
            this.CategoriaIdTexBox.Name = "CategoriaIdTexBox";
            this.CategoriaIdTexBox.Size = new System.Drawing.Size(100, 20);
            this.CategoriaIdTexBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Calificacion";
            // 
            // CalificacionTextBox
            // 
            this.CalificacionTextBox.Location = new System.Drawing.Point(258, 121);
            this.CalificacionTextBox.Name = "CalificacionTextBox";
            this.CalificacionTextBox.Size = new System.Drawing.Size(100, 20);
            this.CalificacionTextBox.TabIndex = 3;
            // 
            // RegistrarButton
            // 
            this.RegistrarButton.Image = global::RegistroPelicula.Properties.Resources._1443948365_list_add_user;
            this.RegistrarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegistrarButton.Location = new System.Drawing.Point(258, 224);
            this.RegistrarButton.Name = "RegistrarButton";
            this.RegistrarButton.Size = new System.Drawing.Size(100, 35);
            this.RegistrarButton.TabIndex = 6;
            this.RegistrarButton.Text = "Registrar";
            this.RegistrarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegistrarButton.UseVisualStyleBackColor = true;
            this.RegistrarButton.Click += new System.EventHandler(this.RegistrarButton_Click);
            // 
            // RegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::RegistroPelicula.Properties.Resources.result;
            this.ClientSize = new System.Drawing.Size(587, 278);
            this.Controls.Add(this.CalificacionTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RegistrarButton);
            this.Controls.Add(this.CategoriaIdTexBox);
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
        private System.Windows.Forms.TextBox CategoriaIdTexBox;
        private System.Windows.Forms.Button RegistrarButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CalificacionTextBox;
    }
}