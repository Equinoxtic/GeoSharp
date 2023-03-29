using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using static GeoSharp.Lib.StringUtils;


namespace GeoSharp.Lib.Sys {
	internal class GeoSys {
		[DllImport("msvcrt.dll")]
		public static extern int system(string format);

		public static void ExecuteCommand(string command, string args = "") {
			string s = command + args;
			system(s.ToString());
		}

		private static string GetOperatingSystem() {
			string os = "";
			if (Environment.OSVersion.Platform == PlatformID.Win32NT) {
				os = "Windows";
			} else if (Environment.OSVersion.Platform == PlatformID.Unix) {
				os = "Unix";
			} else if (Environment.OSVersion.Platform == PlatformID.Other) {
				os = "Other";
			}
			return os;
		}

		public static bool IsOperatingSystem(string os) {
			return (GetOperatingSystem() == os);
		}
	}
}
