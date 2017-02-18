namespace PrimerParcial_Apl1_Luis_Rodriguez.UI.Consulta
{
    partial class FormConsultaEmpleado
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
            this.components = new System.ComponentModel.Container();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NombreCheckBox = new System.Windows.Forms.CheckBox();
            this.FechaCheckBox = new System.Windows.Forms.CheckBox();
            this.FiltrarCheckBox = new System.Windows.Forms.CheckBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(304, 39);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(78, 20);
            this.HastaDateTimePicker.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NombreCheckBox);
            this.groupBox1.Controls.Add(this.FechaCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(66, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 69);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // NombreCheckBox
            // 
            this.NombreCheckBox.AutoSize = true;
            this.NombreCheckBox.Location = new System.Drawing.Point(69, 20);
            this.NombreCheckBox.Name = "NombreCheckBox";
            this.NombreCheckBox.Size = new System.Drawing.Size(63, 17);
            this.NombreCheckBox.TabIndex = 1;
            this.NombreCheckBox.Text = "Nombre";
            this.NombreCheckBox.UseVisualStyleBackColor = true;
            // 
            // FechaCheckBox
            // 
            this.FechaCheckBox.AutoSize = true;
            this.FechaCheckBox.Location = new System.Drawing.Point(0, 20);
            this.FechaCheckBox.Name = "FechaCheckBox";
            this.FechaCheckBox.Size = new System.Drawing.Size(56, 17);
            this.FechaCheckBox.TabIndex = 0;
            this.FechaCheckBox.Text = "Fecha";
            this.FechaCheckBox.UseVisualStyleBackColor = true;
            // 
            // FiltrarCheckBox
            // 
            this.FiltrarCheckBox.AutoSize = true;
            this.FiltrarCheckBox.Location = new System.Drawing.Point(66, 44);
            this.FiltrarCheckBox.Name = "FiltrarCheckBox";
            this.FiltrarCheckBox.Size = new System.Drawing.Size(51, 17);
            this.FiltrarCheckBox.TabIndex = 11;
            this.FiltrarCheckBox.Text = "Filtrar";
            this.FiltrarCheckBox.UseVisualStyleBackColor = true;
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(66, 162);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(440, 209);
            this.DataGridView.TabIndex = 10;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick_1);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(460, 10);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 9;
            this.BuscarButton.Text = "buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click_1);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(66, 12);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(377, 20);
            this.SearchTextBox.TabIndex = 8;
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(304, 84);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(78, 20);
            this.DesdeDateTimePicker.TabIndex = 7;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // FormConsultaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 397);
            this.Controls.Add(this.HastaDateTimePicker);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FiltrarCheckBox);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.DesdeDateTimePicker);
            this.Name = "FormConsultaEmpleado";
            this.Text = "FormConsultaEmpleado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox NombreCheckBox;
        private System.Windows.Forms.CheckBox FechaCheckBox;
        private System.Windows.Forms.CheckBox FiltrarCheckBox;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}