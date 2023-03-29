using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using static GeoSharp.Lib.Sys.GeoSys;

namespace GeoSharp.Lib.Sys {
	internal class GeoSysBuiltIn {
		public static void clearScreen() {
			if (IsOperatingSystem("Windows")) {
				ExecuteCommand("cls");
			} else {
				ExecuteCommand("clear");
			}
 		}

		public static void systemPause() {
			if (IsOperatingSystem("Windows")) {
				ExecuteCommand("pause");
			} else {
				ExecuteCommand("read");
			}
		}

		public static void systemPauseExit() {
			if (IsOperatingSystem("Windows")) {
				ExecuteCommand("pause");
			} else {
				ExecuteCommand("read");
			}
			System.Environment.Exit(0);
		}

		public static void systemExit() {
			System.Environment.Exit(0);
		}
	}
}
