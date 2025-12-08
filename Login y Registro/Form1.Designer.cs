namespace Login_y_Registro
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
            label1 = new Label();
            label2 = new Label();
            txtusuario = new TextBox();
            txtcontraseña = new TextBox();
            btningresar = new Button();
            btnregistrarse = new Button();
            btnsalir = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(263, 295);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 29);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(228, 368);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 29);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(409, 298);
            txtusuario.Margin = new Padding(2, 2, 2, 2);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(188, 27);
            txtusuario.TabIndex = 2;
            txtusuario.TextChanged += textBox1_TextChanged;
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(409, 368);
            txtcontraseña.Margin = new Padding(2, 2, 2, 2);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.Size = new Size(188, 27);
            txtcontraseña.TabIndex = 4;
            // 
            // btningresar
            // 
            btningresar.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btningresar.ForeColor = Color.DarkRed;
            btningresar.Location = new Point(194, 506);
            btningresar.Margin = new Padding(2, 2, 2, 2);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(141, 43);
            btningresar.TabIndex = 5;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = true;
            // 
            // btnregistrarse
            // 
            btnregistrarse.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnregistrarse.ForeColor = Color.DarkRed;
            btnregistrarse.Location = new Point(443, 506);
            btnregistrarse.Margin = new Padding(2, 2, 2, 2);
            btnregistrarse.Name = "btnregistrarse";
            btnregistrarse.Size = new Size(139, 43);
            btnregistrarse.TabIndex = 6;
            btnregistrarse.Text = "Registrarse";
            btnregistrarse.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            btnsalir.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalir.ForeColor = Color.DarkRed;
            btnsalir.Location = new Point(706, 506);
            btnsalir.Margin = new Padding(2, 2, 2, 2);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(139, 43);
            btnsalir.TabIndex = 7;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(409, 186);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(188, 33);
            label3.TabIndex = 8;
            label3.Text = "Inicio de sesión";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1080, 699);
            Controls.Add(label3);
            Controls.Add(btnsalir);
            Controls.Add(btnregistrarse);
            Controls.Add(btningresar);
            Controls.Add(txtcontraseña);
            Controls.Add(txtusuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtusuario;
        private TextBox txtcontraseña;
        private Button btningresar;
        private Button btnregistrarse;
        private Button btnsalir;
        private Label label3;
    }
}
