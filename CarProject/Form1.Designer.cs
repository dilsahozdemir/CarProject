namespace CarProject
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
            components = new System.ComponentModel.Container();
            yol = new Panel();
            car = new Panel();
            panel12 = new Panel();
            panel11 = new Panel();
            panel10 = new Panel();
            panel9 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            fren = new Panel();
            gaz = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            yol.SuspendLayout();
            car.SuspendLayout();
            SuspendLayout();
            // 
            // yol
            // 
            yol.BackColor = SystemColors.ActiveCaptionText;
            yol.Controls.Add(car);
            yol.Controls.Add(panel7);
            yol.Controls.Add(panel6);
            yol.Controls.Add(panel5);
            yol.Controls.Add(panel4);
            yol.Controls.Add(panel3);
            yol.Controls.Add(panel2);
            yol.Dock = DockStyle.Left;
            yol.Location = new Point(0, 0);
            yol.Name = "yol";
            yol.Size = new Size(176, 419);
            yol.TabIndex = 0;
            // 
            // car
            // 
            car.BackColor = Color.FromArgb(64, 0, 64);
            car.Controls.Add(panel12);
            car.Controls.Add(panel11);
            car.Controls.Add(panel10);
            car.Controls.Add(panel9);
            car.Location = new Point(104, 266);
            car.Name = "car";
            car.Size = new Size(52, 83);
            car.TabIndex = 1;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Red;
            panel12.Location = new Point(0, 64);
            panel12.Name = "panel12";
            panel12.Size = new Size(18, 19);
            panel12.TabIndex = 2;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Red;
            panel11.Location = new Point(34, 64);
            panel11.Name = "panel11";
            panel11.Size = new Size(18, 19);
            panel11.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Yellow;
            panel10.Location = new Point(34, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(18, 19);
            panel10.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Yellow;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(18, 19);
            panel9.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Yellow;
            panel7.Location = new Point(74, 381);
            panel7.Name = "panel7";
            panel7.Size = new Size(10, 54);
            panel7.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Yellow;
            panel6.Location = new Point(74, 307);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 54);
            panel6.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Yellow;
            panel5.Location = new Point(74, 231);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 54);
            panel5.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Yellow;
            panel4.Location = new Point(74, 76);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 54);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Yellow;
            panel3.Location = new Point(74, 153);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 54);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Location = new Point(74, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 54);
            panel2.TabIndex = 0;
            // 
            // fren
            // 
            fren.BackColor = Color.Maroon;
            fren.Location = new Point(196, 76);
            fren.Name = "fren";
            fren.Size = new Size(133, 112);
            fren.TabIndex = 1;
            fren.MouseEnter += fren_MouseEnter;
            // 
            // gaz
            // 
            gaz.BackColor = Color.FromArgb(64, 0, 0);
            gaz.Location = new Point(196, 218);
            gaz.Name = "gaz";
            gaz.Size = new Size(133, 112);
            gaz.TabIndex = 2;
            gaz.Paint += gaz_Paint;
            gaz.MouseEnter += gaz_MouseEnter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 419);
            Controls.Add(gaz);
            Controls.Add(fren);
            Controls.Add(yol);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            yol.ResumeLayout(false);
            car.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel yol;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel7;
        private Panel car;
        private Panel panel12;
        private Panel panel11;
        private Panel panel10;
        private Panel panel9;
        private Panel fren;
        private Panel gaz;
        private System.Windows.Forms.Timer timer1;
    }
}
