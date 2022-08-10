using System;

namespace Themerror.EmptyFolderRemover.Core
{
    public abstract class DirectoryScannedEventArgs : EventArgs
    {
        public FreshDirectory Directory { get; private set; }

        protected DirectoryScannedEventArgs(FreshDirectory result)
        {
            Directory = result;
        }

        public override string ToString()
        {
            return "Scanned.";
        }
    }
}