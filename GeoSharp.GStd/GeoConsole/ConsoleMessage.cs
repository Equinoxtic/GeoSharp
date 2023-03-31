using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using static GeoSharp.Lib.StringUtils;

namespace GeoSharp.GStd.GeoConsole {

	public class ConsoleMessageObject {
		public string msgData = "";
	}

	public static class ConsoleMessage {
		public static string createConsoleMessage(int type = 1, string msg = "", bool quoted = false) {
			string msgString = "";
			string typeString = "";

			switch(type) {
				case 1: typeString = "CONSOLE"; break;
				case 2: typeString = "WARNING"; break;
				case 3: typeString = "ERROR"; break;
				case 4: typeString = "INFO"; break;
			}

			if (!StringEmpty(msg)) {
				msgString = String.Format("{0}: {1}", SurroundString(typeString, "[", "]"), ((quoted) ? QuoteString(msg) : msg));
			}

			return msgString;
		}

		public static void setConsoleMessage(ConsoleMessageObject cmo, int type = 1, string msg = "", bool quoted = false) {
			cmo.msgData = createConsoleMessage(type, msg, quoted);
		}

		public static void outputConsoleMessage(ConsoleMessageObject cmo) {
			Console.Write(cmo.msgData);
		}
	}
}
