# GeoSharp Changelog

## Version (0.32)

---

* A QoL focused update, regarding some bug fixes and some minor updates.

Latest changes ([#4](https://github.com/Equinoxtic/GeoSharp/pull/4))

---

## New Features

* New "Standard" library. (`GeoSharp.GStd`)
* New "Standard Input and Output" (`GeoSharp.GStd.GSio.GStdio`)
* Updated "Console" library for local logging and outputting console messages. (`GeoSharp.GStd.GeoConsole`)

## Updates & Bug fixes

* Remove `GeoSharp.Common` and it's files.
* Remove `GeoSharp.Logging` and it's files. (Is now replaced with `GeoSharp.GStd.GeoConsole`)
* New functions for `Lib.Conversions`
	+ `IntBool()` - Returns **true** if ``x >= 1`` or ``x < 0``, otherwise return false if ``x == 0``
	+ `BoolInt()` - Inverse type of `IntBool()`, returns **1** if `true` and **0** if false.
* Updated Method anmes and how certain Methods function for Built-In System Commands.

```cs
// ========== Old Code ==========
public static void systemPause() {
	if (IsOperatingSystem("Windows")) {
		system("pause");
	} else {
		system("read");
	}
}

public static void systemPauseExit() {
	if (IsOperatingSystem("Windows")) {
		system("pause");
	} else {
		system("read");
	}
	System.Environment.Exit(0);
}

// ========== New Code ==========
public static void SystemPause() {
	Console.ReadKey();
}

public static void SystemPauseExit() {
	Console.ReadKey();
	System.Environment.Exit(0);
}
```
