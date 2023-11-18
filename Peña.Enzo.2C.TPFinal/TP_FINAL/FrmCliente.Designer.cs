namespace TP_FINAL
{
    partial class FrmCliente
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
            label1=new Label();
            label2=new Label();
            label3=new Label();
            comboBox1=new ComboBox();
            lblNombreCliente=new Label();
            label4=new Label();
            label5=new Label();
            lblEnfermo=new Label();
            lblAlta=new Label();
            button1=new Button();
            button2=new Button();
            pictureBox1=new PictureBox();
            btnVolverMenu=new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(99, 26);
            label1.Name="label1";
            label1.Size=new Size(142, 32);
            label1.TabIndex=0;
            label1.Text="Bienvenido";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location=new Point(12, 75);
            label2.Name="label2";
            label2.Size=new Size(197, 25);
            label2.TabIndex=1;
            label2.Text="Estado de mascota/s:";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location=new Point(313, 79);
            label3.Name="label3";
            label3.Size=new Size(142, 21);
            label3.TabIndex=2;
            label3.Text="Lista de mascotas:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled=true;
            comboBox1.Location=new Point(313, 111);
            comboBox1.Name="comboBox1";
            comboBox1.Size=new Size(142, 23);
            comboBox1.TabIndex=3;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize=true;
            lblNombreCliente.Font=new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreCliente.Location=new Point(238, 28);
            lblNombreCliente.Name="lblNombreCliente";
            lblNombreCliente.Size=new Size(165, 30);
            lblNombreCliente.TabIndex=4;
            lblNombreCliente.Text="nombreUsuario";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(17, 107);
            label4.Name="label4";
            label4.Size=new Size(58, 15);
            label4.TabIndex=5;
            label4.Text="Enfermo: ";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(17, 146);
            label5.Name="label5";
            label5.Size=new Size(76, 15);
            label5.TabIndex=6;
            label5.Text="Dado de alta:";
            // 
            // lblEnfermo
            // 
            lblEnfermo.AutoSize=true;
            lblEnfermo.Location=new Point(106, 110);
            lblEnfermo.Name="lblEnfermo";
            lblEnfermo.Size=new Size(87, 15);
            lblEnfermo.TabIndex=7;
            lblEnfermo.Text="estadoEnfermo";
            // 
            // lblAlta
            // 
            lblAlta.AutoSize=true;
            lblAlta.Location=new Point(106, 146);
            lblAlta.Name="lblAlta";
            lblAlta.Size=new Size(63, 15);
            lblAlta.TabIndex=8;
            lblAlta.Text="estadoAlta";
            // 
            // button1
            // 
            button1.Location=new Point(313, 146);
            button1.Name="button1";
            button1.Size=new Size(112, 23);
            button1.TabIndex=9;
            button1.Text="Guardar estado";
            button1.UseVisualStyleBackColor=true;
            // 
            // button2
            // 
            button2.Location=new Point(17, 190);
            button2.Name="button2";
            button2.Size=new Size(171, 23);
            button2.TabIndex=10;
            button2.Text="Ingresar nueva mascota";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image=Properties.Resources.user__2_;
            pictureBox1.Location=new Point(0, -1);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(93, 73);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=11;
            pictureBox1.TabStop=false;
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.Location=new Point(313, 192);
            btnVolverMenu.Name="btnVolverMenu";
            btnVolverMenu.Size=new Size(112, 23);
            btnVolverMenu.TabIndex=12;
            btnVolverMenu.Text="Volver";
            btnVolverMenu.UseVisualStyleBackColor=true;
            btnVolverMenu.Click+=btnVolverMenu_Click;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.ActiveCaption;
            ClientSize=new Size(504, 241);
            Controls.Add(btnVolverMenu);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblAlta);
            Controls.Add(lblEnfermo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblNombreCliente);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name="FrmCliente";
            Text="Frm cliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label lblNombreCliente;
        private Label label4;
        private Label label5;
        private Label lblEnfermo;
        private Label lblAlta;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Button btnVolverMenu;
    }
}