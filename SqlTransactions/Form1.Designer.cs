namespace SqlTransactions
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
			this.btnGetList = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnAddCustomer = new System.Windows.Forms.Button();
			this.btnDelCustomer = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGetList
			// 
			this.btnGetList.Location = new System.Drawing.Point(607, 12);
			this.btnGetList.Name = "btnGetList";
			this.btnGetList.Size = new System.Drawing.Size(137, 49);
			this.btnGetList.TabIndex = 1;
			this.btnGetList.Text = "GET LIST";
			this.btnGetList.UseVisualStyleBackColor = true;
			this.btnGetList.Click += new System.EventHandler(this.btnGetList_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(556, 438);
			this.dataGridView1.TabIndex = 2;
			// 
			// btnAddCustomer
			// 
			this.btnAddCustomer.Location = new System.Drawing.Point(607, 67);
			this.btnAddCustomer.Name = "btnAddCustomer";
			this.btnAddCustomer.Size = new System.Drawing.Size(137, 49);
			this.btnAddCustomer.TabIndex = 3;
			this.btnAddCustomer.Text = "ADD";
			this.btnAddCustomer.UseVisualStyleBackColor = true;
			this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
			// 
			// btnDelCustomer
			// 
			this.btnDelCustomer.Location = new System.Drawing.Point(607, 122);
			this.btnDelCustomer.Name = "btnDelCustomer";
			this.btnDelCustomer.Size = new System.Drawing.Size(137, 49);
			this.btnDelCustomer.TabIndex = 4;
			this.btnDelCustomer.Text = "DELETE";
			this.btnDelCustomer.UseVisualStyleBackColor = true;
			this.btnDelCustomer.Click += new System.EventHandler(this.btnDelCustomer_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(607, 177);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(137, 49);
			this.btnEdit.TabIndex = 5;
			this.btnEdit.Text = "EDIT";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnDelCustomer);
			this.Controls.Add(this.btnAddCustomer);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnGetList);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnGetList;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnAddCustomer;
		private System.Windows.Forms.Button btnDelCustomer;
		private System.Windows.Forms.Button btnEdit;
	}
}

