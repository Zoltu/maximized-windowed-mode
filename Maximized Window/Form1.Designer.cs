﻿namespace Maximized_Window
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
			this.listBoxProcesses = new System.Windows.Forms.ListBox();
			this.buttonMaximize = new System.Windows.Forms.Button();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBoxProcesses
			// 
			this.listBoxProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxProcesses.FormattingEnabled = true;
			this.listBoxProcesses.Location = new System.Drawing.Point(12, 12);
			this.listBoxProcesses.Name = "listBoxProcesses";
			this.listBoxProcesses.Size = new System.Drawing.Size(260, 212);
			this.listBoxProcesses.TabIndex = 0;
			// 
			// buttonMaximize
			// 
			this.buttonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMaximize.Location = new System.Drawing.Point(197, 227);
			this.buttonMaximize.Name = "buttonMaximize";
			this.buttonMaximize.Size = new System.Drawing.Size(75, 23);
			this.buttonMaximize.TabIndex = 1;
			this.buttonMaximize.Text = "(Un)Maximize";
			this.buttonMaximize.UseVisualStyleBackColor = true;
			this.buttonMaximize.Click += new System.EventHandler(this.button1_Click);
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonRefresh.Location = new System.Drawing.Point(12, 227);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
			this.buttonRefresh.TabIndex = 2;
			this.buttonRefresh.Text = "Refresh";
			this.buttonRefresh.UseVisualStyleBackColor = true;
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.buttonRefresh);
			this.Controls.Add(this.buttonMaximize);
			this.Controls.Add(this.listBoxProcesses);
			this.Name = "Form1";
			this.Text = "Maximized Windowed Mode";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxProcesses;
		private System.Windows.Forms.Button buttonMaximize;
		private System.Windows.Forms.Button buttonRefresh;

	}
}

