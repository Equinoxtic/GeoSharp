using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static GeoSharp.Lib.StringUtils;
using static GeoSharp.Lib.Sys.GeoSys;

namespace GeoSharp.Https {
	public static class Link {
		public static string CreateLink(string str, string protocol) {
			string prot_s = "";
			if (CompareString(protocol, "https")) {
				prot_s = "https://";
			} else if (CompareString(protocol, "http")) {
				prot_s = "http://";
			}
			return String.Format("{0}{1}", prot_s, str);
		}

		public static string AutoLink(string str, bool include_com = false) {
			string s = "";
			if (include_com) {
				s = String.Format("{0}.com", CreateLink(str, "https://"));
			} else {
				s = CreateLink(str, "https://");
			}
			return s;
		}

		public static void OpenLink(string link, string defaultProtocol = "https://") {
			string s = "";
			
			if (!link.StartsWith(defaultProtocol)) {
				s = CreateLink(link, defaultProtocol);
			} else {
				s = link;
			}

			if (IsOperatingSystem("Windows")) {
				ExecuteCommand(String.Format("start {0}", link));
			} else {
				ExecuteCommand(String.Format("xdg-open {0}", link));
			}
		}
	}
}
