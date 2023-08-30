namespace CSMS
{
	partial class PriceEstimate
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceEstimate));
			this.viewCar = new System.Windows.Forms.DataGridView();
			this.filerstatus = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pestimate = new System.Windows.Forms.Button();
			this.back = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.carDLBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.viewCar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.carDLBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// viewCar
			// 
			this.viewCar.AllowUserToAddRows = false;
			this.viewCar.AllowUserToDeleteRows = false;
			this.viewCar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.viewCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.viewCar.Location = new System.Drawing.Point(340, 144);
			this.viewCar.Name = "viewCar";
			this.viewCar.RowHeadersWidth = 51;
			this.viewCar.RowTemplate.Height = 24;
			this.viewCar.Size = new System.Drawing.Size(863, 363);
			this.viewCar.TabIndex = 0;
			this.viewCar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewCar_CellClick);
			this.viewCar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewbooking_CellContentClick);
			// 
			// filerstatus
			// 
			this.filerstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.filerstatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.filerstatus.FormattingEnabled = true;
			this.filerstatus.Items.AddRange(new object[] {
            "Filer",
            "Non Filer"});
			this.filerstatus.Location = new System.Drawing.Point(99, 328);
			this.filerstatus.Name = "filerstatus";
			this.filerstatus.Size = new System.Drawing.Size(155, 36);
			this.filerstatus.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(78, 270);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(208, 31);
			this.label1.TabIndex = 2;
			this.label1.Text = "Select Filer Status: ";
			// 
			// pestimate
			// 
			this.pestimate.BackColor = System.Drawing.Color.Transparent;
			this.pestimate.FlatAppearance.BorderSize = 0;
			this.pestimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.pestimate.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pestimate.ForeColor = System.Drawing.Color.Transparent;
			this.pestimate.Location = new System.Drawing.Point(687, 524);
			this.pestimate.Name = "pestimate";
			this.pestimate.Size = new System.Drawing.Size(267, 40);
			this.pestimate.TabIndex = 3;
			this.pestimate.Text = "Get Price Estimation";
			this.pestimate.UseVisualStyleBackColor = false;
			this.pestimate.Click += new System.EventHandler(this.pestimate_Click);
			// 
			// back
			// 
			this.back.BackColor = System.Drawing.Color.Transparent;
			this.back.FlatAppearance.BorderSize = 0;
			this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.back.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.back.Location = new System.Drawing.Point(186, 524);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(87, 40);
			this.back.TabIndex = 4;
			this.back.Text = "Back";
			this.back.UseVisualStyleBackColor = false;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(410, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(586, 45);
			this.label2.TabIndex = 5;
			this.label2.Text = "Car Showroom Management System";
			// 
			// carDLBindingSource
			// 
			this.carDLBindingSource.DataSource = typeof(CSMS.DL.CarDL);
			// 
			// PriceEstimate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CSMS.Properties.Resources.A;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1282, 653);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.back);
			this.Controls.Add(this.pestimate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.filerstatus);
			this.Controls.Add(this.viewCar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "PriceEstimate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Price Estimatation";
			((System.ComponentModel.ISupportInitialize)(this.viewCar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.carDLBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView viewCar;
		private System.Windows.Forms.ComboBox filerstatus;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button pestimate;
		private System.Windows.Forms.Button back;
		private System.Windows.Forms.BindingSource carDLBindingSource;
		private System.Windows.Forms.Label label2;
	}
}