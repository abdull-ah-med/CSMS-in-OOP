namespace CSMS
{
	partial class showcarselect
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
			this.showcars = new System.Windows.Forms.DataGridView();
			this.returnselectcar = new System.Windows.Forms.Button();
			this.back = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.showcars)).BeginInit();
			this.SuspendLayout();
			// 
			// showcars
			// 
			this.showcars.AllowUserToAddRows = false;
			this.showcars.AllowUserToDeleteRows = false;
			this.showcars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.showcars.Location = new System.Drawing.Point(109, 152);
			this.showcars.Name = "showcars";
			this.showcars.ReadOnly = true;
			this.showcars.RowHeadersWidth = 51;
			this.showcars.RowTemplate.Height = 24;
			this.showcars.Size = new System.Drawing.Size(1049, 364);
			this.showcars.TabIndex = 0;
			this.showcars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showcars_CellClick);
			// 
			// returnselectcar
			// 
			this.returnselectcar.BackColor = System.Drawing.Color.Transparent;
			this.returnselectcar.FlatAppearance.BorderSize = 0;
			this.returnselectcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.returnselectcar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.returnselectcar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.returnselectcar.Location = new System.Drawing.Point(610, 568);
			this.returnselectcar.Name = "returnselectcar";
			this.returnselectcar.Size = new System.Drawing.Size(143, 57);
			this.returnselectcar.TabIndex = 1;
			this.returnselectcar.Text = "Select Car";
			this.returnselectcar.UseVisualStyleBackColor = false;
			this.returnselectcar.Click += new System.EventHandler(this.returnselectcar_Click);
			// 
			// back
			// 
			this.back.BackColor = System.Drawing.Color.Transparent;
			this.back.FlatAppearance.BorderSize = 0;
			this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.back.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.back.Location = new System.Drawing.Point(134, 568);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(143, 57);
			this.back.TabIndex = 2;
			this.back.Text = "Back";
			this.back.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(362, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(586, 45);
			this.label1.TabIndex = 3;
			this.label1.Text = "Car Showroom Management System";
			// 
			// showcarselect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CSMS.Properties.Resources.A;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1282, 703);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.back);
			this.Controls.Add(this.returnselectcar);
			this.Controls.Add(this.showcars);
			this.Name = "showcarselect";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "showcarselect";
			((System.ComponentModel.ISupportInitialize)(this.showcars)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView showcars;
		private System.Windows.Forms.Button returnselectcar;
		private System.Windows.Forms.Button back;
		private System.Windows.Forms.Label label1;
	}
}