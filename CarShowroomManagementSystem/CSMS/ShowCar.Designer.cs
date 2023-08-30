namespace CSMS
{
	partial class ShowCar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowCar));
			this.viewcar = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.back = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.viewcar)).BeginInit();
			this.SuspendLayout();
			// 
			// viewcar
			// 
			this.viewcar.AllowUserToAddRows = false;
			this.viewcar.AllowUserToDeleteRows = false;
			this.viewcar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.viewcar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.viewcar.Location = new System.Drawing.Point(162, 142);
			this.viewcar.Name = "viewcar";
			this.viewcar.ReadOnly = true;
			this.viewcar.RowHeadersWidth = 51;
			this.viewcar.RowTemplate.Height = 24;
			this.viewcar.Size = new System.Drawing.Size(958, 382);
			this.viewcar.TabIndex = 0;
			this.viewcar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewcar_CellClick);
			this.viewcar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewcar_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(352, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(599, 46);
			this.label1.TabIndex = 1;
			this.label1.Text = "Car Showroom Management System";
			// 
			// back
			// 
			this.back.BackColor = System.Drawing.Color.Transparent;
			this.back.FlatAppearance.BorderSize = 0;
			this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.back.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back.ForeColor = System.Drawing.Color.Transparent;
			this.back.Location = new System.Drawing.Point(584, 563);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(102, 47);
			this.back.TabIndex = 2;
			this.back.Text = "Back";
			this.back.UseVisualStyleBackColor = false;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// ShowCar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CSMS.Properties.Resources.A;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1282, 703);
			this.Controls.Add(this.back);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.viewcar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ShowCar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Show Car";
			this.Load += new System.EventHandler(this.ShowCar_Load);
			((System.ComponentModel.ISupportInitialize)(this.viewcar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView viewcar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button back;
	}
}