namespace GrafikaSemestralna
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
            progressBar3 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            progressBar4 = new ProgressBar();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            hraciaPlocha = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hraciaPlocha).BeginInit();
            SuspendLayout();
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(40, 487);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(125, 29);
            progressBar3.Step = 1;
            progressBar3.TabIndex = 2;
            progressBar3.Value = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 464);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 3;
            label1.Text = "Hlad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 496);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(104, 413);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(351, 29);
            progressBar4.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 422);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 6;
            label3.Text = "Život";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(475, 422);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "label4";
            label4.Click += label4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.juh;
            pictureBox2.Location = new Point(224, 332);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.zapad;
            pictureBox1.Location = new Point(21, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 243);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.sever;
            pictureBox3.Location = new Point(224, 108);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 208);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.vychod;
            pictureBox4.Location = new Point(488, 82);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(82, 243);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // hraciaPlocha
            // 
            hraciaPlocha.BackgroundImage = Properties.Resources.miestnost;
            hraciaPlocha.Image = Properties.Resources.miestnost;
            hraciaPlocha.Location = new Point(12, 12);
            hraciaPlocha.Name = "hraciaPlocha";
            hraciaPlocha.Size = new Size(558, 382);
            hraciaPlocha.SizeMode = PictureBoxSizeMode.StretchImage;
            hraciaPlocha.TabIndex = 8;
            hraciaPlocha.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 803);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(hraciaPlocha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(progressBar4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)hraciaPlocha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ProgressBar progressBar3;
        private Label label1;
        private Label label2;
        private ProgressBar progressBar4;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox hraciaPlocha;
    }
}