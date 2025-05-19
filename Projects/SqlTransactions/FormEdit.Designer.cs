namespace SqlTransactions
{
	partial class FormEdit
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
			this.lblCustomerID = new System.Windows.Forms.Label();
			this.txtCustomerID = new System.Windows.Forms.TextBox();
			this.lblUpdateCol = new System.Windows.Forms.Label();
			this.txtUpdateCol = new System.Windows.Forms.TextBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.lblNewData = new System.Windows.Forms.Label();
			this.txtNewData = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblCustomerID
			// 
			this.lblCustomerID.AutoSize = true;
			this.lblCustomerID.Location = new System.Drawing.Point(230, 48);
			this.lblCustomerID.Name = "lblCustomerID";
			this.lblCustomerID.Size = new System.Drawing.Size(66, 16);
			this.lblCustomerID.TabIndex = 1;
			this.lblCustomerID.Text = "Müşteri ID";
			// 
			// txtCustomerID
			// 
			this.txtCustomerID.Location = new System.Drawing.Point(392, 42);
			this.txtCustomerID.Name = "txtCustomerID";
			this.txtCustomerID.Size = new System.Drawing.Size(173, 22);
			this.txtCustomerID.TabIndex = 2;
			// 
			// lblUpdateCol
			// 
			this.lblUpdateCol.AutoSize = true;
			this.lblUpdateCol.Location = new System.Drawing.Point(230, 108);
			this.lblUpdateCol.Name = "lblUpdateCol";
			this.lblUpdateCol.Size = new System.Drawing.Size(133, 16);
			this.lblUpdateCol.TabIndex = 3;
			this.lblUpdateCol.Text = "Güncellenecek Sütun";
			// 
			// txtUpdateCol
			// 
			this.txtUpdateCol.Location = new System.Drawing.Point(392, 104);
			this.txtUpdateCol.Name = "txtUpdateCol";
			this.txtUpdateCol.Size = new System.Drawing.Size(173, 22);
			this.txtUpdateCol.TabIndex = 4;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(335, 236);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(111, 45);
			this.btnUpdate.TabIndex = 5;
			this.btnUpdate.Text = "UPDATE";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// lblNewData
			// 
			this.lblNewData.AutoSize = true;
			this.lblNewData.Location = new System.Drawing.Point(230, 166);
			this.lblNewData.Name = "lblNewData";
			this.lblNewData.Size = new System.Drawing.Size(61, 16);
			this.lblNewData.TabIndex = 6;
			this.lblNewData.Text = "Yeni Veri";
			// 
			// txtNewData
			// 
			this.txtNewData.Location = new System.Drawing.Point(392, 160);
			this.txtNewData.Name = "txtNewData";
			this.txtNewData.Size = new System.Drawing.Size(173, 22);
			this.txtNewData.TabIndex = 7;
			// 
			// FormEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtNewData);
			this.Controls.Add(this.lblNewData);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.txtUpdateCol);
			this.Controls.Add(this.lblUpdateCol);
			this.Controls.Add(this.txtCustomerID);
			this.Controls.Add(this.lblCustomerID);
			this.Name = "FormEdit";
			this.Text = "FormEdit";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblCustomerID;
		private System.Windows.Forms.TextBox txtCustomerID;
		private System.Windows.Forms.Label lblUpdateCol;
		private System.Windows.Forms.TextBox txtUpdateCol;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label lblNewData;
		private System.Windows.Forms.TextBox txtNewData;
	}
}