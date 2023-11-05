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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(57, 30);
            label1.Name="label1";
            label1.Size=new Size(142, 32);
            label1.TabIndex=0;
            label1.Text="Bienvenido";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(57, 79);
            label2.Name="label2";
            label2.Size=new Size(116, 15);
            label2.TabIndex=1;
            label2.Text="Estado de mascota/s";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(313, 79);
            label3.Name="label3";
            label3.Size=new Size(103, 15);
            label3.TabIndex=2;
            label3.Text="Lista de mascotas:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled=true;
            comboBox1.Location=new Point(313, 111);
            comboBox1.Name="comboBox1";
            comboBox1.Size=new Size(121, 23);
            comboBox1.TabIndex=3;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize=true;
            lblNombreCliente.Font=new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreCliente.Location=new Point(205, 30);
            lblNombreCliente.Name="lblNombreCliente";
            lblNombreCliente.Size=new Size(165, 30);
            lblNombreCliente.TabIndex=4;
            lblNombreCliente.Text="nombreUsuario";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(57, 114);
            label4.Name="label4";
            label4.Size=new Size(58, 15);
            label4.TabIndex=5;
            label4.Text="Enfermo: ";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(57, 150);
            label5.Name="label5";
            label5.Size=new Size(76, 15);
            label5.TabIndex=6;
            label5.Text="Dado de alta:";
            // 
            // lblEnfermo
            // 
            lblEnfermo.AutoSize=true;
            lblEnfermo.Location=new Point(146, 114);
            lblEnfermo.Name="lblEnfermo";
            lblEnfermo.Size=new Size(87, 15);
            lblEnfermo.TabIndex=7;
            lblEnfermo.Text="estadoEnfermo";
            // 
            // lblAlta
            // 
            lblAlta.AutoSize=true;
            lblAlta.Location=new Point(146, 150);
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
            button2.Location=new Point(57, 194);
            button2.Name="button2";
            button2.Size=new Size(171, 23);
            button2.TabIndex=10;
            button2.Text="Ingresar nueva mascota";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.ActiveCaption;
            ClientSize=new Size(504, 241);
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
            Text="Form1";
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
    }
}