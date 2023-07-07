namespace MyDayApp
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
            label3 = new Label();
            LQPath = new Label();
            panel1 = new Panel();
            LQButton = new Button();
            label1 = new Label();
            HQButton = new Button();
            panel2 = new Panel();
            HQPath = new Label();
            label4 = new Label();
            label6 = new Label();
            FinalButton = new Button();
            label7 = new Label();
            TotalFiles = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 236);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 4;
            label3.Text = "PATH:";
            // 
            // LQPath
            // 
            LQPath.AutoSize = true;
            LQPath.Location = new Point(60, 236);
            LQPath.Name = "LQPath";
            LQPath.Size = new Size(263, 20);
            LQPath.TabIndex = 6;
            LQPath.Text = "ΔΕΝ ΕΧΕΙΣ ΕΠΙΛΕΞΕΙ ΦΑΚΕΛΟ ΑΚΟΜΗ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 119, 74);
            panel1.Controls.Add(TotalFiles);
            panel1.Controls.Add(LQPath);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(LQButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(690, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 343);
            panel1.TabIndex = 8;
            // 
            // LQButton
            // 
            LQButton.BackColor = Color.FromArgb(120, 37, 255);
            LQButton.ForeColor = Color.White;
            LQButton.Location = new Point(138, 98);
            LQButton.Name = "LQButton";
            LQButton.Size = new Size(185, 78);
            LQButton.TabIndex = 3;
            LQButton.Text = "ΕΠΙΛΟΓΗ";
            LQButton.UseVisualStyleBackColor = false;
            LQButton.Click += LQButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 10);
            label1.Name = "label1";
            label1.Size = new Size(435, 20);
            label1.TabIndex = 2;
            label1.Text = "ΕΠΙΛΕΞΤΕ ΤΟΝ ΦΑΚΕΛΟ ΜΕ ΤΙΣ ΕΙΚΟΝΕΣ ΧΑΜΗΛΗΣ ΑΝΑΛΥΣΗΣ";
            label1.Click += label1_Click;
            // 
            // HQButton
            // 
            HQButton.BackColor = Color.FromArgb(120, 37, 255);
            HQButton.ForeColor = Color.White;
            HQButton.Location = new Point(138, 98);
            HQButton.Name = "HQButton";
            HQButton.Size = new Size(185, 78);
            HQButton.TabIndex = 3;
            HQButton.Text = "ΕΠΙΛΟΓΗ";
            HQButton.UseVisualStyleBackColor = false;
            HQButton.Click += HQButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(249, 119, 74);
            panel2.Controls.Add(HQButton);
            panel2.Controls.Add(HQPath);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(47, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(433, 343);
            panel2.TabIndex = 9;
            // 
            // HQPath
            // 
            HQPath.AutoSize = true;
            HQPath.Location = new Point(60, 236);
            HQPath.Name = "HQPath";
            HQPath.Size = new Size(263, 20);
            HQPath.TabIndex = 6;
            HQPath.Text = "ΔΕΝ ΕΧΕΙΣ ΕΠΙΛΕΞΕΙ ΦΑΚΕΛΟ ΑΚΟΜΗ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 236);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 4;
            label4.Text = "PATH:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 10);
            label6.Name = "label6";
            label6.Size = new Size(423, 20);
            label6.TabIndex = 2;
            label6.Text = "ΕΠΙΛΕΞΤΕ ΤΟΝ ΦΑΚΕΛΟ ΜΕ ΤΙΣ ΕΙΚΟΝΕΣ ΥΨΗΛΗΣ ΑΝΑΛΥΣΗΣ";
            // 
            // FinalButton
            // 
            FinalButton.BackColor = Color.FromArgb(72, 165, 84);
            FinalButton.ForeColor = Color.White;
            FinalButton.Location = new Point(394, 540);
            FinalButton.Name = "FinalButton";
            FinalButton.Size = new Size(357, 78);
            FinalButton.TabIndex = 7;
            FinalButton.Text = "ΔΗΜΙΟΥΡΓΙΑ ΤΕΛΙΚΟΥ ΦΑΚΕΛΟΥ";
            FinalButton.UseVisualStyleBackColor = false;
            FinalButton.Click += FinalButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 305);
            label7.Name = "label7";
            label7.Size = new Size(317, 20);
            label7.TabIndex = 7;
            label7.Text = "ΣΥΝΟΛΙΚΑ ΑΡΧΕΙΑ ΠΟΥ ΕΠΕΛΕΞΕ Ο ΠΕΛΑΤΗΣ:";
            // 
            // TotalFiles
            // 
            TotalFiles.AutoSize = true;
            TotalFiles.Location = new Point(337, 305);
            TotalFiles.Name = "TotalFiles";
            TotalFiles.Size = new Size(15, 20);
            TotalFiles.TabIndex = 10;
            TotalFiles.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 189, 75);
            ClientSize = new Size(1182, 673);
            Controls.Add(FinalButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "MyDay";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Label LQPath;
        private Panel panel1;
        private Button HQButton;
        private Label label1;
        private Panel panel2;
        private Button LQButton;
        private Label HQPath;
        private Label label4;
        private Label label6;
        private Button FinalButton;
        private Label label7;
        private Label TotalFiles;
    }
}