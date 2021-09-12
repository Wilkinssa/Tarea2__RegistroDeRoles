
namespace Tarea2_RegistroDeRoles
{
    partial class RegistroRolesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroRolesForm));
            this.RolesIdTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.FechaCreacionDateTimeP = new System.Windows.Forms.DateTimePicker();
            this.RolesIdLabel = new System.Windows.Forms.Label();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.FechaCreacionLabel = new System.Windows.Forms.Label();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.EditarButton = new System.Windows.Forms.Button();
            this.ConsultaRolesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaRolesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RolesIdTextBox
            // 
            this.RolesIdTextBox.Location = new System.Drawing.Point(164, 63);
            this.RolesIdTextBox.Multiline = true;
            this.RolesIdTextBox.Name = "RolesIdTextBox";
            this.RolesIdTextBox.Size = new System.Drawing.Size(136, 21);
            this.RolesIdTextBox.TabIndex = 0;
            this.RolesIdTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(164, 96);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(190, 20);
            this.DescripcionTextBox.TabIndex = 1;
            this.DescripcionTextBox.TextChanged += new System.EventHandler(this.NombreTextBox_TextChanged);
            // 
            // FechaCreacionDateTimeP
            // 
            this.FechaCreacionDateTimeP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaCreacionDateTimeP.Location = new System.Drawing.Point(164, 128);
            this.FechaCreacionDateTimeP.Name = "FechaCreacionDateTimeP";
            this.FechaCreacionDateTimeP.Size = new System.Drawing.Size(95, 23);
            this.FechaCreacionDateTimeP.TabIndex = 2;
            this.FechaCreacionDateTimeP.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // RolesIdLabel
            // 
            this.RolesIdLabel.AutoSize = true;
            this.RolesIdLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RolesIdLabel.Location = new System.Drawing.Point(125, 62);
            this.RolesIdLabel.Name = "RolesIdLabel";
            this.RolesIdLabel.Size = new System.Drawing.Size(24, 20);
            this.RolesIdLabel.TabIndex = 3;
            this.RolesIdLabel.Text = "ID";
            this.RolesIdLabel.Click += new System.EventHandler(this.RolesIdLabel_Click);
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescripcionLabel.Location = new System.Drawing.Point(59, 96);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DescripcionLabel.Size = new System.Drawing.Size(87, 20);
            this.DescripcionLabel.TabIndex = 4;
            this.DescripcionLabel.Text = "Descripción";
            // 
            // FechaCreacionLabel
            // 
            this.FechaCreacionLabel.AutoSize = true;
            this.FechaCreacionLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FechaCreacionLabel.Location = new System.Drawing.Point(17, 128);
            this.FechaCreacionLabel.Name = "FechaCreacionLabel";
            this.FechaCreacionLabel.Size = new System.Drawing.Size(132, 20);
            this.FechaCreacionLabel.TabIndex = 5;
            this.FechaCreacionLabel.Text = "Fecha De Creación";
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(38, 178);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(77, 44);
            this.GuardarButton.TabIndex = 6;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(136, 178);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(77, 44);
            this.EliminarButton.TabIndex = 7;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // EditarButton
            // 
            this.EditarButton.Image = ((System.Drawing.Image)(resources.GetObject("EditarButton.Image")));
            this.EditarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EditarButton.Location = new System.Drawing.Point(230, 178);
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(77, 44);
            this.EditarButton.TabIndex = 8;
            this.EditarButton.Text = "Editar";
            this.EditarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EditarButton.UseVisualStyleBackColor = true;
            this.EditarButton.Click += new System.EventHandler(this.EditarButton_Click);
            // 
            // ConsultaRolesDataGridView
            // 
            this.ConsultaRolesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaRolesDataGridView.Location = new System.Drawing.Point(393, 24);
            this.ConsultaRolesDataGridView.Name = "ConsultaRolesDataGridView";
            this.ConsultaRolesDataGridView.RowTemplate.Height = 25;
            this.ConsultaRolesDataGridView.Size = new System.Drawing.Size(429, 282);
            this.ConsultaRolesDataGridView.TabIndex = 9;
            this.ConsultaRolesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RegistroRolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 350);
            this.Controls.Add(this.ConsultaRolesDataGridView);
            this.Controls.Add(this.EditarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.FechaCreacionLabel);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.RolesIdLabel);
            this.Controls.Add(this.FechaCreacionDateTimeP);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.RolesIdTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroRolesForm";
            this.Text = "Registro De Roles";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaRolesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RolesIdTextBox;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.DateTimePicker FechaCreacionDateTimeP;
        private System.Windows.Forms.Label RolesIdLabel;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.Label FechaCreacionLabel;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button EditarButton;
        private System.Windows.Forms.DataGridView ConsultaRolesDataGridView;
    }
}

