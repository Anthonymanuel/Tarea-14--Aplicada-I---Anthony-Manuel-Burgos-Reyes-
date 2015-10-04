namespace RegistroPelicula
{
    partial class ConsultaForm
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
            this.PeliculaIdTextBox = new System.Windows.Forms.TextBox();
            this.MostrarDataGridView = new System.Windows.Forms.DataGridView();
            this.ListarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pelicula ID";
            // 
            // PeliculaIdTextBox
            // 
            this.PeliculaIdTextBox.Location = new System.Drawing.Point(111, 62);
            this.PeliculaIdTextBox.Name = "PeliculaIdTextBox";
            this.PeliculaIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.PeliculaIdTextBox.TabIndex = 1;
            // 
            // MostrarDataGridView
            // 
            this.MostrarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MostrarDataGridView.Location = new System.Drawing.Point(12, 138);
            this.MostrarDataGridView.Name = "MostrarDataGridView";
            this.MostrarDataGridView.ReadOnly = true;
            this.MostrarDataGridView.Size = new System.Drawing.Size(637, 111);
            this.MostrarDataGridView.TabIndex = 2;
            // 
            // ListarButton
            // 
            this.ListarButton.Image = global::RegistroPelicula.Properties.Resources._1443950596_show_property;
            this.ListarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ListarButton.Location = new System.Drawing.Point(39, 99);
            this.ListarButton.Name = "ListarButton";
            this.ListarButton.Size = new System.Drawing.Size(75, 33);
            this.ListarButton.TabIndex = 5;
            this.ListarButton.Text = "Listar";
            this.ListarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ListarButton.UseVisualStyleBackColor = true;
            this.ListarButton.Click += new System.EventHandler(this.ListarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::RegistroPelicula.Properties.Resources._1443950518_Remove;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(202, 99);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 33);
            this.EliminarButton.TabIndex = 4;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::RegistroPelicula.Properties.Resources._1443950301_adsense_for_search;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(120, 99);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 33);
            this.BuscarButton.TabIndex = 3;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.MostrarButton_Click);
            // 
            // ConsultaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RegistroPelicula.Properties.Resources.rollo_de_pelicula;
            this.ClientSize = new System.Drawing.Size(663, 271);
            this.Controls.Add(this.ListarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.MostrarDataGridView);
            this.Controls.Add(this.PeliculaIdTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaForm";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.MostrarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PeliculaIdTextBox;
        private System.Windows.Forms.DataGridView MostrarDataGridView;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button ListarButton;
    }
}