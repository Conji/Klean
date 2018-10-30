using Oxide.Ext.Klean.Updater.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Oxide.Ext.Klean.Updater
{
    public class Version : IComparable<Version>
    {
        static Regex VERSION_REGEX = new Regex(@"^(\d+)(.\d+)*(.\d+)*(PRERELEASE|RELEASE|ALPHA|BETA)$", RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);

        public int Major { get; set; }
        public int Minor { get; set; }
        public int Sub { get; set; }
        public VersionModifier Modifier { get; set; }

        public Version(string version)
        {
            var result = VERSION_REGEX.Match(version);
            if (!result.Success) throw new VersionInvalidException();
            if (int.TryParse(result.Groups[0].Value, out var major)) Major = major;
            if (int.TryParse(result.Groups[1].Value, out var minor)) Minor = minor;
            if (int.TryParse(result.Groups[2].Value, out var sub)) Sub = sub;
            if (Enum.TryParse<VersionModifier>(result.Groups[3].Value, out var modifier)) Modifier = modifier;
        }

        public Version() : this(1, 0, 0, VersionModifier.RELEASE) { }

        public Version(int major) : this(major, 0, 0, VersionModifier.RELEASE) { }

        public Version(int major, int minor) : this(major, minor, 0, VersionModifier.RELEASE) { }

        public Version(int major, int minor, int sub): this(major, minor, sub, VersionModifier.RELEASE) { }

        public Version(int major, int minor, int sub, VersionModifier modifier)
        {
            Major = major;
            Minor = minor;
            Sub = sub;
            Modifier = modifier;
        }

        public int CompareTo(Version other)
        {
            if (Major != other.Major) return Major.CompareTo(other.Major);
            if (Minor != other.Minor) return Minor.CompareTo(other.Minor);
            if (Sub != other.Sub) return Sub.CompareTo(other.Sub);
            if (Modifier != other.Modifier) return Sub.CompareTo(other.Modifier);
            return 0;
        }
    }
}
