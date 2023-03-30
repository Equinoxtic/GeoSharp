using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static GeoSharp.Common.Resources;
using static GeoSharp.Logging.ConsoleMessage;
using static GeoSharp.Lib.StringUtils;
using static GeoSharp.FS.GeoFile;
using static GeoSharp.FS.GeoFileUtils;

namespace GeoSharp.Logging {
	internal class ConsoleLogging {
		public void LogMessage(string messageString, string logFile, bool hasTime = true) {
			string defaultMessageHeader = "CONSOLE";
			string s = "";
			if (!StringEmpty(messageString)) {
				if (hasTime) {
					s = CreateTimedConsoleMessage(defaultMessageHeader, messageString, true);
				} else {
					s = CreateConsoleMessage(defaultMessageHeader, messageString, true);
				}
				WriteToFile(logFile, s);
			}
		}

		public void ClearLogFile(string path) {
			ClearFile(path);
		}
	}
}
