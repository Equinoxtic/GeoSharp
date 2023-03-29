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
		public void logMessage(string messageString, string logFile, bool hasTime = true) {
			string defaultMessageHeader = "CONSOLE";
			string s = "";
			if (!stringEmpty(messageString)) {
				if (hasTime) {
					s = createTimedConsoleMessage(defaultMessageHeader, messageString, true);
				} else {
					s = createConsoleMessage(defaultMessageHeader, messageString, true);
				}
				writeToFile(logFile, s);
			}
		}

		public void clearLogFile(string path) {
			clearFile(path);
		}
	}
}
