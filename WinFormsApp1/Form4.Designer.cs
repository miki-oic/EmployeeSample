﻿namespace WinFormsApp1
{
    partial class Form4
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
            panel1 = new Panel();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(30, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 235);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.Location = new Point(130, 172);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 7;
            label7.Text = "label7";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Location = new Point(24, 172);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 6;
            label8.Text = "状 態";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Location = new Point(130, 127);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 5;
            label6.Text = "label6";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Location = new Point(24, 127);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 4;
            label5.Text = "メール";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(130, 79);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 3;
            label4.Text = "label4";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(24, 79);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "氏 名";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(130, 33);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Location = new Point(24, 33);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "社員ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 285);
            Controls.Add(panel1);
            Name = "Form4";
            Text = "Form4";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}