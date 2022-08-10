using System.IO;

namespace Themerror.EmptyFolderRemover.Core.Extensions
{
    public static class StringExtensions
    {
        public static bool IsCleanablePath(this string path)
        {
            return Directory.Exists(path);
        }
    }
}