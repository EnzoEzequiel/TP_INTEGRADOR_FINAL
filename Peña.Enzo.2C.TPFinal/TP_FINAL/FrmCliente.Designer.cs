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
            lblEnfermo=new Label();
            lblAlta=new Label();
            button1=new Button();
            button2=new Button();
            pictureBox1=new PictureBox();
            btnVolverMenu=new Button();
            lblCalendario=new Label();
            lblVeterinario=new Label();
            lblInfoMascota=new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(99, 9);
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
            lblNombreCliente.Location=new Point(234, 11);
            lblNombreCliente.Name="lblNombreCliente";
            lblNombreCliente.Size=new Size(165, 30);
            lblNombreCliente.TabIndex=4;
            lblNombreCliente.Text="nombreUsuario";
            // 
            // lblEnfermo
            // 
            lblEnfermo.AutoSize=true;
            lblEnfermo.Location=new Point(17, 137);
            lblEnfermo.Name="lblEnfermo";
            lblEnfermo.Size=new Size(87, 15);
            lblEnfermo.TabIndex=7;
            lblEnfermo.Text="estadoEnfermo";
            // 
            // lblAlta
            // 
            lblAlta.AutoSize=true;
            lblAlta.Location=new Point(17, 163);
            lblAlta.Name="lblAlta";
            lblAlta.Size=new Size(63, 15);
            lblAlta.TabIndex=8;
            lblAlta.Text="estadoAlta";
            // 
            // button1
            // 
            button1.Location=new Point(208, 227);
            button1.Name="button1";
            button1.Size=new Size(112, 23);
            button1.TabIndex=9;
            button1.Text="Guardar estado";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // button2
            // 
            button2.Location=new Point(17, 227);
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
            btnVolverMenu.Location=new Point(343, 227);
            btnVolverMenu.Name="btnVolverMenu";
            btnVolverMenu.Size=new Size(112, 23);
            btnVolverMenu.TabIndex=12;
            btnVolverMenu.Text="Volver";
            btnVolverMenu.UseVisualStyleBackColor=true;
            btnVolverMenu.Click+=btnVolverMenu_Click;
            // 
            // lblCalendario
            // 
            lblCalendario.AutoSize=true;
            lblCalendario.Location=new Point(17, 111);
            lblCalendario.Name="lblCalendario";
            lblCalendario.Size=new Size(85, 15);
            lblCalendario.TabIndex=15;
            lblCalendario.Text="estadoVacunas";
            // 
            // lblVeterinario
            // 
            lblVeterinario.AutoSize=true;
            lblVeterinario.Location=new Point(17, 189);
            lblVeterinario.Name="lblVeterinario";
            lblVeterinario.Size=new Size(63, 15);
            lblVeterinario.TabIndex=16;
            lblVeterinario.Text="veterinario";
            // 
            // lblInfoMascota
            // 
            lblInfoMascota.AutoSize=true;
            lblInfoMascota.Location=new Point(99, 57);
            lblInfoMascota.Name="lblInfoMascota";
            lblInfoMascota.Size=new Size(207, 15);
            lblInfoMascota.TabIndex=17;
            lblInfoMascota.Text="Informacion de mascota seleccionada";
            // 
            // FrmCliente
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.ActiveCaption;
            ClientSize=new Size(468, 260);
            Controls.Add(lblInfoMascota);
            Controls.Add(lblVeterinario);
            Controls.Add(lblCalendario);
            Controls.Add(btnVolverMenu);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblAlta);
            Controls.Add(lblEnfermo);
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
        private Label lblEnfermo;
        private Label lblAlta;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Button btnVolverMenu;
        private Label lblCalendario;
        private Label lblVeterinario;
        private Label lblInfoMascota;
    }
}