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
            textBox1=new TextBox();
            textBox2=new TextBox();
            textBox3=new TextBox();
            pictureBox1=new PictureBox();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            button1=new Button();
            button3=new Button();
            button4=new Button();
            label5=new Label();
            label4=new Label();
            textBox4=new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location=new Point(451, 42);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(225, 23);
            textBox1.TabIndex=1;
            // 
            // textBox2
            // 
            textBox2.Location=new Point(451, 72);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(225, 23);
            textBox2.TabIndex=2;
            // 
            // textBox3
            // 
            textBox3.Location=new Point(451, 129);
            textBox3.Name="textBox3";
            textBox3.Size=new Size(225, 23);
            textBox3.TabIndex=3;
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
            // button1
            // 
            button1.Image=Properties.Resources._285657_floppy_guardar_save_icon;
            button1.Location=new Point(263, 181);
            button1.Name="button1";
            button1.Size=new Size(110, 60);
            button1.TabIndex=10;
            button1.Text="Agregar";
            button1.TextImageRelation=TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor=true;
            // 
            // button3
            // 
            button3.Image=Properties.Resources._3643729_bin_delete_garbage_rubbish_trash_icon;
            button3.Location=new Point(407, 181);
            button3.Name="button3";
            button3.Size=new Size(98, 60);
            button3.TabIndex=12;
            button3.Text="Borrar";
            button3.TextImageRelation=TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor=true;
            // 
            // button4
            // 
            button4.Image=Properties.Resources._9004828_cross_delete_remove_cancel_icon;
            button4.Location=new Point(525, 181);
            button4.Name="button4";
            button4.Size=new Size(110, 60);
            button4.TabIndex=13;
            button4.Text="Cancelar";
            button4.TextImageRelation=TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor=true;
            button4.Click+=button4_Click;
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
            // textBox4
            // 
            textBox4.Location=new Point(451, 100);
            textBox4.Name="textBox4";
            textBox4.Size=new Size(225, 23);
            textBox4.TabIndex=18;
            // 
            // FrmSignUp
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.ActiveCaption;
            ClientSize=new Size(684, 254);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name="FrmSignUp";
            Text="Frm Cliente Nuevo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button3;
        private Button button4;
        private Label label5;
        private Label label4;
        private TextBox textBox4;
    }
}