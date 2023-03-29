using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static GeoSharp.Lib.StringUtils;
using static GeoSharp.Lib.TimeLib;

namespace GeoSharp.Logging {
	internal class ConsoleMessage {
		public static string createConsoleMessage(string headerString, string messageString, bool quoted) {
			string s = "";
			s = String.Format("{0}: {1}",
				surroundString(headerString, "[", "]"),
				((quoted) ? quoteString(messageString) : messageString));
			return s.ToString();
		}

		public static string createTimedConsoleMessage(string headerString, string messageString, bool quoted) {
			string s = "";
			string cs = String.Format("{0} @ {1}", headerString, getTime());
			s = String.Format("{0}: {1}",
				surroundString(cs, "[", "]"),
				((quoted) ? quoteString(messageString) : messageString));
			return s.ToString();
		}
	}
}
