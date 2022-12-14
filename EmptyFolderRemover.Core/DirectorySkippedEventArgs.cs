using System;

namespace Themerror.EmptyFolderRemover.Core
{
    public class DirectorySkippedEventArgs : DirectoryScannedEventArgs
    {
        public Exception Exception { get; private set; }

        public DirectorySkippedEventArgs(FreshDirectory result, Exception exception) 
            : base(result)
        {
            Exception = exception;
        }

        public override string ToString()
        {
            return "Skipped";
        }
    }
}