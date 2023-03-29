using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static GeoSharp.FS.GeoFile;
using static GeoSharp.FS.GeoFileUtils;

namespace GeoSharp.Common {
	public static class Resources {
		public static string logFile = "";
		public static string getLogFile() {
			return logFile;
		}
	}
}
