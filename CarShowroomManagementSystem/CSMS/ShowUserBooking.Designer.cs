namespace CSMS
{
	partial class ShowUserBooking
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowUserBooking));
			this.showuserbookings = new System.Windows.Forms.DataGridView();
			this.addbooking = new System.Windows.Forms.Button();
			this.reqbookingrm = new System.Windows.Forms.Button();
			this.back = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.showuserbookings)).BeginInit();
			this.SuspendLayout();
			// 
			// showuserbookings
			// 
			this.showuserbookings.AllowUserToAddRows = false;
			this.showuserbookings.AllowUserToDeleteRows = false;
			this.showuserbookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.showuserbookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.showuserbookings.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.showuserbookings.Location = new System.Drawing.Point(117, 166);
			this.showuserbookings.MultiSelect = false;
			this.showuserbookings.Name = "showuserbookings";
			this.showuserbookings.ReadOnly = true;
			this.showuserbookings.RowHeadersWidth = 51;
			this.showuserbookings.RowTemplate.Height = 24;
			this.showuserbookings.Size = new System.Drawing.Size(1040, 370);
			this.showuserbookings.TabIndex = 0;
			this.showuserbookings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showuserbookings_CellClick);
			this.showuserbookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showuserbookings_CellContentClick);
			// 
			// addbooking
			// 
			this.addbooking.BackColor = System.Drawing.Color.Transparent;
			this.addbooking.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addbooking.FlatAppearance.BorderSize = 0;
			this.addbooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addbooking.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addbooking.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.addbooking.Location = new System.Drawing.Point(441, 556);
			this.addbooking.Name = "addbooking";
			this.addbooking.Size = new System.Drawing.Size(196, 58);
			this.addbooking.TabIndex = 1;
			this.addbooking.Text = "Add Booking";
			this.addbooking.UseVisualStyleBackColor = false;
			this.addbooking.Click += new System.EventHandler(this.addbooking_Click);
			// 
			// reqbookingrm
			// 
			this.reqbookingrm.BackColor = System.Drawing.Color.Transparent;
			this.reqbookingrm.Cursor = System.Windows.Forms.Cursors.Hand;
			this.reqbookingrm.FlatAppearance.BorderSize = 0;
			this.reqbookingrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.reqbookingrm.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reqbookingrm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.reqbookingrm.Location = new System.Drawing.Point(767, 557);
			this.reqbookingrm.Name = "reqbookingrm";
			this.reqbookingrm.Size = new System.Drawing.Size(349, 58);
			this.reqbookingrm.TabIndex = 2;
			this.reqbookingrm.Text = "Request Booking Cancellation";
			this.reqbookingrm.UseVisualStyleBackColor = false;
			this.reqbookingrm.Click += new System.EventHandler(this.reqbookingrm_Click);
			// 
			// back
			// 
			this.back.BackColor = System.Drawing.Color.Transparent;
			this.back.Cursor = System.Windows.Forms.Cursors.Hand;
			this.back.FlatAppearance.BorderSize = 0;
			this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.back.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.back.Location = new System.Drawing.Point(117, 555);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(133, 58);
			this.back.TabIndex = 4;
			this.back.Text = "Back";
			this.back.UseVisualStyleBackColor = false;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(380, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(586, 45);
			this.label1.TabIndex = 5;
			this.label1.Text = "Car Showroom Management System";
			// 
			// ShowUserBooking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CSMS.Properties.Resources.A;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1282, 703);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.back);
			this.Controls.Add(this.reqbookingrm);
			this.Controls.Add(this.addbooking);
			this.Controls.Add(this.showuserbookings);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ShowUserBooking";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Show User Booking";
			this.Load += new System.EventHandler(this.ShowUserBooking_Load);
			((System.ComponentModel.ISupportInitialize)(this.showuserbookings)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView showuserbookings;
		private System.Windows.Forms.Button addbooking;
		private System.Windows.Forms.Button reqbookingrm;
		private System.Windows.Forms.Button back;
		private System.Windows.Forms.Label label1;
	}
}