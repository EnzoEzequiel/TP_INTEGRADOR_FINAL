﻿namespace TP_FINAL
{
    partial class FrmMascota
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
            label2=new Label();
            txtBoxNombreMascotaNueva=new TextBox();
            btnAgregarMascotaNueva=new Button();
            btnLimpiarCamposMascota=new Button();
            btnCancelarAgregarMascota=new Button();
            dateTimePicker1=new DateTimePicker();
            label3=new Label();
            txtBoxEspecieMascotaNueva=new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image=Properties.Resources.dog3;
            pictureBox1.Location=new Point(12, 12);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(228, 184);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=0;
            pictureBox1.TabStop=false;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(246, 12);
            label1.Name="label1";
            label1.Size=new Size(86, 25);
            label1.TabIndex=1;
            label1.Text="Nombre";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location=new Point(246, 55);
            label2.Name="label2";
            label2.Size=new Size(193, 25);
            label2.TabIndex=2;
            label2.Text="Fecha de nacimiento";
            // 
            // txtBoxNombreMascotaNueva
            // 
            txtBoxNombreMascotaNueva.Location=new Point(349, 17);
            txtBoxNombreMascotaNueva.Name="txtBoxNombreMascotaNueva";
            txtBoxNombreMascotaNueva.Size=new Size(263, 23);
            txtBoxNombreMascotaNueva.TabIndex=5;
            // 
            // btnAgregarMascotaNueva
            // 
            btnAgregarMascotaNueva.Image=Properties.Resources._285657_floppy_guardar_save_icon;
            btnAgregarMascotaNueva.Location=new Point(246, 132);
            btnAgregarMascotaNueva.Name="btnAgregarMascotaNueva";
            btnAgregarMascotaNueva.Size=new Size(107, 64);
            btnAgregarMascotaNueva.TabIndex=9;
            btnAgregarMascotaNueva.Text="Agregar";
            btnAgregarMascotaNueva.TextImageRelation=TextImageRelation.ImageBeforeText;
            btnAgregarMascotaNueva.UseVisualStyleBackColor=true;
            btnAgregarMascotaNueva.Click+=btnAgregarMascotaNueva_Click;
            // 
            // btnLimpiarCamposMascota
            // 
            btnLimpiarCamposMascota.Image=Properties.Resources._3643729_bin_delete_garbage_rubbish_trash_icon;
            btnLimpiarCamposMascota.Location=new Point(371, 132);
            btnLimpiarCamposMascota.Name="btnLimpiarCamposMascota";
            btnLimpiarCamposMascota.Size=new Size(108, 64);
            btnLimpiarCamposMascota.TabIndex=10;
            btnLimpiarCamposMascota.Text="Limpiar";
            btnLimpiarCamposMascota.TextImageRelation=TextImageRelation.ImageBeforeText;
            btnLimpiarCamposMascota.UseVisualStyleBackColor=true;
            btnLimpiarCamposMascota.Click+=btnLimpiarCamposMascota_Click;
            // 
            // btnCancelarAgregarMascota
            // 
            btnCancelarAgregarMascota.Image=Properties.Resources._9004828_cross_delete_remove_cancel_icon;
            btnCancelarAgregarMascota.Location=new Point(495, 132);
            btnCancelarAgregarMascota.Name="btnCancelarAgregarMascota";
            btnCancelarAgregarMascota.Size=new Size(111, 64);
            btnCancelarAgregarMascota.TabIndex=11;
            btnCancelarAgregarMascota.Text="Cancelar";
            btnCancelarAgregarMascota.TextImageRelation=TextImageRelation.ImageBeforeText;
            btnCancelarAgregarMascota.UseVisualStyleBackColor=true;
            btnCancelarAgregarMascota.Click+=btnCancelarAgregarMascota_Click_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location=new Point(445, 57);
            dateTimePicker1.Name="dateTimePicker1";
            dateTimePicker1.Size=new Size(167, 23);
            dateTimePicker1.TabIndex=14;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location=new Point(246, 94);
            label3.Name="label3";
            label3.Size=new Size(76, 25);
            label3.TabIndex=15;
            label3.Text="Especie";
            // 
            // txtBoxEspecieMascotaNueva
            // 
            txtBoxEspecieMascotaNueva.Location=new Point(349, 96);
            txtBoxEspecieMascotaNueva.Name="txtBoxEspecieMascotaNueva";
            txtBoxEspecieMascotaNueva.Size=new Size(263, 23);
            txtBoxEspecieMascotaNueva.TabIndex=16;
            // 
            // FrmMascota
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(653, 203);
            Controls.Add(txtBoxEspecieMascotaNueva);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnCancelarAgregarMascota);
            Controls.Add(btnLimpiarCamposMascota);
            Controls.Add(btnAgregarMascotaNueva);
            Controls.Add(txtBoxNombreMascotaNueva);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name="FrmMascota";
            Text="Frm Mascota";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtBoxNombreMascotaNueva;
        private Button btnAgregarMascotaNueva;
        private Button btnLimpiarCamposMascota;
        private Button btnCancelarAgregarMascota;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox txtBoxEspecieMascotaNueva;
    }
}