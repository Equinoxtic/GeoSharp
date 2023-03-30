using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static GeoSharp.Lib.ListUtils;

namespace GeoSharp.Lib {
	public static class StringUtils {
		public static string RepeatString(string str, int length = 1) {
			var s = new StringBuilder();
			for (int i = 0; i < length; ++i) {
				s.Append(str.ToString());
			}
			return s.ToString();
		}

		public static string SurroundString(string str, string strA, string strB) {
			return String.Format("{0}{1}{2}", strA, str, strB).ToString();
		}

		public static string SeperateString(string str, string strSeperator, int length) {
			var s = new StringBuilder();
			for (int i = 0; i < str.Length; ++i) {
				s.Append(str[i].ToString());
				if ((i % length) == 0) {
					s.Append(strSeperator);
				}
			}
			return s.ToString();
		}

		public static string QuoteString(string str) {
			return SurroundString(str, "\"", "\"");
		}

		public static bool CompareString(string strA, string strB) {
			return (String.Compare(strA, strB) == 0);
		}

		public static bool StringEmpty(string str) {
			return (String.IsNullOrEmpty(str) || String.IsNullOrWhiteSpace(str));
		}
	}
}
