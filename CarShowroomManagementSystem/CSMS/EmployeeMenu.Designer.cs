namespace CSMS
{
	partial class EmployeeMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeMenu));
			this.label2 = new System.Windows.Forms.Label();
			this.viewCars = new System.Windows.Forms.Button();
			this.managebookings = new System.Windows.Forms.Button();
			this.getPrice = new System.Windows.Forms.Button();
			this.updateprof = new System.Windows.Forms.Button();
			this.logout = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(353, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(586, 45);
			this.label2.TabIndex = 1;
			this.label2.Text = "Car Showroom Management System";
			// 
			// viewCars
			// 
			this.viewCars.BackColor = System.Drawing.Color.Transparent;
			this.viewCars.FlatAppearance.BorderSize = 0;
			this.viewCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.viewCars.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.viewCars.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.viewCars.Location = new System.Drawing.Point(553, 160);
			this.viewCars.Name = "viewCars";
			this.viewCars.Size = new System.Drawing.Size(200, 63);
			this.viewCars.TabIndex = 2;
			this.viewCars.Text = "Check Car Info";
			this.viewCars.UseVisualStyleBackColor = false;
			this.viewCars.Click += new System.EventHandler(this.viewCars_Click);
			// 
			// managebookings
			// 
			this.managebookings.BackColor = System.Drawing.Color.Transparent;
			this.managebookings.FlatAppearance.BorderSize = 0;
			this.managebookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.managebookings.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.managebookings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.managebookings.Location = new System.Drawing.Point(530, 248);
			this.managebookings.Name = "managebookings";
			this.managebookings.Size = new System.Drawing.Size(236, 63);
			this.managebookings.TabIndex = 3;
			this.managebookings.Text = "Manage Bookings";
			this.managebookings.UseVisualStyleBackColor = false;
			this.managebookings.Click += new System.EventHandler(this.managebookings_Click);
			// 
			// getPrice
			// 
			this.getPrice.BackColor = System.Drawing.Color.Transparent;
			this.getPrice.FlatAppearance.BorderSize = 0;
			this.getPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.getPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.getPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.getPrice.Location = new System.Drawing.Point(559, 334);
			this.getPrice.Name = "getPrice";
			this.getPrice.Size = new System.Drawing.Size(178, 63);
			this.getPrice.TabIndex = 4;
			this.getPrice.Text = "Get Price";
			this.getPrice.UseVisualStyleBackColor = false;
			this.getPrice.Click += new System.EventHandler(this.getPrice_Click);
			// 
			// updateprof
			// 
			this.updateprof.BackColor = System.Drawing.Color.Transparent;
			this.updateprof.FlatAppearance.BorderSize = 0;
			this.updateprof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.updateprof.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.updateprof.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.updateprof.Location = new System.Drawing.Point(529, 420);
			this.updateprof.Name = "updateprof";
			this.updateprof.Size = new System.Drawing.Size(249, 63);
			this.updateprof.TabIndex = 5;
			this.updateprof.Text = "Update Your Profile";
			this.updateprof.UseVisualStyleBackColor = false;
			this.updateprof.Click += new System.EventHandler(this.updateprof_Click);
			// 
			// logout
			// 
			this.logout.BackColor = System.Drawing.Color.Transparent;
			this.logout.FlatAppearance.BorderSize = 0;
			this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.logout.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.logout.Location = new System.Drawing.Point(530, 501);
			this.logout.Name = "logout";
			this.logout.Size = new System.Drawing.Size(236, 63);
			this.logout.TabIndex = 6;
			this.logout.Text = "LogOut";
			this.logout.UseVisualStyleBackColor = false;
			this.logout.Click += new System.EventHandler(this.logout_Click);
			// 
			// EmployeeMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CSMS.Properties.Resources.A;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1282, 703);
			this.Controls.Add(this.logout);
			this.Controls.Add(this.updateprof);
			this.Controls.Add(this.getPrice);
			this.Controls.Add(this.managebookings);
			this.Controls.Add(this.viewCars);
			this.Controls.Add(this.label2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EmployeeMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Employee Menu";
			this.Load += new System.EventHandler(this.EmployeeMenu_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button viewCars;
		private System.Windows.Forms.Button managebookings;
		private System.Windows.Forms.Button getPrice;
		private System.Windows.Forms.Button updateprof;
		private System.Windows.Forms.Button logout;
	}
}