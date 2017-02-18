namespace PrimerParcial_Apl1_Luis_Rodriguez.UI.Registro
{
    partial class FormRegistroEmpleado
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
            System.Windows.Forms.Label empleadoIdLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label fechaDeNacimentoLabel;
            System.Windows.Forms.Label sueldoLabel;
            this.empleadoIdTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.fechaDeNacimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sueldoTextBox = new System.Windows.Forms.TextBox();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NombreErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SueldoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.EliminarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.IderrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            empleadoIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            fechaDeNacimentoLabel = new System.Windows.Forms.Label();
            sueldoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NombreErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SueldoErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IderrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // empleadoIdLabel
            // 
            empleadoIdLabel.AutoSize = true;
            empleadoIdLabel.Location = new System.Drawing.Point(21, 46);
            empleadoIdLabel.Name = "empleadoIdLabel";
            empleadoIdLabel.Size = new System.Drawing.Size(69, 13);
            empleadoIdLabel.TabIndex = 1;
            empleadoIdLabel.Text = "Empleado Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(21, 72);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // fechaDeNacimentoLabel
            // 
            fechaDeNacimentoLabel.AutoSize = true;
            fechaDeNacimentoLabel.Location = new System.Drawing.Point(21, 99);
            fechaDeNacimentoLabel.Name = "fechaDeNacimentoLabel";
            fechaDeNacimentoLabel.Size = new System.Drawing.Size(111, 13);
            fechaDeNacimentoLabel.TabIndex = 5;
            fechaDeNacimentoLabel.Text = "Fecha De Nacimento:";
            // 
            // sueldoLabel
            // 
            sueldoLabel.AutoSize = true;
            sueldoLabel.Location = new System.Drawing.Point(21, 124);
            sueldoLabel.Name = "sueldoLabel";
            sueldoLabel.Size = new System.Drawing.Size(43, 13);
            sueldoLabel.TabIndex = 7;
            sueldoLabel.Text = "Sueldo:";
            // 
            // empleadoIdTextBox
            // 
            this.empleadoIdTextBox.Location = new System.Drawing.Point(138, 43);
            this.empleadoIdTextBox.Name = "empleadoIdTextBox";
            this.empleadoIdTextBox.Size = new System.Drawing.Size(103, 20);
            this.empleadoIdTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(138, 69);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // fechaDeNacimentoDateTimePicker
            // 
            this.fechaDeNacimentoDateTimePicker.Location = new System.Drawing.Point(138, 95);
            this.fechaDeNacimentoDateTimePicker.Name = "fechaDeNacimentoDateTimePicker";
            this.fechaDeNacimentoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDeNacimentoDateTimePicker.TabIndex = 6;
            // 
            // sueldoTextBox
            // 
            this.sueldoTextBox.Location = new System.Drawing.Point(138, 121);
            this.sueldoTextBox.Name = "sueldoTextBox";
            this.sueldoTextBox.Size = new System.Drawing.Size(200, 20);
            this.sueldoTextBox.TabIndex = 8;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(24, 174);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(84, 40);
            this.NuevoButton.TabIndex = 9;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(138, 174);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(103, 40);
            this.GuardarButton.TabIndex = 10;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NombreErrorProvider
            // 
            this.NombreErrorProvider.ContainerControl = this;
            // 
            // SueldoErrorProvider
            // 
            this.SueldoErrorProvider.ContainerControl = this;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(262, 174);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(94, 40);
            this.EliminarButton.TabIndex = 11;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(262, 40);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 13;
            this.BuscarButton.Text = "buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // IderrorProvider
            // 
            this.IderrorProvider.ContainerControl = this;
            // 
            // FormRegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 261);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(empleadoIdLabel);
            this.Controls.Add(this.empleadoIdTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(fechaDeNacimentoLabel);
            this.Controls.Add(this.fechaDeNacimentoDateTimePicker);
            this.Controls.Add(sueldoLabel);
            this.Controls.Add(this.sueldoTextBox);
            this.Name = "FormRegistroUsuario";
            this.Text = "FormRegistroUsuario";
            this.Load += new System.EventHandler(this.FormRegistroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NombreErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SueldoErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IderrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox empleadoIdTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.DateTimePicker fechaDeNacimentoDateTimePicker;
        private System.Windows.Forms.TextBox sueldoTextBox;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.ErrorProvider NombreErrorProvider;
        private System.Windows.Forms.ErrorProvider SueldoErrorProvider;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ErrorProvider IderrorProvider;
    }
}