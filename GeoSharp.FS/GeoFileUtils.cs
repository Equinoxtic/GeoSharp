using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static GeoSharp.FS.GeoFile;
using static GeoSharp.Lib.StringUtils;

namespace GeoSharp.FS {
	public static class GeoFileUtils {
		public static string GetCWD() {
			return Directory.GetCurrentDirectory() + "/";
		}

		public static string GetFile(string path) {
			return String.Format("{0}{1}", GetCWD(), path).ToString();
		}

		public static string GetFileAndExt(string path, string ext) {
			return String.Format("{0}{1}.{2}", GetCWD(), path, ext).ToString();
		}

		public static void ClearFile(string path) {
			if (!File.Exists(path)) {
				throw new FileNotFoundException("File: " + QuoteString(path) + ", does not exist!");
			} else {
				OverwriteFile(path, "");
			}
		}
	}
}
