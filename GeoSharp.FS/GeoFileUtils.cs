using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static GeoSharp.FS.GeoFile;
using static GeoSharp.Lib.StringUtils;

namespace GeoSharp.FS {
	public static class GeoFileUtils {
		public static string getCWD() {
			return Directory.GetCurrentDirectory() + "/";
		}

		public static string getFile(string path) {
			string s = "";
			s = getCWD() + path;
			return s;
		}

		public static void clearFile(string path) {
			if (!File.Exists(path)) {
				throw new FileNotFoundException("File: " + quoteString(path) + ", does not exist!");
			} else {
				overwriteFile(path, "");
			}
		}
	}
}
