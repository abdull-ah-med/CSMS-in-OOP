namespace CSMS
{
	partial class AdminBookingInterface
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBookingInterface));
			this.custbooking = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.bookingstatus = new System.Windows.Forms.TextBox();
			this.updatebooking = new System.Windows.Forms.Button();
			this.rmbooking = new System.Windows.Forms.Button();
			this.back = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.custbooking)).BeginInit();
			this.SuspendLayout();
			// 
			// custbooking
			// 
			this.custbooking.AllowUserToAddRows = false;
			this.custbooking.AllowUserToDeleteRows = false;
			this.custbooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.custbooking.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
			this.custbooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.custbooking.Location = new System.Drawing.Point(299, 118);
			this.custbooking.Name = "custbooking";
			this.custbooking.ReadOnly = true;
			this.custbooking.RowHeadersWidth = 51;
			this.custbooking.RowTemplate.Height = 24;
			this.custbooking.Size = new System.Drawing.Size(941, 442);
			this.custbooking.TabIndex = 0;
			this.custbooking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.custbooking_CellClick);
			this.custbooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.custbooking_CellContentClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(367, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(586, 45);
			this.label2.TabIndex = 7;
			this.label2.Text = "Car Showroom Management System";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(68, 231);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(165, 31);
			this.label1.TabIndex = 8;
			this.label1.Text = "Booking Status";
			// 
			// bookingstatus
			// 
			this.bookingstatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bookingstatus.Location = new System.Drawing.Point(31, 277);
			this.bookingstatus.Name = "bookingstatus";
			this.bookingstatus.Size = new System.Drawing.Size(238, 34);
			this.bookingstatus.TabIndex = 9;
			// 
			// updatebooking
			// 
			this.updatebooking.BackColor = System.Drawing.Color.Transparent;
			this.updatebooking.FlatAppearance.BorderSize = 0;
			this.updatebooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.updatebooking.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.updatebooking.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.updatebooking.Location = new System.Drawing.Point(509, 589);
			this.updatebooking.Name = "updatebooking";
			this.updatebooking.Size = new System.Drawing.Size(212, 45);
			this.updatebooking.TabIndex = 10;
			this.updatebooking.Text = "Update Booking Status";
			this.updatebooking.UseVisualStyleBackColor = false;
			this.updatebooking.Click += new System.EventHandler(this.updatebooking_Click);
			// 
			// rmbooking
			// 
			this.rmbooking.BackColor = System.Drawing.Color.Transparent;
			this.rmbooking.FlatAppearance.BorderSize = 0;
			this.rmbooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rmbooking.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rmbooking.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.rmbooking.Location = new System.Drawing.Point(781, 589);
			this.rmbooking.Name = "rmbooking";
			this.rmbooking.Size = new System.Drawing.Size(341, 45);
			this.rmbooking.TabIndex = 11;
			this.rmbooking.Text = "Delete Booking";
			this.rmbooking.UseVisualStyleBackColor = false;
			this.rmbooking.Click += new System.EventHandler(this.rmbooking_Click);
			// 
			// back
			// 
			this.back.BackColor = System.Drawing.Color.Transparent;
			this.back.FlatAppearance.BorderSize = 0;
			this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.back.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.back.Location = new System.Drawing.Point(74, 589);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(115, 45);
			this.back.TabIndex = 12;
			this.back.Text = "Back";
			this.back.UseVisualStyleBackColor = false;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// AdminBookingInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CSMS.Properties.Resources.A;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1282, 703);
			this.Controls.Add(this.back);
			this.Controls.Add(this.rmbooking);
			this.Controls.Add(this.updatebooking);
			this.Controls.Add(this.bookingstatus);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.custbooking);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AdminBookingInterface";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminBookingInterface";
			((System.ComponentModel.ISupportInitialize)(this.custbooking)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView custbooking;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox bookingstatus;
		private System.Windows.Forms.Button updatebooking;
		private System.Windows.Forms.Button rmbooking;
		private System.Windows.Forms.Button back;
	}
}