namespace TP_FINAL
{
    partial class FrmLogin
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
            pictureBox1=new PictureBox();
            label1=new Label();
            btnUsuarioNuevo=new Button();
            btnIniciar=new Button();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            textBox1=new TextBox();
            textBox2=new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image=Properties.Resources.stethoscope__2_;
            pictureBox1.Location=new Point(261, 44);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(185, 174);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=0;
            pictureBox1.TabStop=false;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI Black", 18F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            label1.Location=new Point(150, 9);
            label1.Name="label1";
            label1.Size=new Size(413, 32);
            label1.TabIndex=1;
            label1.Text="Bienvenido a Veterinaria CATDOG";
            // 
            // btnUsuarioNuevo
            // 
            btnUsuarioNuevo.Location=new Point(219, 330);
            btnUsuarioNuevo.Name="btnUsuarioNuevo";
            btnUsuarioNuevo.Size=new Size(138, 23);
            btnUsuarioNuevo.TabIndex=2;
            btnUsuarioNuevo.Text="Soy un usuario nuevo";
            btnUsuarioNuevo.UseVisualStyleBackColor=true;
            btnUsuarioNuevo.Click+=btnUsuarioNuevo_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Location=new Point(382, 330);
            btnIniciar.Name="btnIniciar";
            btnIniciar.Size=new Size(75, 23);
            btnIniciar.TabIndex=3;
            btnIniciar.Text="Iniciar";
            btnIniciar.UseVisualStyleBackColor=true;
            btnIniciar.Click+=btnIniciar_Click_1;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location=new Point(297, 221);
            label2.Name="label2";
            label2.Size=new Size(121, 25);
            label2.TabIndex=5;
            label2.Text="Inicie sesion:";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(245, 263);
            label3.Name="label3";
            label3.Size=new Size(30, 15);
            label3.TabIndex=6;
            label3.Text="Mail";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(245, 292);
            label4.Name="label4";
            label4.Size=new Size(67, 15);
            label4.TabIndex=7;
            label4.Text="Contraseña";
            // 
            // textBox1
            // 
            textBox1.Location=new Point(318, 260);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(100, 23);
            textBox1.TabIndex=8;
            // 
            // textBox2
            // 
            textBox2.Location=new Point(318, 289);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(100, 23);
            textBox2.TabIndex=9;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.ActiveCaption;
            BackgroundImage=Properties.Resources.Captura_de_pantalla_2023_11_05_160334;
            ClientSize=new Size(688, 399);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnIniciar);
            Controls.Add(btnUsuarioNuevo);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name="FrmLogin";
            Text="Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnUsuarioNuevo;
        private Button btnIniciar;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}