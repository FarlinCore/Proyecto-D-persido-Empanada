namespace Login_y_Registro
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnatras = new Button();
            btnregistrar = new Button();
            txtnombreapellido = new TextBox();
            txtnombredeusuario = new TextBox();
            txtdecontraseña = new TextBox();
            txtconfimecontraseña = new TextBox();
            txtocupacion = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(448, 153);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 39);
            label1.TabIndex = 0;
            label1.Text = "Registro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(251, 233);
            label2.Name = "label2";
            label2.Size = new Size(232, 35);
            label2.TabIndex = 1;
            label2.Text = "Nombre y Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(251, 294);
            label3.Name = "label3";
            label3.Size = new Size(241, 35);
            label3.TabIndex = 2;
            label3.Text = "Nombre de Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(251, 353);
            label4.Name = "label4";
            label4.Size = new Size(147, 35);
            label4.TabIndex = 3;
            label4.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(251, 411);
            label5.Name = "label5";
            label5.Size = new Size(290, 35);
            label5.TabIndex = 4;
            label5.Text = "Confirme su contraseña";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(251, 467);
            label6.Name = "label6";
            label6.Size = new Size(145, 35);
            label6.TabIndex = 5;
            label6.Text = "Ocupacion ";
            // 
            // btnatras
            // 
            btnatras.ForeColor = Color.DarkRed;
            btnatras.Location = new Point(179, 585);
            btnatras.Name = "btnatras";
            btnatras.Size = new Size(118, 47);
            btnatras.TabIndex = 6;
            btnatras.Text = "Atrás";
            btnatras.UseVisualStyleBackColor = true;
            btnatras.Click += btnatras_Click;
            // 
            // btnregistrar
            // 
            btnregistrar.ForeColor = Color.DarkRed;
            btnregistrar.Location = new Point(705, 587);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(150, 45);
            btnregistrar.TabIndex = 7;
            btnregistrar.Text = "Registrar";
            btnregistrar.UseVisualStyleBackColor = true;
            // 
            // txtnombreapellido
            // 
            txtnombreapellido.Location = new Point(547, 226);
            txtnombreapellido.Name = "txtnombreapellido";
            txtnombreapellido.Size = new Size(265, 42);
            txtnombreapellido.TabIndex = 8;
            // 
            // txtnombredeusuario
            // 
            txtnombredeusuario.Location = new Point(547, 287);
            txtnombredeusuario.Name = "txtnombredeusuario";
            txtnombredeusuario.Size = new Size(265, 42);
            txtnombredeusuario.TabIndex = 9;
            // 
            // txtdecontraseña
            // 
            txtdecontraseña.Location = new Point(547, 346);
            txtdecontraseña.Name = "txtdecontraseña";
            txtdecontraseña.Size = new Size(265, 42);
            txtdecontraseña.TabIndex = 10;
            // 
            // txtconfimecontraseña
            // 
            txtconfimecontraseña.Location = new Point(547, 404);
            txtconfimecontraseña.Name = "txtconfimecontraseña";
            txtconfimecontraseña.Size = new Size(265, 42);
            txtconfimecontraseña.TabIndex = 11;
            // 
            // txtocupacion
            // 
            txtocupacion.Location = new Point(547, 460);
            txtocupacion.Name = "txtocupacion";
            txtocupacion.Size = new Size(265, 42);
            txtocupacion.TabIndex = 12;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1355, 764);
            Controls.Add(txtocupacion);
            Controls.Add(txtconfimecontraseña);
            Controls.Add(txtdecontraseña);
            Controls.Add(txtnombredeusuario);
            Controls.Add(txtnombreapellido);
            Controls.Add(btnregistrar);
            Controls.Add(btnatras);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnatras;
        private Button btnregistrar;
        private TextBox txtnombreapellido;
        private TextBox txtnombredeusuario;
        private TextBox txtdecontraseña;
        private TextBox txtconfimecontraseña;
        private TextBox txtocupacion;
    }
}