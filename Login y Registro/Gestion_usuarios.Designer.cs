namespace Login_y_Registro
{
    partial class Gestion_usuarios
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
            groupBox1 = new GroupBox();
            dataGridDb = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button5 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDb).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(dataGridDb);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(192, 64, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(585, 407);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuarios";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dataGridDb
            // 
            dataGridDb.BackgroundColor = Color.Gainsboro;
            dataGridDb.BorderStyle = BorderStyle.None;
            dataGridDb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDb.Location = new Point(16, 29);
            dataGridDb.Name = "dataGridDb";
            dataGridDb.RowHeadersWidth = 51;
            dataGridDb.Size = new Size(548, 349);
            dataGridDb.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(614, 28);
            button1.Name = "button1";
            button1.Size = new Size(211, 61);
            button1.TabIndex = 1;
            button1.Text = "Agregar Usuario";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(614, 324);
            button2.Name = "button2";
            button2.Size = new Size(211, 56);
            button2.TabIndex = 2;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(614, 178);
            button5.Name = "button5";
            button5.Size = new Size(211, 61);
            button5.TabIndex = 5;
            button5.Text = "Eliminar Usuario";
            button5.UseVisualStyleBackColor = true;
            // 
            // Gestion_usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(842, 428);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Gestion_usuarios";
            Text = "Gestion_usuarios";
            Load += Gestion_usuarios_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridDb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridDb;
        private Button button1;
        private Button button2;
        private Button button5;
    }
}