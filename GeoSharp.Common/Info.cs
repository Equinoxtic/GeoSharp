using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static GeoSharp.FS.GeoFile;
using static GeoSharp.FS.GeoFileUtils;

namespace GeoSharp.Common {
	public static class Info {
		public static string versionFile = "";
		public static string versionTag = "0.1";

		public static string GetVersion() {
			return ReadFile(versionFile);
		}

		public static string GetVersionTag() {
			return versionTag;
		}
	}
}
