﻿namespace WindowsFormsApplication7
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.homeBarButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.registrationButton);
            this.panel1.Controls.Add(this.homeBarButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 438);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "UCP Application";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // homeBarButton
            // 
            this.homeBarButton.Location = new System.Drawing.Point(49, 86);
            this.homeBarButton.Name = "homeBarButton";
            this.homeBarButton.Size = new System.Drawing.Size(75, 37);
            this.homeBarButton.TabIndex = 1;
            this.homeBarButton.Text = "Home";
            this.homeBarButton.UseVisualStyleBackColor = true;
            // 
            // registrationButton
            // 
            this.registrationButton.Location = new System.Drawing.Point(49, 152);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(75, 39);
            this.registrationButton.TabIndex = 2;
            this.registrationButton.Text = "Registration";
            this.registrationButton.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(49, 216);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 36);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "login";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 438);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button homeBarButton;
    }
}

