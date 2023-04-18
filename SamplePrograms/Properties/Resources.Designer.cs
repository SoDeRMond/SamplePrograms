namespace SamplePrograms.Properties
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]


	internal class Resources
	{
		private static global::System.Resources.ResourceManager ResourceManager_SamplePrograms;
		private static global::System.Globalization.CultureInfo CultureInfo_SamplePrograms;


		[global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
		internal Resources() { }

		[global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager_Cache
		{
			get
			{
				if (object.ReferenceEquals(ResourceManager_SamplePrograms, null))
				{
					global::System.Resources.ResourceManager ResourceManager_Temp = new global::System.Resources.ResourceManager("SamplePrograms.Properties.Resources", typeof(Resources).Assembly);
					ResourceManager_SamplePrograms = ResourceManager_Temp;
				}

				return ResourceManager_SamplePrograms;
			}
		}

		[global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo CultureInfo_Rewrite
		{
			get { return CultureInfo_SamplePrograms; }
			set { CultureInfo_SamplePrograms = value; }
		}

		internal static System.Drawing.Bitmap Square_Colored
		{
			get
			{
				object Object_Bitmap = ResourceManager_Cache.GetObject("Square_Colored", CultureInfo_Rewrite);
				return ((System.Drawing.Bitmap)(Object_Bitmap));
			}
		}

		internal static System.Drawing.Bitmap Circle_Colored
		{
			get
			{
				object Object_Bitmap = ResourceManager_Cache.GetObject("Circle_Colored", CultureInfo_Rewrite);
				return ((System.Drawing.Bitmap)(Object_Bitmap));
			}
		}

		internal static System.Drawing.Bitmap Settings_Colored
		{
			get
			{
				object Object_Bitmap = ResourceManager_Cache.GetObject("Settings_Colored", CultureInfo_Rewrite);
				return ((System.Drawing.Bitmap)(Object_Bitmap));
			}
		}

		internal static System.Drawing.Bitmap Square_White
		{
			get
			{
				object Object_Bitmap = ResourceManager_Cache.GetObject("Square_White", CultureInfo_Rewrite);
				return ((System.Drawing.Bitmap)(Object_Bitmap));
			}
		}

		internal static System.Drawing.Bitmap Circle_White
		{
			get
			{
				object Object_Bitmap = ResourceManager_Cache.GetObject("Circle_White", CultureInfo_Rewrite);
				return ((System.Drawing.Bitmap)(Object_Bitmap));
			}
		}

		internal static System.Drawing.Bitmap Settings_White
		{
			get
			{
				object Object_Bitmap = ResourceManager_Cache.GetObject("Settings_White", CultureInfo_Rewrite);
				return ((System.Drawing.Bitmap)(Object_Bitmap));
			}
		}

		internal static System.Drawing.Bitmap LanguageSwitcher
		{
			get
			{
				object Object_Bitmap = ResourceManager_Cache.GetObject("LanguageSwitcher", CultureInfo_Rewrite);
				return ((System.Drawing.Bitmap)(Object_Bitmap));
			}
		}

		internal static string Localization
		{
			get { return ResourceManager_Cache.GetString("Localization", CultureInfo_Rewrite); }
		}
	}
}