using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace GeoSharp.Lib {
	public static class ArrayUtils {
		public static void pushStringArray(string[] stringArray) {
			for (int i = 0; i < stringArray.Length; ++i) {
				Console.Write(stringArray[i]);
			}
		}

		public static string returnStringFromStringArray(string[] stringArray) {
			var s = new StringBuilder();
			for (int i = 0; i < stringArray.Length; ++i) {
				s.Append(stringArray[i].ToString());
			}
			return s.ToString();
		}

		public static void setStringFromStringArray(string[] stringArray, string t_string) {
			var s = new StringBuilder();
			for (int i = 0; i < stringArray.Length; ++i) {
				s.Append(stringArray[i].ToString());
			}
			t_string = s.ToString();
		}

		public static void pushIntArray(int[] intArray) {
			for (int i = 0; i < intArray.Length; ++i) {
				Console.Write(intArray[i]);
			}
		}
	}
}
