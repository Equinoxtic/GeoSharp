using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static GeoSharp.Lib.StringUtils;

namespace GeoSharp.Lib {
	public static class TimeLib {
		public static string GetDate() {
			return DateTime.Now.ToString("dd-MM-yyyy");
		}

		public static string GetTime() {
			return DateTime.Now.ToString("HH:mm:ss");
		}

		public static string GetShortTime() {
			return DateTime.Now.ToString("HH:mm");
		}

		public static string GetTimeType(string timeType) {
			string s = "";
			if (!StringEmpty(timeType)) {
				switch(timeType) {
					case "date": s = GetDate(); break;
					case "time": s = GetTime(); break;
					case "short-time": s = GetShortTime(); break;
					case "date-and-time": s = String.Format("{0} - {1}", GetDate(), GetTime()); break;
					case "date-and-short-time": s = String.Format("{0} - {1}", GetDate(), GetShortTime()); break;
					default: s = GetDate(); break;
				}
			}
			return s.ToString();
		}
	}
}
