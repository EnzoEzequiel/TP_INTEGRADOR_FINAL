namespace TP_FINAL
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
            label3=new Label();
            label4=new Label();
            textBox1=new TextBox();
            textBox2=new TextBox();
            textBox4=new TextBox();
            button1=new Button();
            button2=new Button();
            button3=new Button();
            label5=new Label();
            textBox5=new TextBox();
            radioButton1=new RadioButton();
            radioButton2=new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image=Properties.Resources.dog3;
            pictureBox1.Location=new Point(12, 12);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(228, 259);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=0;
            pictureBox1.TabStop=false;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(326, 26);
            label1.Name="label1";
            label1.Size=new Size(86, 25);
            label1.TabIndex=1;
            label1.Text="Nombre";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location=new Point(328, 98);
            label2.Name="label2";
            label2.Size=new Size(53, 25);
            label2.TabIndex=2;
            label2.Text="Raza";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location=new Point(327, 134);
            label3.Name="label3";
            label3.Size=new Size(56, 25);
            label3.TabIndex=3;
            label3.Text="Sexo";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location=new Point(328, 167);
            label4.Name="label4";
            label4.Size=new Size(56, 25);
            label4.TabIndex=4;
            label4.Text="Edad";
            // 
            // textBox1
            // 
            textBox1.Location=new Point(425, 31);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(100, 23);
            textBox1.TabIndex=5;
            // 
            // textBox2
            // 
            textBox2.Location=new Point(425, 103);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(100, 23);
            textBox2.TabIndex=6;
            // 
            // textBox4
            // 
            textBox4.Location=new Point(425, 169);
            textBox4.Name="textBox4";
            textBox4.Size=new Size(100, 23);
            textBox4.TabIndex=8;
            // 
            // button1
            // 
            button1.Image=Properties.Resources._285657_floppy_guardar_save_icon;
            button1.Location=new Point(284, 207);
            button1.Name="button1";
            button1.Size=new Size(107, 64);
            button1.TabIndex=9;
            button1.Text="Agregar";
            button1.TextImageRelation=TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor=true;
            // 
            // button2
            // 
            button2.Image=Properties.Resources._3643729_bin_delete_garbage_rubbish_trash_icon;
            button2.Location=new Point(397, 207);
            button2.Name="button2";
            button2.Size=new Size(108, 64);
            button2.TabIndex=10;
            button2.Text="Limpiar";
            button2.TextImageRelation=TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor=true;
            // 
            // button3
            // 
            button3.Image=Properties.Resources._9004828_cross_delete_remove_cancel_icon;
            button3.Location=new Point(511, 207);
            button3.Name="button3";
            button3.Size=new Size(111, 64);
            button3.TabIndex=11;
            button3.Text="Cancelar";
            button3.TextImageRelation=TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor=true;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Font=new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location=new Point(328, 64);
            label5.Name="label5";
            label5.Size=new Size(76, 25);
            label5.TabIndex=12;
            label5.Text="Especie";
            // 
            // textBox5
            // 
            textBox5.Location=new Point(425, 69);
            textBox5.Name="textBox5";
            textBox5.Size=new Size(100, 23);
            textBox5.TabIndex=13;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize=true;
            radioButton1.Location=new Point(414, 140);
            radioButton1.Name="radioButton1";
            radioButton1.Size=new Size(62, 19);
            radioButton1.TabIndex=14;
            radioButton1.TabStop=true;
            radioButton1.Text="Macho";
            radioButton1.UseVisualStyleBackColor=true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize=true;
            radioButton2.Location=new Point(492, 140);
            radioButton2.Name="radioButton2";
            radioButton2.Size=new Size(68, 19);
            radioButton2.TabIndex=15;
            radioButton2.TabStop=true;
            radioButton2.Text="Hembra";
            radioButton2.UseVisualStyleBackColor=true;
            // 
            // FrmMascota
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(650, 286);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
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
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label5;
        private TextBox textBox5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}