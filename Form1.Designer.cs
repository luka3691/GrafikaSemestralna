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
            hladBar = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            progressBar4 = new ProgressBar();
            label3 = new Label();
            label4 = new Label();
            hraciaPlocha = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            wcBar = new ProgressBar();
            label7 = new Label();
            label8 = new Label();
            energiaBar = new ProgressBar();
            label9 = new Label();
            label10 = new Label();
            hygienaBar = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)hraciaPlocha).BeginInit();
            SuspendLayout();
            // 
            // hladBar
            // 
            hladBar.Location = new Point(40, 487);
            hladBar.Name = "hladBar";
            hladBar.Size = new Size(125, 29);
            hladBar.Step = 1;
            hladBar.TabIndex = 2;
            hladBar.Value = 100;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(472, 496);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 11;
            label5.Text = "label5";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(341, 464);
            label6.Name = "label6";
            label6.Size = new Size(32, 20);
            label6.TabIndex = 10;
            label6.Text = "WC";
            label6.Click += label6_Click;
            // 
            // wcBar
            // 
            wcBar.Location = new Point(341, 487);
            wcBar.Name = "wcBar";
            wcBar.Size = new Size(125, 29);
            wcBar.Step = 1;
            wcBar.TabIndex = 9;
            wcBar.Value = 100;
            wcBar.Click += progressBar1_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(171, 572);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 14;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 540);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 13;
            label8.Text = "Energia";
            label8.Click += label8_Click;
            // 
            // energiaBar
            // 
            energiaBar.Location = new Point(40, 563);
            energiaBar.Name = "energiaBar";
            energiaBar.Size = new Size(125, 29);
            energiaBar.Step = 1;
            energiaBar.TabIndex = 12;
            energiaBar.Value = 100;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(472, 572);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 17;
            label9.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(341, 540);
            label10.Name = "label10";
            label10.Size = new Size(64, 20);
            label10.TabIndex = 16;
            label10.Text = "Hygiena";
            label10.Click += label10_Click;
            // 
            // hygienaBar
            // 
            hygienaBar.Location = new Point(341, 563);
            hygienaBar.Name = "hygienaBar";
            hygienaBar.Size = new Size(125, 29);
            hygienaBar.Step = 1;
            hygienaBar.TabIndex = 15;
            hygienaBar.Value = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 803);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(hygienaBar);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(energiaBar);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(wcBar);
            Controls.Add(hraciaPlocha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(progressBar4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(hladBar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)hraciaPlocha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ProgressBar hladBar;
        private Label label1;
        private Label label2;
        private ProgressBar progressBar4;
        private Label label3;
        private Label label4;
        private PictureBox hraciaPlocha;
        private Label label5;
        private Label label6;
        private ProgressBar wcBar;
        private Label label7;
        private Label label8;
        private ProgressBar energiaBar;
        private Label label9;
        private Label label10;
        private ProgressBar hygienaBar;
    }
}