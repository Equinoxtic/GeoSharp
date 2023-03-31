using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using static GeoSharp.Lib.StringUtils;

namespace GeoSharp.GStd.GSio {
	public static class GeoStdioExt {
		private static string AutoFormat(string s, string end) {
			return (String.Format("{0}{1}", s, end).ToString());
		}

		public static void RepeatPrint(string s, int length = 1, string end = "\n") {
			Console.Write(AutoFormat(RepeatString(s, length), end));
		}

		public static void PrintIntBool(int x, string end = "\n") {
			string s = "";

			if (x == 0) {
				s = "false";
			} else if (x >= 1 || x < 0) {
				s = "true";
			}
			
			Console.Write(AutoFormat(s, end));
		}
	}
}
