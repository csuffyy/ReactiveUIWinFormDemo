﻿namespace ReactiveUIWinFormDemo
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
            this.textBoxMyInput = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.statusTray = new System.Windows.Forms.StatusStrip();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.child = new CustomControl();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMyInput
            // 
            this.textBoxMyInput.Location = new System.Drawing.Point(3, 2);
            this.textBoxMyInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMyInput.Name = "textBoxMyInput";
            this.textBoxMyInput.Size = new System.Drawing.Size(607, 25);
            this.textBoxMyInput.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(3, 31);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 46);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // statusTray
            // 
            this.statusTray.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusTray.Location = new System.Drawing.Point(0, 676);
            this.statusTray.Name = "statusTray";
            this.statusTray.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusTray.Size = new System.Drawing.Size(1340, 22);
            this.statusTray.TabIndex = 2;
            this.statusTray.Text = "statusStrip1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.textBoxMyInput);
            this.flowLayoutPanel1.Controls.Add(this.btnOK);
            this.flowLayoutPanel1.Controls.Add(this.child);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 9);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1318, 664);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // child
            // 
            this.child.Location = new System.Drawing.Point(3, 82);
            this.child.Name = "child";
            this.child.Size = new System.Drawing.Size(606, 350);
            this.child.TabIndex = 2;
            this.child.ViewModel = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 698);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusTray);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMyInput;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.StatusStrip statusTray;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomControl child;
    }
}

