using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GeoSharp.GStd.GSio {
	public static class GStdio {
		private static void AutoFormat(string s, string end) {
			Console.Write(String.Format("{0}{1}", s, end).ToString());
		}

		public static void Print(string s, string end = "\n") {
			AutoFormat(s, end);
		}

		public static void Print(int s, string end = "\n") {
			AutoFormat(s.ToString(), end);
		}

		public static void Print(bool s, string end = "\n") {
			AutoFormat(s.ToString(), end);
		}
		
		public static void TimedPrint(ref string s, int length, int delay = 7, bool useSeconds = false) {
			for (int i = 0; i < length; ++i) {
				Console.Write(s[i]);
				if (!useSeconds) {
					Thread.Sleep(delay);
				} else {
					Thread.Sleep(delay * 1000);
				}
			}
		}
	}
}