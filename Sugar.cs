using System.IO;

namespace TouchMPC
{
    static class Sugar
    {
        public static UnclosableStream AsUnclosable(this Stream stream)
        {
            return new UnclosableStream(stream);
        }
    }
}