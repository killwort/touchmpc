using System.IO;

namespace TouchMPC
{
    class UnclosableStream : Stream
    {
        private readonly Stream _base;

        public UnclosableStream(Stream @base)
        {
            _base = @base;
        }

        public override void Flush()
        {
            _base.Flush();
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return _base.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            _base.SetLength(value);
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return _base.Read(buffer, offset, count);
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            _base.Write(buffer,offset,count);
        }

        public override bool CanRead
        {
            get { return _base.CanRead; }
        }

        public override bool CanSeek
        {
            get { return _base.CanSeek; }
        }

        public override bool CanWrite
        {
            get { return _base.CanWrite; }
        }

        public override long Length
        {
            get { return _base.Length; }
        }

        public override long Position { get { return _base.Position; } set { _base.Position = value; } }
    }
}