using SamplePrograms.ResourcesData.Source.Root;
using System.Windows.Forms;
using System;

namespace SamplePrograms.ResourcesData.Forms
{
	public partial class Circle : Form
	{
		public Circle()
		{ InitializeComponent(); }

		private void Form_Circle_Shown(object Object_Form, EventArgs EventArgs_Shown)
		{ Classes.Class_LocalizationManager.Forms_Translate(); }
	}
}