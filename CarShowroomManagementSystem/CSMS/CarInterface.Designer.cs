namespace CSMS
{
	partial class CarInterface
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarInterface));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.carname = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.carcolor = new System.Windows.Forms.TextBox();
			this.carvariant = new System.Windows.Forms.TextBox();
			this.carprice = new System.Windows.Forms.TextBox();
			this.filertax = new System.Windows.Forms.TextBox();
			this.nonfilertax = new System.Windows.Forms.TextBox();
			this.addCar = new System.Windows.Forms.Button();
			this.editCar = new System.Windows.Forms.Button();
			this.rmCar = new System.Windows.Forms.Button();
			this.carData = new System.Windows.Forms.DataGridView();
			this.back = new System.Windows.Forms.Button();
			this.caravailable = new System.Windows.Forms.Label();
			this.iscaravailable = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.carData)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(14, 112);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Car Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(14, 242);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 30);
			this.label2.TabIndex = 1;
			this.label2.Text = "Car Variant";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new System.Drawing.Point(14, 304);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(106, 30);
			this.label3.TabIndex = 2;
			this.label3.Text = "Car Price";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label4.Location = new System.Drawing.Point(14, 173);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(109, 30);
			this.label4.TabIndex = 3;
			this.label4.Text = "Car Color";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label5.Location = new System.Drawing.Point(14, 430);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(147, 30);
			this.label5.TabIndex = 4;
			this.label5.Text = "Non Filer Tax";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// carname
			// 
			this.carname.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.carname.Location = new System.Drawing.Point(182, 112);
			this.carname.Name = "carname";
			this.carname.Size = new System.Drawing.Size(171, 31);
			this.carname.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label6.Location = new System.Drawing.Point(14, 366);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(98, 30);
			this.label6.TabIndex = 5;
			this.label6.Text = "Filer Tax\r\n";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// carcolor
			// 
			this.carcolor.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.carcolor.Location = new System.Drawing.Point(182, 173);
			this.carcolor.Name = "carcolor";
			this.carcolor.Size = new System.Drawing.Size(171, 31);
			this.carcolor.TabIndex = 7;
			this.carcolor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// carvariant
			// 
			this.carvariant.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.carvariant.Location = new System.Drawing.Point(182, 241);
			this.carvariant.Name = "carvariant";
			this.carvariant.Size = new System.Drawing.Size(171, 31);
			this.carvariant.TabIndex = 8;
			// 
			// carprice
			// 
			this.carprice.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.carprice.Location = new System.Drawing.Point(182, 303);
			this.carprice.Name = "carprice";
			this.carprice.Size = new System.Drawing.Size(171, 31);
			this.carprice.TabIndex = 9;
			this.carprice.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// filertax
			// 
			this.filertax.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.filertax.Location = new System.Drawing.Point(182, 366);
			this.filertax.Name = "filertax";
			this.filertax.Size = new System.Drawing.Size(171, 31);
			this.filertax.TabIndex = 10;
			// 
			// nonfilertax
			// 
			this.nonfilertax.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nonfilertax.Location = new System.Drawing.Point(182, 430);
			this.nonfilertax.Name = "nonfilertax";
			this.nonfilertax.Size = new System.Drawing.Size(171, 31);
			this.nonfilertax.TabIndex = 11;
			// 
			// addCar
			// 
			this.addCar.BackColor = System.Drawing.Color.Transparent;
			this.addCar.FlatAppearance.BorderSize = 0;
			this.addCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addCar.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addCar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.addCar.Location = new System.Drawing.Point(580, 549);
			this.addCar.Name = "addCar";
			this.addCar.Size = new System.Drawing.Size(121, 46);
			this.addCar.TabIndex = 12;
			this.addCar.Text = "Add Car";
			this.addCar.UseVisualStyleBackColor = false;
			this.addCar.Click += new System.EventHandler(this.addCar_Click);
			// 
			// editCar
			// 
			this.editCar.BackColor = System.Drawing.Color.Transparent;
			this.editCar.FlatAppearance.BorderSize = 0;
			this.editCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.editCar.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.editCar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.editCar.Location = new System.Drawing.Point(764, 549);
			this.editCar.Name = "editCar";
			this.editCar.Size = new System.Drawing.Size(163, 46);
			this.editCar.TabIndex = 13;
			this.editCar.Text = "Edit Car Info";
			this.editCar.UseVisualStyleBackColor = false;
			this.editCar.Click += new System.EventHandler(this.editCar_Click);
			// 
			// rmCar
			// 
			this.rmCar.BackColor = System.Drawing.Color.Transparent;
			this.rmCar.FlatAppearance.BorderSize = 0;
			this.rmCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rmCar.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rmCar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.rmCar.Location = new System.Drawing.Point(988, 549);
			this.rmCar.Name = "rmCar";
			this.rmCar.Size = new System.Drawing.Size(148, 46);
			this.rmCar.TabIndex = 14;
			this.rmCar.Text = "Remove Car";
			this.rmCar.UseVisualStyleBackColor = false;
			this.rmCar.Click += new System.EventHandler(this.rmCar_Click);
			// 
			// carData
			// 
			this.carData.AllowDrop = true;
			this.carData.AllowUserToAddRows = false;
			this.carData.AllowUserToDeleteRows = false;
			this.carData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.carData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.carData.Location = new System.Drawing.Point(379, 107);
			this.carData.Name = "carData";
			this.carData.ReadOnly = true;
			this.carData.RowHeadersWidth = 51;
			this.carData.RowTemplate.Height = 24;
			this.carData.Size = new System.Drawing.Size(891, 396);
			this.carData.TabIndex = 15;
			this.carData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carData_CellClick);
			this.carData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carData_CellContentClick);
			// 
			// back
			// 
			this.back.BackColor = System.Drawing.Color.Transparent;
			this.back.FlatAppearance.BorderSize = 0;
			this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.back.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.back.Location = new System.Drawing.Point(420, 551);
			this.back.Margin = new System.Windows.Forms.Padding(0);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(95, 44);
			this.back.TabIndex = 16;
			this.back.Text = "Back";
			this.back.UseVisualStyleBackColor = false;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// caravailable
			// 
			this.caravailable.AutoSize = true;
			this.caravailable.BackColor = System.Drawing.Color.Transparent;
			this.caravailable.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.caravailable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.caravailable.Location = new System.Drawing.Point(14, 490);
			this.caravailable.Name = "caravailable";
			this.caravailable.Size = new System.Drawing.Size(108, 30);
			this.caravailable.TabIndex = 17;
			this.caravailable.Text = "Available";
			// 
			// iscaravailable
			// 
			this.iscaravailable.AllowDrop = true;
			this.iscaravailable.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.iscaravailable.FormattingEnabled = true;
			this.iscaravailable.Items.AddRange(new object[] {
            "Yes",
            "No"});
			this.iscaravailable.Location = new System.Drawing.Point(182, 487);
			this.iscaravailable.Name = "iscaravailable";
			this.iscaravailable.Size = new System.Drawing.Size(171, 33);
			this.iscaravailable.TabIndex = 18;
			this.iscaravailable.SelectedIndexChanged += new System.EventHandler(this.iscaravailable_SelectedIndexChanged);
			// 
			// CarInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CSMS.Properties.Resources.A;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1282, 703);
			this.Controls.Add(this.iscaravailable);
			this.Controls.Add(this.caravailable);
			this.Controls.Add(this.back);
			this.Controls.Add(this.carData);
			this.Controls.Add(this.rmCar);
			this.Controls.Add(this.editCar);
			this.Controls.Add(this.addCar);
			this.Controls.Add(this.nonfilertax);
			this.Controls.Add(this.filertax);
			this.Controls.Add(this.carprice);
			this.Controls.Add(this.carvariant);
			this.Controls.Add(this.carcolor);
			this.Controls.Add(this.carname);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CarInterface";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Car Showroom Management System";
			this.Load += new System.EventHandler(this.Form5_Load);
			((System.ComponentModel.ISupportInitialize)(this.carData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox carname;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox carcolor;
		private System.Windows.Forms.TextBox carvariant;
		private System.Windows.Forms.TextBox carprice;
		private System.Windows.Forms.TextBox filertax;
		private System.Windows.Forms.TextBox nonfilertax;
		private System.Windows.Forms.Button addCar;
		private System.Windows.Forms.Button editCar;
		private System.Windows.Forms.Button rmCar;
		private System.Windows.Forms.DataGridView carData;
		private System.Windows.Forms.Button back;
		private System.Windows.Forms.Label caravailable;
		private System.Windows.Forms.ComboBox iscaravailable;
	}
}