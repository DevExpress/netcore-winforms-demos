using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace DevExpress.DevAV
{
    public class DevAVByteImageConverter
    {
        public static Image FromByteArray(byte[] b)
        {
            if (b == null || b.Length == 0) return null;
            Image i = null;
            if (b.Length > 78)
            {
                if (b[0] == 0x15 && b[1] == 0x1c)  //check signature
                    i = FromByteArray(b, 78);
            }
            if (i == null)
                i = FromByteArray(b, 0);
            return i;
        }


        protected static Image FromByteArray(byte[] b, int offset)
        {
            if (b == null || b.Length - offset <= 0) return null;
            Image tempI = null;
            System.IO.MemoryStream s = new System.IO.MemoryStream(b, offset, (int)b.Length - offset);
            try
            {
                tempI = ImageFromStream(s);
            }
            catch { }
            //s.Close();
            return tempI;
        }
        static Image ImageFromStream(Stream stream)
        {
            if (Object.ReferenceEquals(stream, null))
                return null;
            //if (!IsWin7 || !IsUnmanagedCodeGranted)
            //    return Image.FromStream(stream);
            //else
                return Image.FromStream(stream, false, false);
        }
        static bool IsWin7 {
            get {
                Version version = Environment.OSVersion.Version;
                return (version.Major == 6 && version.Minor >= 1) || version.Major > 6;
            }
        }
    }
}
