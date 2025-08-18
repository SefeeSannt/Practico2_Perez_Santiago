namespace TallerDeProgramacion2.Práctico_2
{
    partial class Pequeño_Formulario
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
            LNya = new Label();
            Lmodificar = new Label();
            LNombre = new Label();
            LDni = new Label();
            LApellido = new Label();
            TDni = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            TGuardar = new Button();
            TEleminar = new Button();
            SuspendLayout();
            // 
            // LNya
            // 
            LNya.AutoSize = true;
            LNya.Location = new Point(12, 9);
            LNya.Name = "LNya";
            LNya.Size = new Size(110, 15);
            LNya.TabIndex = 0;
            LNya.Text = "Nombre y Apellido:";
            // 
            // Lmodificar
            // 
            Lmodificar.AutoSize = true;
            Lmodificar.ForeColor = Color.Red;
            Lmodificar.Location = new Point(161, 9);
            Lmodificar.Name = "Lmodificar";
            Lmodificar.Size = new Size(58, 15);
            Lmodificar.TabIndex = 1;
            Lmodificar.Text = "modificar";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(12, 105);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 2;
            LNombre.Text = "Nombre";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(12, 47);
            LDni.Name = "LDni";
            LDni.Size = new Size(27, 15);
            LDni.TabIndex = 3;
            LDni.Text = "DNI";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(12, 76);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 4;
            LApellido.Text = "Apellido";
            // 
            // TDni
            // 
            TDni.Location = new Point(161, 44);
            TDni.Name = "TDni";
            TDni.Size = new Size(100, 23);
            TDni.TabIndex = 5;
            TDni.TextChanged += TDni_TextChanged;
            TDni.KeyPress += onlyDigits_KeyPress;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(161, 73);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(100, 23);
            TApellido.TabIndex = 6;
            TApellido.KeyPress += onlyLetters_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(161, 102);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 10;
            TNombre.KeyPress += onlyLetters_KeyPress;
            // 
            // TGuardar
            // 
            TGuardar.Location = new Point(12, 165);
            TGuardar.Name = "TGuardar";
            TGuardar.Size = new Size(75, 23);
            TGuardar.TabIndex = 8;
            TGuardar.Text = "Guardar";
            TGuardar.UseVisualStyleBackColor = true;
            TGuardar.Click += button1_Click;
            // 
            // TEleminar
            // 
            TEleminar.Location = new Point(93, 165);
            TEleminar.Name = "TEleminar";
            TEleminar.Size = new Size(75, 23);
            TEleminar.TabIndex = 9;
            TEleminar.Text = "Eliminar";
            TEleminar.UseVisualStyleBackColor = true;
            TEleminar.Click += TEleminar_Click;
            // 
            // Pequeño_Formulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 200);
            Controls.Add(TEleminar);
            Controls.Add(TGuardar);
            Controls.Add(TNombre);
            Controls.Add(TApellido);
            Controls.Add(TDni);
            Controls.Add(LApellido);
            Controls.Add(LDni);
            Controls.Add(LNombre);
            Controls.Add(Lmodificar);
            Controls.Add(LNya);
            Name = "Pequeño_Formulario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pequeño_Formulario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNya;
        private Label Lmodificar;
        private Label LNombre;
        private Label LDni;
        private Label LApellido;
        private TextBox TDni;
        private TextBox TApellido;
        private TextBox TNombre;
        private Button TGuardar;
        private Button TEleminar;
    }
}