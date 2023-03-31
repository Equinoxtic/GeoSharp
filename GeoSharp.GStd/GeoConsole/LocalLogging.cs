using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using static GeoSharp.Lib.StringUtils;
using static GeoSharp.FS.GeoFile;
using static GeoSharp.FS.GeoFileUtils;
using GeoSharp.GStd.GeoConsole;

namespace GeoSharp.GStd.GeoConsole {
	public static class LocalLogging {
		public static void LogMessageToFile(ConsoleMessageObject cmo, string path) {
			string fPath = GetFile(path);
			if (File.Exists(fPath)) {
				WriteToFile(fPath, cmo.msgData);
			}
		}

		public static void FlushFile(string path) {
			string fPath = GetFile(path);
			if (File.Exists(fPath)) {
				ClearFile(fPath);
			}
		}
	}
}
