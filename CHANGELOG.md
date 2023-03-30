# GeoSharp Changelog

## Version (0.25)

---

* An update focused on bug fixes and a new `HTTPS` library.

Latest changes ([#2](https://github.com/Equinoxtic/GeoSharp/pull/2/commits/b0538eb88c5750dc27022b615e878682558d32a6))

---

## New Features

* New `HTTPS` library for handling links.
	+ `Link.cs` (`GeoSharp.Https.Link`)
	+ `Browser.cs` (`GeoSharp.Https.Browser`)
* `Link` - Is used for creating and opening links.
* `Browser` - Is used for getting information on links on certain hard-coded websites. (Built ontop of `Link`)

## Updates & Bug fixes

* Update Method names for all files.
* Updated Method: `GetFile()` for `GeoFile`:

```cs
// ===== Old Code =====
public static string getFile(string path) {
	string s = "";
	s = getCWD() + path;
	return s;
}

// ===== New Code =====
public static string GetFileAndExt(string path, string ext) {
	return String.Format("{0}{1}.{2}", GetCWD(), path, ext).ToString();
}
```

* New Method: `GetFileAndExt()` for `GeoFile`:

```cs
public static string GetFileAndExt(string path, string ext) {
	return String.Format("{0}{1}.{2}", GetCWD(), path, ext).ToString();
}
```
