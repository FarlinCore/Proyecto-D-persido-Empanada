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
            label1.Location = new Point(344, 302);
            label1.Name = "label1";
            label1.Size = new Size(105, 35);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(344, 385);
            label2.Name = "label2";
            label2.Size = new Size(147, 35);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(511, 306);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(176, 31);
            txtusuario.TabIndex = 2;
            txtusuario.TextChanged += textBox1_TextChanged;
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(511, 389);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.Size = new Size(176, 31);
            txtcontraseña.TabIndex = 4;
            // 
            // btningresar
            // 
            btningresar.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btningresar.ForeColor = Color.DarkRed;
            btningresar.Location = new Point(159, 500);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(176, 54);
            btningresar.TabIndex = 5;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = true;
            // 
            // btnregistrarse
            // 
            btnregistrarse.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnregistrarse.ForeColor = Color.DarkRed;
            btnregistrarse.Location = new Point(416, 500);
            btnregistrarse.Name = "btnregistrarse";
            btnregistrarse.Size = new Size(174, 54);
            btnregistrarse.TabIndex = 6;
            btnregistrarse.Text = "Registrarse";
            btnregistrarse.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            btnsalir.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalir.ForeColor = Color.DarkRed;
            btnsalir.Location = new Point(678, 500);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(174, 54);
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
            label3.Location = new Point(393, 189);
            label3.Name = "label3";
            label3.Size = new Size(220, 39);
            label3.TabIndex = 8;
            label3.Text = "Inicio de sesión";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1350, 768);
            Controls.Add(label3);
            Controls.Add(btnsalir);
            Controls.Add(btnregistrarse);
            Controls.Add(btningresar);
            Controls.Add(txtcontraseña);
            Controls.Add(txtusuario);
            Controls.Add(label2);
            Controls.Add(label1);
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
