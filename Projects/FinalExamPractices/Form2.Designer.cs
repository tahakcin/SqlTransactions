﻿namespace FinalExamPractices
{
	partial class Form2
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
			this.txtCity = new System.Windows.Forms.TextBox();
			this.btnGetByCity = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(531, 118);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(215, 22);
			this.txtCity.TabIndex = 0;
			// 
			// btnGetByCity
			// 
			this.btnGetByCity.Location = new System.Drawing.Point(571, 162);
			this.btnGetByCity.Name = "btnGetByCity";
			this.btnGetByCity.Size = new System.Drawing.Size(125, 39);
			this.btnGetByCity.TabIndex = 1;
			this.btnGetByCity.Text = "GET";
			this.btnGetByCity.UseVisualStyleBackColor = true;
			this.btnGetByCity.Click += new System.EventHandler(this.btnGetByCity_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(491, 426);
			this.dataGridView1.TabIndex = 2;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnGetByCity);
			this.Controls.Add(this.txtCity);
			this.Name = "Form2";
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.Button btnGetByCity;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}