using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static GeoSharp.Lib.StringUtils;
using static GeoSharp.Https.Link;

namespace GeoSharp.Https {
	public static class Browser {
		public static string GetLinkInfo(string link) {
			List<string> linkList = new List<string>() {
				"youtube.com", "github.com", "twitter.com",
				"facebook.com", "linkedin.com", "discord.com"
			};

			string site = "";
			for (int i = 0; i < linkList.Count; ++i) {
				switch(linkList[i]) {
					case "youtube.com": site = "YouTube"; break;
					case "github.com": site = "GitHub"; break;
					case "twitter.com": site = "Twitter"; break;
					case "facebook.com": site = "Facebook"; break;
					case "linkedin.com": site = "LinkedIn"; break;
					case "discord.com": site = "Discord"; break;
					default: site = linkList[i]; break;
				}

				if (link.Contains(linkList[i])) {
					break;
				}
			}

			string linkString = String.Format(
				"(Link): {0}\n(Website): {1}",
				link,
				SurroundString(site, "[", "]"));
			
			return linkString.ToString();
		}

		public static void Navigate(string link) {
			string s = String.Format("\nOpening {0}...", GetLinkInfo(link));
			OpenLink(link);
		}
	}
}
