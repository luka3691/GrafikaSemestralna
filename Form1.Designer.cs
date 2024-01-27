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
            zivotBar = new ProgressBar();
            label3 = new Label();
            hraciaPlocha = new PictureBox();
            label6 = new Label();
            wcBar = new ProgressBar();
            label8 = new Label();
            energiaBar = new ProgressBar();
            label10 = new Label();
            hygienaBar = new ProgressBar();
            timeLabel = new Label();
            vyhraText = new Label();
            prehraText = new Label();
            ((System.ComponentModel.ISupportInitialize)hraciaPlocha).BeginInit();
            SuspendLayout();
            // 
            // hladBar
            // 
            hladBar.Location = new Point(29, 555);
            hladBar.Name = "hladBar";
            hladBar.Size = new Size(220, 29);
            hladBar.Step = 1;
            hladBar.TabIndex = 2;
            hladBar.Value = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 532);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 3;
            label1.Text = "Hlad";
            // 
            // zivotBar
            // 
            zivotBar.Location = new Point(143, 409);
            zivotBar.Name = "zivotBar";
            zivotBar.Size = new Size(383, 45);
            zivotBar.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 409);
            label3.Name = "label3";
            label3.Size = new Size(95, 46);
            label3.TabIndex = 6;
            label3.Text = "Život";
            label3.Click += label3_Click;
            // 
            // hraciaPlocha
            // 
            hraciaPlocha.BackColor = SystemColors.InactiveCaptionText;
            hraciaPlocha.BackgroundImage = Properties.Resources.miestnost;
            hraciaPlocha.BackgroundImageLayout = ImageLayout.Stretch;
            hraciaPlocha.Location = new Point(12, 12);
            hraciaPlocha.Name = "hraciaPlocha";
            hraciaPlocha.Size = new Size(558, 382);
            hraciaPlocha.SizeMode = PictureBoxSizeMode.StretchImage;
            hraciaPlocha.TabIndex = 8;
            hraciaPlocha.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(330, 532);
            label6.Name = "label6";
            label6.Size = new Size(32, 20);
            label6.TabIndex = 10;
            label6.Text = "WC";
            label6.Click += label6_Click;
            // 
            // wcBar
            // 
            wcBar.Location = new Point(330, 555);
            wcBar.Name = "wcBar";
            wcBar.Size = new Size(210, 29);
            wcBar.Step = 1;
            wcBar.TabIndex = 9;
            wcBar.Value = 100;
            wcBar.Click += progressBar1_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 608);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 13;
            label8.Text = "Energia";
            label8.Click += label8_Click;
            // 
            // energiaBar
            // 
            energiaBar.Location = new Point(29, 631);
            energiaBar.Name = "energiaBar";
            energiaBar.Size = new Size(220, 29);
            energiaBar.Step = 1;
            energiaBar.TabIndex = 12;
            energiaBar.Value = 100;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(330, 608);
            label10.Name = "label10";
            label10.Size = new Size(64, 20);
            label10.TabIndex = 16;
            label10.Text = "Hygiena";
            label10.Click += label10_Click;
            // 
            // hygienaBar
            // 
            hygienaBar.Location = new Point(330, 631);
            hygienaBar.Name = "hygienaBar";
            hygienaBar.Size = new Size(213, 29);
            hygienaBar.Step = 1;
            hygienaBar.TabIndex = 15;
            hygienaBar.Value = 100;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location = new Point(160, 663);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(245, 112);
            timeLabel.TabIndex = 18;
            timeLabel.Text = "00:00";
            // 
            // vyhraText
            // 
            vyhraText.AutoSize = true;
            vyhraText.BackColor = SystemColors.Desktop;
            vyhraText.Font = new Font("Segoe UI", 60F, FontStyle.Regular, GraphicsUnit.Point);
            vyhraText.ForeColor = SystemColors.ButtonHighlight;
            vyhraText.Location = new Point(117, 207);
            vyhraText.Name = "vyhraText";
            vyhraText.Size = new Size(338, 133);
            vyhraText.TabIndex = 19;
            vyhraText.Text = "Výhra!";
            vyhraText.Visible = false;
            // 
            // prehraText
            // 
            prehraText.AutoSize = true;
            prehraText.BackColor = SystemColors.Desktop;
            prehraText.Font = new Font("Segoe UI", 60F, FontStyle.Regular, GraphicsUnit.Point);
            prehraText.ForeColor = SystemColors.Window;
            prehraText.Location = new Point(104, 74);
            prehraText.Name = "prehraText";
            prehraText.Size = new Size(371, 133);
            prehraText.TabIndex = 20;
            prehraText.Text = "Prehra!";
            prehraText.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 803);
            Controls.Add(prehraText);
            Controls.Add(vyhraText);
            Controls.Add(timeLabel);
            Controls.Add(label10);
            Controls.Add(hygienaBar);
            Controls.Add(label8);
            Controls.Add(energiaBar);
            Controls.Add(label6);
            Controls.Add(wcBar);
            Controls.Add(hraciaPlocha);
            Controls.Add(label3);
            Controls.Add(zivotBar);
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
        private ProgressBar zivotBar;
        private Label label3;
        private PictureBox hraciaPlocha;
        private Label label6;
        private ProgressBar wcBar;
        private Label label8;
        private ProgressBar energiaBar;
        private Label label10;
        private ProgressBar hygienaBar;
        private Label timeLabel;
        private Label vyhraText;
        private Label prehraText;
    }
}