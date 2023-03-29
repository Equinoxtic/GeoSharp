using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static GeoSharp.Lib.StringUtils;

namespace GeoSharp.Lib {
	public static class TimeLib {
		public static string getDate() {
			return DateTime.Now.ToString("dd-MM-yyyy");
		}

		public static string getTime() {
			return DateTime.Now.ToString("HH:mm:ss");
		}

		public static string getShortTime() {
			return DateTime.Now.ToString("HH:mm");
		}

		public static string getTimeType(string timeType) {
			string s = "";
			if (!stringEmpty(timeType)) {
				switch(timeType) {
					case "date": s = getDate(); break;
					case "time": s = getTime(); break;
					case "short-time": s = getShortTime(); break;
					case "date-and-time": s = String.Format("{0} - {1}", getDate(), getTime()); break;
					case "date-and-short-time": s = String.Format("{0} - {1}", getDate(), getShortTime()); break;
					default: s = getDate(); break;
				}
			}
			return s.ToString();
		}
	}
}
