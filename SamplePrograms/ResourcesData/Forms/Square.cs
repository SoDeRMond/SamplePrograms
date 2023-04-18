using SamplePrograms.ResourcesData.Source.Core;
using System.Windows.Forms;
using System;

namespace SamplePrograms.ResourcesData.Forms
{
	public partial class Square : Form
	{
		public Square()
		{ InitializeComponent(); }

		private void Form_Square_Shown(object Object_Form, EventArgs EventArgs_Shown)
		{ Classes.Class_LocalizationManager.Forms_Translate(); }
	}
}