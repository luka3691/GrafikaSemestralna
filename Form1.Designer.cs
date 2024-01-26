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
            hraciaPlocha = new PictureBox();
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
            Controls.Add(hraciaPlocha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(progressBar4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar3);
            Name = "Form1";
            Text = "Form1";
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
        private PictureBox hraciaPlocha;
    }
}