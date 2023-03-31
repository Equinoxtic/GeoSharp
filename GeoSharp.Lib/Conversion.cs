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

		public static bool IntBool(int x) {
			bool res = false;
			if (x == 0) {
				res = false;
			} else if (x >= 1 || x < 0) {
				res = true;
			}
			return res;
		}

		public static int BoolInt(bool n) {
			return ((n) ? 1 : 0);
		}
	}
}
