﻿namespace App_run_Window
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblTestType = new System.Windows.Forms.Label();
            this.lblTestDate = new System.Windows.Forms.Label();
            this.lblTestTime = new System.Windows.Forms.Label();
            this.btnOpenMuse = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HL7 URL Source :";
            // 
            // txtSource
            // 
            this.txtSource.AllowDrop = true;
            this.txtSource.Location = new System.Drawing.Point(14, 35);
            this.txtSource.Margin = new System.Windows.Forms.Padding(2);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(520, 88);
            this.txtSource.TabIndex = 1;
            this.txtSource.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSource.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtSource_DragDrop);
            this.txtSource.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtSource_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patient ID : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Test Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Test Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Test Time";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(80, 133);
            this.lblPatientID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(0, 13);
            this.lblPatientID.TabIndex = 6;
            // 
            // lblTestType
            // 
            this.lblTestType.AutoSize = true;
            this.lblTestType.Location = new System.Drawing.Point(80, 161);
            this.lblTestType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTestType.Name = "lblTestType";
            this.lblTestType.Size = new System.Drawing.Size(0, 13);
            this.lblTestType.TabIndex = 6;
            // 
            // lblTestDate
            // 
            this.lblTestDate.AutoSize = true;
            this.lblTestDate.Location = new System.Drawing.Point(80, 192);
            this.lblTestDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTestDate.Name = "lblTestDate";
            this.lblTestDate.Size = new System.Drawing.Size(0, 13);
            this.lblTestDate.TabIndex = 6;
            // 
            // lblTestTime
            // 
            this.lblTestTime.AutoSize = true;
            this.lblTestTime.Location = new System.Drawing.Point(80, 220);
            this.lblTestTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTestTime.Name = "lblTestTime";
            this.lblTestTime.Size = new System.Drawing.Size(0, 13);
            this.lblTestTime.TabIndex = 6;
            // 
            // btnOpenMuse
            // 
            this.btnOpenMuse.Location = new System.Drawing.Point(14, 254);
            this.btnOpenMuse.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenMuse.Name = "btnOpenMuse";
            this.btnOpenMuse.Size = new System.Drawing.Size(92, 40);
            this.btnOpenMuse.TabIndex = 7;
            this.btnOpenMuse.Text = "Open Record In MUSE";
            this.btnOpenMuse.UseVisualStyleBackColor = true;
            this.btnOpenMuse.Click += new System.EventHandler(this.btnOpenMuse_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(442, 254);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(92, 40);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "Exit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 303);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnOpenMuse);
            this.Controls.Add(this.lblTestTime);
            this.Controls.Add(this.lblTestDate);
            this.Controls.Add(this.lblTestType);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Run Muse FromHL7 URL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblTestType;
        private System.Windows.Forms.Label lblTestDate;
        private System.Windows.Forms.Label lblTestTime;
        private System.Windows.Forms.Button btnOpenMuse;
        private System.Windows.Forms.Button btnQuit;
    }
}

