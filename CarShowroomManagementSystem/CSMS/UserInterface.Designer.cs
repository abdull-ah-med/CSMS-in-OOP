namespace CSMS
{
	partial class UserInterface
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
			this.employeeDataView = new System.Windows.Forms.DataGridView();
			this.uID = new System.Windows.Forms.Label();
			this.upass = new System.Windows.Forms.Label();
			this.ucontact = new System.Windows.Forms.Label();
			this.uname = new System.Windows.Forms.Label();
			this.userid = new System.Windows.Forms.TextBox();
			this.userpass = new System.Windows.Forms.TextBox();
			this.username = new System.Windows.Forms.TextBox();
			this.usercontact = new System.Windows.Forms.TextBox();
			this.addUser = new System.Windows.Forms.Button();
			this.editUser = new System.Windows.Forms.Button();
			this.removeUser = new System.Windows.Forms.Button();
			this.usertype = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.back = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.employeeDataView)).BeginInit();
			this.SuspendLayout();
			// 
			// employeeDataView
			// 
			this.employeeDataView.AllowUserToAddRows = false;
			this.employeeDataView.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
			this.employeeDataView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.employeeDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.employeeDataView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.employeeDataView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.employeeDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.employeeDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDark;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.employeeDataView.DefaultCellStyle = dataGridViewCellStyle3;
			this.employeeDataView.Location = new System.Drawing.Point(583, 194);
			this.employeeDataView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.employeeDataView.Name = "employeeDataView";
			this.employeeDataView.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.employeeDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.employeeDataView.RowHeadersWidth = 51;
			this.employeeDataView.RowTemplate.Height = 24;
			this.employeeDataView.Size = new System.Drawing.Size(602, 331);
			this.employeeDataView.TabIndex = 0;
			this.employeeDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDataView_CellClick);
			this.employeeDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDataView_CellContentClick);
			// 
			// uID
			// 
			this.uID.AutoSize = true;
			this.uID.BackColor = System.Drawing.Color.Transparent;
			this.uID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.uID.ForeColor = System.Drawing.Color.Transparent;
			this.uID.Location = new System.Drawing.Point(93, 215);
			this.uID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.uID.Name = "uID";
			this.uID.Size = new System.Drawing.Size(93, 31);
			this.uID.TabIndex = 1;
			this.uID.Text = "User ID:";
			// 
			// upass
			// 
			this.upass.AutoSize = true;
			this.upass.BackColor = System.Drawing.Color.Transparent;
			this.upass.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.upass.ForeColor = System.Drawing.Color.Transparent;
			this.upass.Location = new System.Drawing.Point(93, 286);
			this.upass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.upass.Name = "upass";
			this.upass.Size = new System.Drawing.Size(167, 31);
			this.upass.TabIndex = 2;
			this.upass.Text = "User Password:";
			// 
			// ucontact
			// 
			this.ucontact.AutoSize = true;
			this.ucontact.BackColor = System.Drawing.Color.Transparent;
			this.ucontact.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ucontact.ForeColor = System.Drawing.Color.Transparent;
			this.ucontact.Location = new System.Drawing.Point(93, 425);
			this.ucontact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ucontact.Name = "ucontact";
			this.ucontact.Size = new System.Drawing.Size(150, 31);
			this.ucontact.TabIndex = 3;
			this.ucontact.Text = "User Contact:";
			// 
			// uname
			// 
			this.uname.AutoSize = true;
			this.uname.BackColor = System.Drawing.Color.Transparent;
			this.uname.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.uname.ForeColor = System.Drawing.Color.Transparent;
			this.uname.Location = new System.Drawing.Point(93, 355);
			this.uname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.uname.Name = "uname";
			this.uname.Size = new System.Drawing.Size(138, 31);
			this.uname.TabIndex = 4;
			this.uname.Text = "User Name: ";
			// 
			// userid
			// 
			this.userid.Location = new System.Drawing.Point(320, 212);
			this.userid.Name = "userid";
			this.userid.Size = new System.Drawing.Size(217, 34);
			this.userid.TabIndex = 5;
			// 
			// userpass
			// 
			this.userpass.Location = new System.Drawing.Point(320, 283);
			this.userpass.Name = "userpass";
			this.userpass.Size = new System.Drawing.Size(217, 34);
			this.userpass.TabIndex = 6;
			// 
			// username
			// 
			this.username.Location = new System.Drawing.Point(320, 352);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(217, 34);
			this.username.TabIndex = 7;
			// 
			// usercontact
			// 
			this.usercontact.Location = new System.Drawing.Point(320, 422);
			this.usercontact.Name = "usercontact";
			this.usercontact.Size = new System.Drawing.Size(217, 34);
			this.usercontact.TabIndex = 8;
			// 
			// addUser
			// 
			this.addUser.BackColor = System.Drawing.Color.Transparent;
			this.addUser.FlatAppearance.BorderSize = 0;
			this.addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addUser.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.addUser.Location = new System.Drawing.Point(634, 566);
			this.addUser.Name = "addUser";
			this.addUser.Size = new System.Drawing.Size(120, 41);
			this.addUser.TabIndex = 9;
			this.addUser.Text = "Add User";
			this.addUser.UseVisualStyleBackColor = false;
			this.addUser.Click += new System.EventHandler(this.addUser_Click);
			// 
			// editUser
			// 
			this.editUser.BackColor = System.Drawing.Color.Transparent;
			this.editUser.FlatAppearance.BorderSize = 0;
			this.editUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.editUser.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.editUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.editUser.Location = new System.Drawing.Point(808, 566);
			this.editUser.Name = "editUser";
			this.editUser.Size = new System.Drawing.Size(110, 41);
			this.editUser.TabIndex = 10;
			this.editUser.Text = "Edit User";
			this.editUser.UseVisualStyleBackColor = false;
			this.editUser.Click += new System.EventHandler(this.editUser_Click);
			// 
			// removeUser
			// 
			this.removeUser.BackColor = System.Drawing.Color.Transparent;
			this.removeUser.FlatAppearance.BorderSize = 0;
			this.removeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.removeUser.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.removeUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.removeUser.Location = new System.Drawing.Point(963, 566);
			this.removeUser.Name = "removeUser";
			this.removeUser.Size = new System.Drawing.Size(165, 41);
			this.removeUser.TabIndex = 11;
			this.removeUser.Text = "Remove User";
			this.removeUser.UseVisualStyleBackColor = false;
			this.removeUser.Click += new System.EventHandler(this.removeUser_Click);
			// 
			// usertype
			// 
			this.usertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.usertype.FormattingEnabled = true;
			this.usertype.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
			this.usertype.Location = new System.Drawing.Point(320, 489);
			this.usertype.Name = "usertype";
			this.usertype.Size = new System.Drawing.Size(217, 36);
			this.usertype.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(93, 494);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 31);
			this.label1.TabIndex = 13;
			this.label1.Text = "User Type:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(369, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(599, 46);
			this.label2.TabIndex = 14;
			this.label2.Text = "Car Showroom Management System";
			// 
			// back
			// 
			this.back.BackColor = System.Drawing.Color.Transparent;
			this.back.FlatAppearance.BorderSize = 0;
			this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.back.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.back.Location = new System.Drawing.Point(99, 604);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(120, 41);
			this.back.TabIndex = 15;
			this.back.Text = "Back";
			this.back.UseVisualStyleBackColor = false;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// UserInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CSMS.Properties.Resources.A;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1282, 703);
			this.Controls.Add(this.back);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.usertype);
			this.Controls.Add(this.removeUser);
			this.Controls.Add(this.editUser);
			this.Controls.Add(this.addUser);
			this.Controls.Add(this.usercontact);
			this.Controls.Add(this.username);
			this.Controls.Add(this.userpass);
			this.Controls.Add(this.userid);
			this.Controls.Add(this.uname);
			this.Controls.Add(this.ucontact);
			this.Controls.Add(this.upass);
			this.Controls.Add(this.uID);
			this.Controls.Add(this.employeeDataView);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "UserInterface";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Admin > User Interface";
			this.Load += new System.EventHandler(this.UserInterface_Load);
			((System.ComponentModel.ISupportInitialize)(this.employeeDataView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView employeeDataView;
		private System.Windows.Forms.Label uID;
		private System.Windows.Forms.Label upass;
		private System.Windows.Forms.Label ucontact;
		private System.Windows.Forms.Label uname;
		private System.Windows.Forms.TextBox userid;
		private System.Windows.Forms.TextBox userpass;
		private System.Windows.Forms.TextBox username;
		private System.Windows.Forms.TextBox usercontact;
		private System.Windows.Forms.Button addUser;
		private System.Windows.Forms.Button editUser;
		private System.Windows.Forms.Button removeUser;
		private System.Windows.Forms.ComboBox usertype;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button back;
	}
}