using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace SamplePrograms.ResourcesData.Forms
{
	public partial class Circle
	{
		private IContainer IContainer_Components = null;


		protected override void Dispose(bool Bool_Disposing)
		{
			if (Bool_Disposing && (IContainer_Components != null))
			{ IContainer_Components.Dispose(); }

			base.Dispose(Bool_Disposing);
		}

		private void InitializeComponent()
		{
			this.Label_Delete = new Label();
			this.SuspendLayout();

			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(70)))));
			this.ClientSize = new Size(760, 540);
			this.Controls.Add(this.Label_Delete);
			this.FormBorderStyle = FormBorderStyle.None;
			this.Name = "Circle";
			this.Text = "Circle";
			this.Shown += new EventHandler(this.Form_Circle_Shown);
			this.ResumeLayout(false);

			this.Label_Delete.Dock = DockStyle.Fill;
			this.Label_Delete.Font = new Font("Microsoft Sans Serif", 32F);
			this.Label_Delete.ForeColor = Color.White;
			this.Label_Delete.Location = new Point(0, 0);
			this.Label_Delete.Name = "Label_Delete";
			this.Label_Delete.Size = new Size(760, 540);
			this.Label_Delete.TabIndex = 0;
			this.Label_Delete.Text = "Circle";
			this.Label_Delete.TextAlign = ContentAlignment.MiddleCenter;
		}

		private Label Label_Delete;
	}
}