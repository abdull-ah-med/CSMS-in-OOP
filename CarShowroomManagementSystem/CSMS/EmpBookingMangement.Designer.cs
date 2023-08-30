namespace CSMS
{
	partial class EmpBookingMangement
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpBookingMangement));
			this.empviewbooking = new System.Windows.Forms.DataGridView();
			this.updatebooking = new System.Windows.Forms.Button();
			this.rmbooking = new System.Windows.Forms.Button();
			this.back = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.empviewbooking)).BeginInit();
			this.SuspendLayout();
			// 
			// empviewbooking
			// 
			this.empviewbooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.empviewbooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.empviewbooking.Location = new System.Drawing.Point(102, 154);
			this.empviewbooking.Name = "empviewbooking";
			this.empviewbooking.ReadOnly = true;
			this.empviewbooking.RowHeadersWidth = 51;
			this.empviewbooking.RowTemplate.Height = 24;
			this.empviewbooking.Size = new System.Drawing.Size(1063, 362);
			this.empviewbooking.TabIndex = 0;
			this.empviewbooking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empviewbooking_CellClick);
			this.empviewbooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empviewbooking_CellContentClick);
			// 
			// updatebooking
			// 
			this.updatebooking.BackColor = System.Drawing.Color.Transparent;
			this.updatebooking.FlatAppearance.BorderSize = 0;
			this.updatebooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.updatebooking.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.updatebooking.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.updatebooking.Location = new System.Drawing.Point(341, 555);
			this.updatebooking.Name = "updatebooking";
			this.updatebooking.Size = new System.Drawing.Size(290, 45);
			this.updatebooking.TabIndex = 3;
			this.updatebooking.Text = "Confirm New Booking";
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
			this.rmbooking.Location = new System.Drawing.Point(790, 555);
			this.rmbooking.Name = "rmbooking";
			this.rmbooking.Size = new System.Drawing.Size(308, 45);
			this.rmbooking.TabIndex = 4;
			this.rmbooking.Text = "Confirm Booking Deletion";
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
			this.back.Location = new System.Drawing.Point(58, 555);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(115, 45);
			this.back.TabIndex = 5;
			this.back.Text = "Back";
			this.back.UseVisualStyleBackColor = false;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(333, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(586, 45);
			this.label2.TabIndex = 6;
			this.label2.Text = "Car Showroom Management System";
			// 
			// EmpBookingMangement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CSMS.Properties.Resources.A;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1282, 703);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.back);
			this.Controls.Add(this.rmbooking);
			this.Controls.Add(this.updatebooking);
			this.Controls.Add(this.empviewbooking);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EmpBookingMangement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Employee > Booking Managment";
			((System.ComponentModel.ISupportInitialize)(this.empviewbooking)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView empviewbooking;
		private System.Windows.Forms.Button updatebooking;
		private System.Windows.Forms.Button rmbooking;
		private System.Windows.Forms.Button back;
		private System.Windows.Forms.Label label2;
	}
}