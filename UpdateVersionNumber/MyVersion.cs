public class MyVersion {
    public static int GetMajorVersion (Version _version) {
        return _version.Major;
    }
    public static int GetMinorVersion (Version _version) {
        return _version.Minor;
    }

    public static int GetBuildVersion (Version _version) {
        return _version.Build;
    }

    public static Version AddMajorVersion (Version _version) {
        Version newVersion = new Version (_version.Major + 1, _version.Minor, _version.Build);
        return newVersion;
    }
    public static Version AddMinorVersion (Version _version) {
        Version newVersion = new Version (_version.Major, _version.Minor + 1, _version.Build);
        return newVersion;
    }

    public static Version AddBuildVersion (Version _version) {
        Version newVersion = new Version (_version.Major, _version.Minor, _version.Build + 1);
        return newVersion;
    }

    public static Version AddBuildVersion (Version _version, int newBuildNumber) {
        Version newVersion = new Version (_version.Major, _version.Minor, newBuildNumber);
        return newVersion;
    }
}