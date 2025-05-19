namespace FinalExamPractices
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnDetails = new System.Windows.Forms.Button();
			this.btnGetByCity = new System.Windows.Forms.Button();
			this.btnGet = new System.Windows.Forms.Button();
			this.btnOutlaws = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(492, 309);
			this.dataGridView1.TabIndex = 0;
			// 
			// btnDetails
			// 
			this.btnDetails.Location = new System.Drawing.Point(595, 178);
			this.btnDetails.Name = "btnDetails";
			this.btnDetails.Size = new System.Drawing.Size(124, 55);
			this.btnDetails.TabIndex = 1;
			this.btnDetails.Text = "DETAILS";
			this.btnDetails.UseVisualStyleBackColor = true;
			this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
			// 
			// btnGetByCity
			// 
			this.btnGetByCity.Location = new System.Drawing.Point(595, 102);
			this.btnGetByCity.Name = "btnGetByCity";
			this.btnGetByCity.Size = new System.Drawing.Size(124, 55);
			this.btnGetByCity.TabIndex = 2;
			this.btnGetByCity.Text = "GET BY CITY";
			this.btnGetByCity.UseVisualStyleBackColor = true;
			this.btnGetByCity.Click += new System.EventHandler(this.btnGetByCity_Click);
			// 
			// btnGet
			// 
			this.btnGet.Location = new System.Drawing.Point(595, 12);
			this.btnGet.Name = "btnGet";
			this.btnGet.Size = new System.Drawing.Size(124, 55);
			this.btnGet.TabIndex = 3;
			this.btnGet.Text = "GET";
			this.btnGet.UseVisualStyleBackColor = true;
			this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
			// 
			// btnOutlaws
			// 
			this.btnOutlaws.Location = new System.Drawing.Point(595, 266);
			this.btnOutlaws.Name = "btnOutlaws";
			this.btnOutlaws.Size = new System.Drawing.Size(124, 55);
			this.btnOutlaws.TabIndex = 4;
			this.btnOutlaws.Text = "OUTLAWS";
			this.btnOutlaws.UseVisualStyleBackColor = true;
			this.btnOutlaws.Click += new System.EventHandler(this.btnOutlaws_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnOutlaws);
			this.Controls.Add(this.btnGet);
			this.Controls.Add(this.btnGetByCity);
			this.Controls.Add(this.btnDetails);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnDetails;
		private System.Windows.Forms.Button btnGetByCity;
		private System.Windows.Forms.Button btnGet;
		private System.Windows.Forms.Button btnOutlaws;
	}
}

