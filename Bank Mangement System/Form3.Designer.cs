namespace Bank_Mangement_System
{
    partial class Form3
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
			this.btnClose = new System.Windows.Forms.Button();
			this.Log_out = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.PapayaWhip;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Location = new System.Drawing.Point(106, 80);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(221, 40);
			this.btnClose.TabIndex = 7;
			this.btnClose.Text = "Close Account";
			this.btnClose.UseVisualStyleBackColor = false;
			// 
			// Log_out
			// 
			this.Log_out.BackColor = System.Drawing.Color.PapayaWhip;
			this.Log_out.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.Log_out.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.Log_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Log_out.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Log_out.Location = new System.Drawing.Point(333, 12);
			this.Log_out.Name = "Log_out";
			this.Log_out.Size = new System.Drawing.Size(87, 40);
			this.Log_out.TabIndex = 8;
			this.Log_out.Text = "Logout";
			this.Log_out.UseVisualStyleBackColor = false;
			this.Log_out.Click += new System.EventHandler(this.Log_out_Click_1);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SeaShell;
			this.ClientSize = new System.Drawing.Size(432, 184);
			this.Controls.Add(this.Log_out);
			this.Controls.Add(this.btnClose);
			this.Name = "Form3";
			this.Text = "Choose";
			this.ResumeLayout(false);

        }

        #endregion
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button Log_out;
	}
}