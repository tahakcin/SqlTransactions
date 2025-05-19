namespace SqlTransactions
{
	partial class FormDelete
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
			this.btnDelCustomer = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblCustomerID
			// 
			this.lblCustomerID.AutoSize = true;
			this.lblCustomerID.Location = new System.Drawing.Point(188, 181);
			this.lblCustomerID.Name = "lblCustomerID";
			this.lblCustomerID.Size = new System.Drawing.Size(69, 16);
			this.lblCustomerID.TabIndex = 0;
			this.lblCustomerID.Text = "Müşteri ID ";
			// 
			// txtCustomerID
			// 
			this.txtCustomerID.Location = new System.Drawing.Point(435, 178);
			this.txtCustomerID.Name = "txtCustomerID";
			this.txtCustomerID.Size = new System.Drawing.Size(187, 22);
			this.txtCustomerID.TabIndex = 1;
			// 
			// btnDelCustomer
			// 
			this.btnDelCustomer.Location = new System.Drawing.Point(306, 271);
			this.btnDelCustomer.Name = "btnDelCustomer";
			this.btnDelCustomer.Size = new System.Drawing.Size(113, 34);
			this.btnDelCustomer.TabIndex = 2;
			this.btnDelCustomer.Text = "DELETE";
			this.btnDelCustomer.UseVisualStyleBackColor = true;
			this.btnDelCustomer.Click += new System.EventHandler(this.btnDelCustomer_Click);
			// 
			// FormDelete
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnDelCustomer);
			this.Controls.Add(this.txtCustomerID);
			this.Controls.Add(this.lblCustomerID);
			this.Name = "FormDelete";
			this.Text = "FormDelete";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCustomerID;
		private System.Windows.Forms.TextBox txtCustomerID;
		private System.Windows.Forms.Button btnDelCustomer;
	}
}