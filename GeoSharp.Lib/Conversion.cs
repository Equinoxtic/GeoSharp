using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace GeoSharp.Lib {
	public static class Conversion {
		public static string IntToString(int n) {
			return (n.ToString());
		}

		public static int StringToInt(string s) {
			return (Convert.ToInt32(s));
		}
	}
}
