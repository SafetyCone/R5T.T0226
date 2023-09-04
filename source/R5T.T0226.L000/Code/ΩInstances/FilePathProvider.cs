using System;


namespace R5T.T0226.L000
{
    public class FilePathProvider : IFilePathProvider
    {
        #region Infrastructure

        public static IFilePathProvider Instance { get; } = new FilePathProvider();


        private FilePathProvider()
        {
        }

        #endregion
    }
}


namespace R5T.T0226.L000.Internal
{
    public class FilePathProvider : IFilePathProvider
    {
        #region Infrastructure

        public static IFilePathProvider Instance { get; } = new FilePathProvider();


        private FilePathProvider()
        {
        }

        #endregion
    }
}
