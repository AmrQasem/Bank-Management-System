namespace Bank_Mangement_System
{
    partial class Form4
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
			this.lblName = new System.Windows.Forms.Label();
			this.lblID = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.lblPhone = new System.Windows.Forms.Label();
			this.lblCollege = new System.Windows.Forms.Label();
			this.lblYear = new System.Windows.Forms.Label();
			this.lblDegree = new System.Windows.Forms.Label();
			this.lblPosition = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtCollege = new System.Windows.Forms.TextBox();
			this.txtYear = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.ComboxDegree = new System.Windows.Forms.ComboBox();
			this.ComboxPosition = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(21, 38);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(49, 16);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name";
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblID.Location = new System.Drawing.Point(21, 75);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(31, 16);
			this.lblID.TabIndex = 1;
			this.lblID.Text = "ID :";
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAddress.Location = new System.Drawing.Point(21, 117);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(74, 16);
			this.lblAddress.TabIndex = 2;
			this.lblAddress.Text = "Address :";
			// 
			// lblPhone
			// 
			this.lblPhone.AutoSize = true;
			this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPhone.Location = new System.Drawing.Point(21, 162);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(60, 16);
			this.lblPhone.TabIndex = 3;
			this.lblPhone.Text = "Phone :";
			// 
			// lblCollege
			// 
			this.lblCollege.AutoSize = true;
			this.lblCollege.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCollege.Location = new System.Drawing.Point(21, 203);
			this.lblCollege.Name = "lblCollege";
			this.lblCollege.Size = new System.Drawing.Size(74, 16);
			this.lblCollege.TabIndex = 4;
			this.lblCollege.Text = "College : ";
			// 
			// lblYear
			// 
			this.lblYear.AutoSize = true;
			this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblYear.Location = new System.Drawing.Point(21, 246);
			this.lblYear.Name = "lblYear";
			this.lblYear.Size = new System.Drawing.Size(129, 16);
			this.lblYear.TabIndex = 5;
			this.lblYear.Text = "Graduation Year :";
			// 
			// lblDegree
			// 
			this.lblDegree.AutoSize = true;
			this.lblDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDegree.Location = new System.Drawing.Point(21, 294);
			this.lblDegree.Name = "lblDegree";
			this.lblDegree.Size = new System.Drawing.Size(112, 16);
			this.lblDegree.TabIndex = 6;
			this.lblDegree.Text = "Total Degree : ";
			// 
			// lblPosition
			// 
			this.lblPosition.AutoSize = true;
			this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPosition.Location = new System.Drawing.Point(21, 336);
			this.lblPosition.Name = "lblPosition";
			this.lblPosition.Size = new System.Drawing.Size(72, 16);
			this.lblPosition.TabIndex = 7;
			this.lblPosition.Text = "Position :";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(166, 37);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(149, 20);
			this.txtName.TabIndex = 8;
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(166, 71);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(149, 20);
			this.txtID.TabIndex = 9;
			this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(166, 113);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(149, 20);
			this.txtAddress.TabIndex = 10;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(166, 158);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(149, 20);
			this.txtPhone.TabIndex = 11;
			this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
			// 
			// txtCollege
			// 
			this.txtCollege.Location = new System.Drawing.Point(166, 199);
			this.txtCollege.Name = "txtCollege";
			this.txtCollege.Size = new System.Drawing.Size(149, 20);
			this.txtCollege.TabIndex = 12;
			// 
			// txtYear
			// 
			this.txtYear.Location = new System.Drawing.Point(166, 246);
			this.txtYear.Name = "txtYear";
			this.txtYear.Size = new System.Drawing.Size(149, 20);
			this.txtYear.TabIndex = 13;
			this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.PapayaWhip;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(304, 375);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(96, 32);
			this.btnAdd.TabIndex = 16;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.PapayaWhip;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(24, 375);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(96, 32);
			this.btnCancel.TabIndex = 17;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// ComboxDegree
			// 
			this.ComboxDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboxDegree.FormattingEnabled = true;
			this.ComboxDegree.Items.AddRange(new object[] {
            "Excellent",
            "Very Good",
            "Good",
            "Reasonable"});
			this.ComboxDegree.Location = new System.Drawing.Point(166, 289);
			this.ComboxDegree.Name = "ComboxDegree";
			this.ComboxDegree.Size = new System.Drawing.Size(149, 21);
			this.ComboxDegree.TabIndex = 18;
			// 
			// ComboxPosition
			// 
			this.ComboxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboxPosition.FormattingEnabled = true;
			this.ComboxPosition.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
			this.ComboxPosition.Items.AddRange(new object[] {
            "HR",
            "PR",
            "IT",
            "Teller"});
			this.ComboxPosition.Location = new System.Drawing.Point(166, 331);
			this.ComboxPosition.Name = "ComboxPosition";
			this.ComboxPosition.Size = new System.Drawing.Size(149, 21);
			this.ComboxPosition.TabIndex = 19;
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SeaShell;
			this.ClientSize = new System.Drawing.Size(423, 419);
			this.Controls.Add(this.ComboxPosition);
			this.Controls.Add(this.ComboxDegree);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtYear);
			this.Controls.Add(this.txtCollege);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblPosition);
			this.Controls.Add(this.lblDegree);
			this.Controls.Add(this.lblYear);
			this.Controls.Add(this.lblCollege);
			this.Controls.Add(this.lblPhone);
			this.Controls.Add(this.lblAddress);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.lblName);
			this.Name = "Form4";
			this.Text = "Add Employee";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCollege;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCollege;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox ComboxDegree;
        private System.Windows.Forms.ComboBox ComboxPosition;
    }
}