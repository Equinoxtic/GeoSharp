using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static GeoSharp.Lib.StringUtils;
using static GeoSharp.Lib.TimeLib;

namespace GeoSharp.Logging {
	internal class ConsoleMessage {
		public static string CreateConsoleMessage(string headerString, string messageString, bool quoted) {
			string s = "";
			s = String.Format("{0}: {1}",
				SurroundString(headerString, "[", "]"),
				((quoted) ? QuoteString(messageString) : messageString));
			return s.ToString();
		}

		public static string CreateTimedConsoleMessage(string headerString, string messageString, bool quoted) {
			string s = "";
			string cs = String.Format("{0} @ {1}", headerString, GetTime());
			s = String.Format("{0}: {1}",
				SurroundString(cs, "[", "]"),
				((quoted) ? QuoteString(messageString) : messageString));
			return s.ToString();
		}
	}
}
