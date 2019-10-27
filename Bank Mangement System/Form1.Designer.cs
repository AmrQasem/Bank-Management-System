namespace Bank_Mangement_System
{
    partial class Form1
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
			this.lblEnter = new System.Windows.Forms.Label();
			this.btnClient = new System.Windows.Forms.Button();
			this.btnEmployee = new System.Windows.Forms.Button();
			this.Exit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblEnter
			// 
			this.lblEnter.AutoSize = true;
			this.lblEnter.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEnter.Location = new System.Drawing.Point(131, 70);
			this.lblEnter.Name = "lblEnter";
			this.lblEnter.Size = new System.Drawing.Size(101, 25);
			this.lblEnter.TabIndex = 0;
			this.lblEnter.Text = "Log in as :";
			// 
			// btnClient
			// 
			this.btnClient.BackColor = System.Drawing.Color.PapayaWhip;
			this.btnClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.btnClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClient.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClient.Location = new System.Drawing.Point(96, 121);
			this.btnClient.Name = "btnClient";
			this.btnClient.Size = new System.Drawing.Size(160, 68);
			this.btnClient.TabIndex = 1;
			this.btnClient.Text = "Client";
			this.btnClient.UseVisualStyleBackColor = false;
			this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
			// 
			// btnEmployee
			// 
			this.btnEmployee.BackColor = System.Drawing.Color.PapayaWhip;
			this.btnEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.btnEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEmployee.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEmployee.Location = new System.Drawing.Point(96, 223);
			this.btnEmployee.Name = "btnEmployee";
			this.btnEmployee.Size = new System.Drawing.Size(160, 68);
			this.btnEmployee.TabIndex = 2;
			this.btnEmployee.Text = "Employee";
			this.btnEmployee.UseVisualStyleBackColor = false;
			this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
			// 
			// Exit
			// 
			this.Exit.BackColor = System.Drawing.Color.SeaShell;
			this.Exit.BackgroundImage = global::Bank_Mangement_System.Properties.Resources.Logout_512;
			this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Exit.FlatAppearance.BorderSize = 0;
			this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PapayaWhip;
			this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Exit.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Exit.Location = new System.Drawing.Point(317, 3);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(40, 36);
			this.Exit.TabIndex = 3;
			this.Exit.UseVisualStyleBackColor = false;
			this.Exit.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SeaShell;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(360, 332);
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.btnEmployee);
			this.Controls.Add(this.btnClient);
			this.Controls.Add(this.lblEnter);
			this.DoubleBuffered = true;
			this.Name = "Form1";
			this.Text = "Registration";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button Exit;
    }
}

