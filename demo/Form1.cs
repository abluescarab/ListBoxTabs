using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxTabs_test {
	public partial class Form1 : Form {
		Label label1 = new Label();
		Label label2 = new Label();

		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			CreateControls();
			InitializeLBT();
		}

		private void InitializeLBT() {
			listBoxTabs.ListBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;

			listBoxTabs.ListBox.Items.Add("Test 1");
			listBoxTabs.ListBox.Items.Add("Test 2");

			listBoxTabs.ListBox.SelectedIndex = 0;
			listBoxTabs.BorderOffset = 3;
			listBoxTabs.ListBox.ItemHeight = 50;

			listBoxTabs.BackColor = this.BackColor;
			listBoxTabs.UnselectedBackColor = this.BackColor;
			listBoxTabs.UnselectedBorderColor = this.BackColor;
		}

		private void ListBox_SelectedIndexChanged(object sender, EventArgs e) {
			switch(((ListBox)sender).SelectedIndex) {
				case 0:
					FirstFunction();
					break;
				case 1:
					SecondFunction();
					break;
			}
		}

		private void CreateControls() {
			label1.Text = "Label 1";
			label2.Text = "Label 2";
			label1.Location = label2.Location = new Point(listBoxTabs.Width + 20, 10);
			this.Controls.Add(label1);
			this.Controls.Add(label2);
			HideAllControls();
		}

		private void HideAllControls() {
			foreach(Control c in this.Controls) {
                if(c.GetType() != typeof(ListBoxTabs.ListBoxTabs)) {
					c.Hide();
				}
			}
		}

		private void FirstFunction() {
			if(this.Controls.Count > 0) {
				HideAllControls();
			}

			label1.Show();
		}

		private void SecondFunction() {
			if(this.Controls.Count > 0) {
				HideAllControls();
			}

			label2.Show();
		}
	}
}
