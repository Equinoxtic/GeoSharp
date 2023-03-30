using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace GeoSharp.Lib {
	public static class ListUtils {
		public static void PushStringList(List<string> stringList) {
			for (int i = 0; i < stringList.Count; ++i) {
				Console.Write(stringList[i]);
			}
		}

		public static string ReturnStringFromStringList(List<string> stringList) {
			var s = new StringBuilder();
			for (int i = 0; i < stringList.Count; ++i) {
				s.Append(stringList[i].ToString());
			}
			return s.ToString();
		}

		public static void SetStringFromStringList(List<string> stringList, string t_string) {
			var s = new StringBuilder();
			for (int i = 0; i < stringList.Count; ++i) {
				s.Append(stringList[i].ToString());
			}
			t_string = s.ToString();
		}

		public static void PushIntList(List<int> intList) {
			for (int i = 0; i < intList.Count; ++i) {
				Console.Write(intList[i]);
			}
		}
	}
}
