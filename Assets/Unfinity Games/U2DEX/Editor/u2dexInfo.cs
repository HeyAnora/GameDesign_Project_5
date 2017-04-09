using UnityEngine;
using System.Collections;
using UnityEditor;

namespace UnfinityGames.U2DEX
{
	/// <summary>
	/// Contains all of the info (metadata, really) for this plugin/addon.
	/// </summary>
	public static class u2dexInfo
	{
		public const double version = 1.40;
		private const string releaseType = "Release";
		private const string releaseDate = "January 2016";

		public const string UpdateFileURL = "http://www.unfinitygames.com/u2dex/version_info.xml";

		public const string FullName = "Unity 2D Editor Extensions";
		public const string AbbreviatedName = "U2DEX";

		public const string ForumURL = "http://www.unfinitygames.com/interact";

		public const string CompanyName = "Unfinity Games";

		public static string ReleaseStringIdentifier(double _version)
		{
			string id = _version.ToString("0.00");
			id += " " + releaseType;
			return id;
		}		

		public static void AboutU2DEX()
		{
			EditorUtility.DisplayDialog("About " + FullName,
										"Version: "
										+ ReleaseStringIdentifier(version) + "\n" +
										"Released: " + releaseDate + "\n\n" +
										"Copyright " + "\u00A9"+" 2013-2016 " + CompanyName,
										"Close");
		}

		public static void OpenForum()
		{
			Application.OpenURL(ForumURL);
		}
	}
}
