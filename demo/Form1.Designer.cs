namespace ListBoxTabs_test {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.listBoxTabs = new CustomControls.ListBoxTabs.ListBoxTabs();
			this.SuspendLayout();
			// 
			// listBoxTabs
			// 
			this.listBoxTabs.Dock = System.Windows.Forms.DockStyle.Left;
			this.listBoxTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxTabs.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
			this.listBoxTabs.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(174)))), ((int)(((byte)(229)))));
			this.listBoxTabs.HoverForeColor = System.Drawing.SystemColors.WindowText;
			this.listBoxTabs.Location = new System.Drawing.Point(0, 0);
			this.listBoxTabs.Name = "listBoxTabs";
			this.listBoxTabs.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(212)))), ((int)(((byte)(244)))));
			this.listBoxTabs.SelectedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
			this.listBoxTabs.SelectedForeColor = System.Drawing.SystemColors.WindowText;
			this.listBoxTabs.Size = new System.Drawing.Size(150, 261);
			this.listBoxTabs.TabIndex = 0;
			this.listBoxTabs.UnselectedBackColor = System.Drawing.SystemColors.Window;
			this.listBoxTabs.UnselectedBorderColor = System.Drawing.SystemColors.Window;
			this.listBoxTabs.UnselectedForeColor = System.Drawing.SystemColors.WindowText;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(353, 261);
			this.Controls.Add(this.listBoxTabs);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

        private CustomControls.ListBoxTabs.ListBoxTabs listBoxTabs;

	}
}

