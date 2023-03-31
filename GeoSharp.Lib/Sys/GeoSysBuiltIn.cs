using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using static GeoSharp.Lib.Sys.GeoSys;

namespace GeoSharp.Lib.Sys {
	internal class GeoSysBuiltIn {
		public static void ClearScreen() {
			if (IsOperatingSystem("Windows")) {
				ExecuteCommand("cls");
			} else {
				ExecuteCommand("clear");
			}
 		}

		public static void SystemPause() {
			Console.ReadKey();
		}

		public static void SystemPauseExit() {
			Console.ReadKey();
			System.Environment.Exit(0);
		}

		public static void SystemExit() {
			System.Environment.Exit(0);
		}
	}
}
