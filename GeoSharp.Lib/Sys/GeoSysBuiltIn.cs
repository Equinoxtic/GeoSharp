using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using static GeoSharp.Lib.Sys.GeoSys;

namespace GeoSharp.Lib.Sys {
	internal class GeoSysBuiltIn {
		public static void clearScreen() {
			if (isOperatingSystem("Windows")) {
				executeCommand("cls");
			} else {
				executeCommand("clear");
			}
 		}

		public static void systemPause() {
			if (isOperatingSystem("Windows")) {
				executeCommand("pause");
			} else {
				executeCommand("read");
			}
		}

		public static void systemPauseExit() {
			if (isOperatingSystem("Windows")) {
				executeCommand("pause");
			} else {
				executeCommand("read");
			}
			System.Environment.Exit(0);
		}

		public static void systemExit() {
			System.Environment.Exit(0);
		}
	}
}
