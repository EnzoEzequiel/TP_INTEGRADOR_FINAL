namespace TP_FINAL
{
    partial class FrmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignUp));
            txtBoxNombreNuevo=new TextBox();
            txtBoxMailNuevo=new TextBox();
            txtBoxTelefonoNuevo=new TextBox();
            pictureBox1=new PictureBox();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            btnAgregarUsuario=new Button();
            btnLimpiarUsuarioNuevo=new Button();
            btnCancelarUsuarioNuevo=new Button();
            label5=new Label();
            label4=new Label();
            txtBoxContraNueva=new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtBoxNombreNuevo
            // 
            txtBoxNombreNuevo.Location=new Point(451, 42);
            txtBoxNombreNuevo.Name="txtBoxNombreNuevo";
            txtBoxNombreNuevo.Size=new Size(225, 23);
            txtBoxNombreNuevo.TabIndex=1;
            // 
            // txtBoxMailNuevo
            // 
            txtBoxMailNuevo.Location=new Point(451, 72);
            txtBoxMailNuevo.Name="txtBoxMailNuevo";
            txtBoxMailNuevo.Size=new Size(225, 23);
            txtBoxMailNuevo.TabIndex=2;
            // 
            // txtBoxTelefonoNuevo
            // 
            txtBoxTelefonoNuevo.Location=new Point(451, 129);
            txtBoxTelefonoNuevo.Name="txtBoxTelefonoNuevo";
            txtBoxTelefonoNuevo.Size=new Size(225, 23);
            txtBoxTelefonoNuevo.TabIndex=3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image=(Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location=new Point(12, 44);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(234, 200);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=4;
            pictureBox1.TabStop=false;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(263, 42);
            label1.Name="label1";
            label1.Size=new Size(86, 25);
            label1.TabIndex=5;
            label1.Text="Nombre";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location=new Point(263, 72);
            label2.Name="label2";
            label2.Size=new Size(160, 25);
            label2.TabIndex=6;
            label2.Text="Mail de contacto";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location=new Point(263, 129);
            label3.Name="label3";
            label3.Size=new Size(89, 25);
            label3.TabIndex=7;
            label3.Text="Telefono";
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Image=Properties.Resources._285657_floppy_guardar_save_icon;
            btnAgregarUsuario.Location=new Point(263, 181);
            btnAgregarUsuario.Name="btnAgregarUsuario";
            btnAgregarUsuario.Size=new Size(110, 60);
            btnAgregarUsuario.TabIndex=10;
            btnAgregarUsuario.Text="Agregar";
            btnAgregarUsuario.TextImageRelation=TextImageRelation.ImageBeforeText;
            btnAgregarUsuario.UseVisualStyleBackColor=true;
            // 
            // btnLimpiarUsuarioNuevo
            // 
            btnLimpiarUsuarioNuevo.Image=Properties.Resources._3643729_bin_delete_garbage_rubbish_trash_icon;
            btnLimpiarUsuarioNuevo.Location=new Point(407, 181);
            btnLimpiarUsuarioNuevo.Name="btnLimpiarUsuarioNuevo";
            btnLimpiarUsuarioNuevo.Size=new Size(98, 60);
            btnLimpiarUsuarioNuevo.TabIndex=12;
            btnLimpiarUsuarioNuevo.Text="Borrar";
            btnLimpiarUsuarioNuevo.TextImageRelation=TextImageRelation.ImageBeforeText;
            btnLimpiarUsuarioNuevo.UseVisualStyleBackColor=true;
            // 
            // btnCancelarUsuarioNuevo
            // 
            btnCancelarUsuarioNuevo.Image=Properties.Resources._9004828_cross_delete_remove_cancel_icon;
            btnCancelarUsuarioNuevo.Location=new Point(525, 181);
            btnCancelarUsuarioNuevo.Name="btnCancelarUsuarioNuevo";
            btnCancelarUsuarioNuevo.Size=new Size(110, 60);
            btnCancelarUsuarioNuevo.TabIndex=13;
            btnCancelarUsuarioNuevo.Text="Cancelar";
            btnCancelarUsuarioNuevo.TextImageRelation=TextImageRelation.ImageBeforeText;
            btnCancelarUsuarioNuevo.UseVisualStyleBackColor=true;
            btnCancelarUsuarioNuevo.Click+=button4_Click;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Font=new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location=new Point(12, 9);
            label5.Name="label5";
            label5.Size=new Size(397, 25);
            label5.TabIndex=16;
            label5.Text="Favor de ingresar los datos del usuario nuevo";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location=new Point(263, 102);
            label4.Name="label4";
            label4.Size=new Size(113, 25);
            label4.TabIndex=17;
            label4.Text="Contraseña";
            // 
            // txtBoxContraNueva
            // 
            txtBoxContraNueva.Location=new Point(451, 100);
            txtBoxContraNueva.Name="txtBoxContraNueva";
            txtBoxContraNueva.Size=new Size(225, 23);
            txtBoxContraNueva.TabIndex=18;
            // 
            // FrmSignUp
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.ActiveCaption;
            ClientSize=new Size(684, 254);
            Controls.Add(txtBoxContraNueva);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(btnCancelarUsuarioNuevo);
            Controls.Add(btnLimpiarUsuarioNuevo);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(txtBoxTelefonoNuevo);
            Controls.Add(txtBoxMailNuevo);
            Controls.Add(txtBoxNombreNuevo);
            Name="FrmSignUp";
            Text="Frm Cliente Nuevo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBoxNombreNuevo;
        private TextBox txtBoxMailNuevo;
        private TextBox txtBoxTelefonoNuevo;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAgregarUsuario;
        private Button btnLimpiarUsuarioNuevo;
        private Button btnCancelarUsuarioNuevo;
        private Label label5;
        private Label label4;
        private TextBox txtBoxContraNueva;
    }
}