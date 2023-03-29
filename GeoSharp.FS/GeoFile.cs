using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static GeoSharp.Lib.StringUtils;
using static GeoSharp.FS.GeoFileUtils;

namespace GeoSharp.FS {
	public static class GeoFile {
		public static void createFile(string name) {
			if (stringEmpty(name)) {
				throw new FileNotFoundException("File: {0}, cannot be created!", quoteString(name));
			} else {
				if (!File.Exists(name)) {
					File.Create(getFile(name)).Close();
				} else {
					Console.WriteLine("File: {0}, already exists!", quoteString(name));
				}
			}
		}

		public static void writeToFile(string path, string text) {
			if (!File.Exists(path)) {
				throw new FileNotFoundException("File: {0}, cannot be found!", quoteString(path));
			} else {
				using (StreamWriter sw = File.AppendText(getFile(path))) {
					sw.WriteLine(text);
				}
			}
		}

		public static void overwriteFile(string path, string text) {
			if (!File.Exists(path)) {
				throw new FileNotFoundException("File: {0}, cannot be found!", quoteString(path));
			} else {
				using (StreamWriter sw = File.CreateText(getFile(path))) {
					sw.WriteLine(text);
				}
			}
		}

		public static string readFile(string path) {
			string fs = "";
			if (!File.Exists(path)) {
				throw new FileNotFoundException("File: {0}, cannot be found!", quoteString(path));
			} else {
				using (StreamReader sr = File.OpenText(getFile(path))) {
					fs = sr.ReadLine();
				}
			}
			return fs.ToString();
		}
	}
}
