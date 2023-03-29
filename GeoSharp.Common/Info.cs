using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static GeoSharp.FS.GeoFile;
using static GeoSharp.FS.GeoFileUtils;

namespace GeoSharp.Common {
	public static class Info {
		public static string versionFile = "version.txt";
		public static string versionTag = "0.1";

		public static string getVersion() {
			return readFile(versionFile);
		}

		public static string getVersionTag() {
			return versionTag;
		}
	}
}
